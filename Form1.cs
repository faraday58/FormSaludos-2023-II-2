using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSaludos_2023_II_2
{
    public partial class Form1 : Form
    {
        int contador=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            contador++;
            // lbEtiqueta.Text = "Introduce tu nombre " + contador.ToString();
            lbEtiqueta.Text = String.Format("Introduce tu nombre  {0}",  contador);  

            MessageBox.Show(" Hola " + txtbNombre.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbNombre.Text = "";
        }
    }
}
