using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Modales;

namespace CapaPresentacion.Modales
{
    public partial class ProductoDetalles : Form
    {
        public ProductoDetalles()
        {
            InitializeComponent();
        }

        public void FormDetalles_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            txtCategoria.ReadOnly = true;
            txtStock.ReadOnly = true;
            txtPrecio.ReadOnly = true;

            txtId.TabStop = false; // Evitar que sea accesible por tabulación
            txtNombre.TabStop = false; // Evitar que sea accesible por tabulación
            txtDescripcion.TabStop = false; // Evitar que sea accesible por tabulación
            txtCategoria.TabStop = false; // Evitar que sea accesible por tabulación
            txtStock.TabStop = false; // Evitar que sea accesible por tabulación
            txtPrecio.TabStop = false; // Evitar que sea accesible por tabulación
            this.ActiveControl = null; // Ningún control tiene el foco al inicio
        }
    }
}
