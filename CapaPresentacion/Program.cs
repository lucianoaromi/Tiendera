using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using System.Drawing;

using System.IO;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instanciar la capa de negocio para verificar el estado
            SoftwareStateBLL softwareStateBLL = new SoftwareStateBLL();

            try
            {
                // Verificar si el software puede usarse
                if (softwareStateBLL.VerificarUsoPermitido(out int diasRestantes))
                {
                    if (diasRestantes == -1)
                    {
                        // El software no tiene limitación de tiempo, se lanza la aplicación normalmente
                        Application.Run(new Login()); // Reemplaza 'Login' con el formulario principal de tu aplicación
                    }
                    else
                    {
                        // El software está dentro del período de prueba, se lanza la aplicación
                        Application.Run(new Login()); // Reemplaza 'Login' con el formulario principal de tu aplicación
                    }
                }
                else
                {
                    // Si no se puede usar, mostrar un cuadro de diálogo para ingresar el código de activación
                    string codigoActivacion = Prompt.ShowDialog("El software ha expirado. Ingrese el código de activación para continuar:", "Activación de Software");

                    if (softwareStateBLL.ActivarSoftware(codigoActivacion))
                    {
                        // Si el código es correcto, activar el software y lanzar la aplicación
                        SaveActivationDate(); // Guarda la fecha de activación
                        Application.Run(new Login()); // Reemplaza 'Login' con el formulario principal de tu aplicación
                    }
                    else
                    {
                        // Si el código es incorrecto, mostrar mensaje de error
                        MessageBox.Show("Código de activación incorrecto. La aplicación se cerrará.", "Error de activación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();  // Cierra la aplicación si el código es incorrecto
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error al verificar el estado del software: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();  // Cierra la aplicación si ocurre un error en el proceso
            }
        }

        // Verifica la validez de la fecha de activación
        private static bool IsActivated()
        {
            string activationFile = "activation.txt"; // Archivo donde se guarda la fecha de activación
            if (File.Exists(activationFile))
            {
                DateTime activationDate = DateTime.Parse(File.ReadAllText(activationFile));
                DateTime currentDate = DateTime.Now;

                // Verifica que la fecha de activación no sea en el futuro y que el tiempo transcurrido sea válido
                if (currentDate > activationDate.AddDays(30)) // 30 días para una prueba, ajustable
                {
                    return false;
                }

                return true;
            }
            return false;
        }

        // Guarda la fecha de activación
        private static void SaveActivationDate()
        {
            string activationFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "activation.txt");
            File.WriteAllText(activationFile, DateTime.Now.ToString());
            MessageBox.Show("El archivo de activación se guarda en: " + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "activation.txt"));

        }


    }

    // Clase para mostrar un cuadro de texto personalizado para ingresar el código de activación
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            // Crear la ventana de diálogo
            Form prompt = new Form()
            {
                Width = 600, // Aumenta el tamaño de la ventana para ajustar el texto
                Height = 220, // Mantiene la altura ajustada
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen, // Centra la ventana en la pantalla
                FormBorderStyle = FormBorderStyle.FixedDialog, // Evita que se pueda cambiar el tamaño
                MaximizeBox = false, // Evita maximizar la ventana
                MinimizeBox = false // Evita minimizar la ventana
            };

            // Etiqueta con el texto
            Label textLabel = new Label()
            {
                Left = 20,
                Top = 20,
                Text = text,
                Width = 540, // Ajusta el tamaño de la etiqueta para que todo el texto se vea
                Font = new Font("Arial", 9, FontStyle.Regular), // Fuente más pequeña
                TextAlign = ContentAlignment.MiddleCenter, // Centrar el texto
                AutoSize = false, // Evita que cambie de tamaño automáticamente
                Height = 40 // Ajusta la altura de la etiqueta
            };

            // Cuadro de texto donde se ingresa el código
            TextBox textBox = new TextBox()
            {
                Left = 20,
                Top = textLabel.Bottom + 10, // Posiciona el TextBox debajo de la etiqueta
                Width = 540, // Ajusta el ancho del cuadro de texto
                Font = new Font("Arial", 9), // Fuente más pequeña
                BorderStyle = BorderStyle.Fixed3D, // Borde en 3D
                TextAlign = HorizontalAlignment.Center // Centra el texto dentro del cuadro de texto
            };

            // Botón de confirmación
            Button confirmation = new Button()
            {
                Text = "Aceptar",
                Left = 230, // Centra el botón horizontalmente
                Width = 120, // Botón más pequeño
                Height = 30, // Ajusta la altura del botón
                Top = textBox.Bottom + 10, // Posiciona el botón debajo del cuadro de texto
                DialogResult = DialogResult.OK,
                Font = new Font("Arial", 9, FontStyle.Regular), // Fuente moderada
                FlatStyle = FlatStyle.Flat, // Botón plano
                Cursor = Cursors.Hand // Cambia el cursor a mano
            };

            // Evento al hacer clic en el botón de confirmación
            confirmation.Click += (sender, e) => { prompt.Close(); };

            // Agregar los controles a la ventana
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            // Mostrar la ventana y devolver el texto ingresado
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }


}



