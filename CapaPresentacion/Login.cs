using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            //Obteniendo una lista de usuarios y lo almacena en una lista de tipo Usuario llamada TEST
            List<Usuario> TEST = new CN_Usuario().Listar();

            //Devuelve solo una clase de la lista de clases, los cuales tienen documento y clave iguales a los que se encuentran en los texbox
            //Utiliza expresiones "Lambda" para comprara los datos en los textboxs y la base
            //FirstOrDefault(). Devuelve el primer elemento de la secuencia (o null si no se encuentra ningún elemento que cumpla con el filtro)
            Usuario ousuario = new CN_Usuario().Listar().Where(l => l.Documento == txtdocumento.Text).FirstOrDefault();

            // si se encuentra resultados
            if (ousuario != null)
            {
                bool passwordMatches = BCrypt.Net.BCrypt.EnhancedVerify(txtclave.Text, ousuario.Clave);

                // si las contraseñas coinciden
                if (passwordMatches) {

                    //llama al formulario Inicio y se le envia el parametro objeto "ousuario"
                    Inicio form = new Inicio(ousuario);

                    form.Show();
                    //ocultar el formulario actual (Login).
                    this.Hide();
                    //Permite cerrar el formulario, unir la funcion de llamar al formulario de Inicio
                    form.FormClosing += frm_closing;
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //Se instancia una clase Inicio y se le envia como parametro un objeto de tipo usuario
                

            }
            else
            {
                MessageBox.Show("No se encontro el usario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
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
