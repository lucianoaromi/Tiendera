using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        // ====== Resolución de pantalla (Win32) ======
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        private struct DEVMODE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;

            public int dmPositionX;
            public int dmPositionY;
            public int dmDisplayOrientation;
            public int dmDisplayFixedOutput;

            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmFormName;

            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;

            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        private static extern bool EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE devMode);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        private static extern int ChangeDisplaySettings(ref DEVMODE devMode, int flags);

        private const int ENUM_CURRENT_SETTINGS = -1;
        private const int DM_PELSWIDTH = 0x00080000;
        private const int DM_PELSHEIGHT = 0x00100000;

        private const int DISP_CHANGE_SUCCESSFUL = 0;

        private static DEVMODE GetCurrentMode()
        {
            DEVMODE dm = new DEVMODE
            {
                dmDeviceName = new string('\0', 32),
                dmFormName = new string('\0', 32)
            };
            dm.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));

            if (!EnumDisplaySettings(null, ENUM_CURRENT_SETTINGS, ref dm))
                throw new Exception("No se pudo leer la configuración actual del display.");

            return dm;
        }

        private static bool SetResolution(int width, int height)
        {
            DEVMODE dm = GetCurrentMode();

            dm.dmPelsWidth = width;
            dm.dmPelsHeight = height;
            dm.dmFields |= (DM_PELSWIDTH | DM_PELSHEIGHT);

            int result = ChangeDisplaySettings(ref dm, 0);
            return result == DISP_CHANGE_SUCCESSFUL;
        }

        private static bool RestoreMode(DEVMODE original)
        {
            original.dmFields |= (DM_PELSWIDTH | DM_PELSHEIGHT);
            int result = ChangeDisplaySettings(ref original, 0);
            return result == DISP_CHANGE_SUCCESSFUL;
        }

        // Guardamos la resolución original para restaurarla luego
        private DEVMODE? _originalMode = null;

        // Cambia a 1280x720 (y guarda original si hace falta)
        private void Apply720p()
        {
            if (_originalMode == null)
                _originalMode = GetCurrentMode();

            bool changed = SetResolution(1280, 720);
            if (!changed)
            {
                // Podés comentar este aviso si no lo querés
                MessageBox.Show(
                    "No se pudo cambiar la resolución a 1280x720 (puede que tu monitor/driver no la soporte).",
                    "Resolución",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // ==========================================

        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            // (Opcional) Restaurar si el usuario cierra desde el login
            if (_originalMode != null)
                RestoreMode(_originalMode.Value);

            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            // Obteniendo una lista de usuarios y lo almacena en una lista de tipo Usuario llamada TEST
            List<Usuario> TEST = new CN_Usuario().Listar();

            try
            {
                // Verifica si los valores en los TextBox son "ADMIN"
                if (txtdocumento.Text == "ADMINLICENCIA123" && txtclave.Text == "ADMINLICENCIA123")
                {
                    // ✅ Login correcto -> Cambiar resolución
                    Apply720p();

                    // Si son "ADMIN", abre el formulario nuevo
                    frmAdmLicencia formAdmin = new frmAdmLicencia();
                    formAdmin.Show();

                    // Ocultar el formulario actual (Login).
                    this.Hide();

                    // Permite cerrar el formulario actual cuando se cierra el formulario de administración
                    formAdmin.FormClosing += Frm_closing;
                }
                else
                {
                    // Devuelve solo una clase de la lista de clases, los cuales tienen documento y clave iguales a los que se encuentran en los TextBoxs
                    Usuario ousuario = TEST.Where(l => l.Documento == txtdocumento.Text).FirstOrDefault();

                    // Si se encuentra resultados
                    if (ousuario != null)
                    {
                        // Verifica la contraseña hashada
                        bool passwordMatches = BCrypt.Net.BCrypt.EnhancedVerify(txtclave.Text, ousuario.Clave);

                        if (passwordMatches)
                        {
                            // ✅ Login correcto -> Cambiar resolución
                            Apply720p();

                            // Llama al formulario Inicio y se le envía el parámetro objeto "ousuario"
                            Inicio form = new Inicio(ousuario);
                            form.Show();

                            // Ocultar el formulario actual (Login).
                            this.Hide();

                            // Permite cerrar el formulario actual cuando se cierra el formulario de inicio
                            form.FormClosing += Frm_closing;
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_closing(object sender, FormClosingEventArgs e)
        {
            // Restaurar la resolución original al volver al Login
            if (_originalMode != null)
            {
                try
                {
                    RestoreMode(_originalMode.Value);
                }
                catch
                {
                    // Ignorar si falla
                }
            }

            //Al volver al formulario de "Login" borra los datos de los textbox
            txtdocumento.Text = "";
            txtclave.Text = "";

            //Mostrar el propio formulario
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
