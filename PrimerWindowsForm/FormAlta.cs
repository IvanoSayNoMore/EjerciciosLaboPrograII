using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerWindowsForm
{
    public partial class FormAlta : Form
    {
        public Persona persona;
        public FormAlta()
        {
            InitializeComponent();
        }
        private void cargar_Click(object sender, EventArgs e)
        {
            //Devuelva DialogResult.Ok
            string apellido = textApellido.Text;

            string nombre = textNombre.Text;

            persona = new Persona(nombre, apellido);

            DialogResult = DialogResult.OK;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void FormAlta_Load_1(object sender, EventArgs e)
        {

        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {
            string texto = textApellido.Text;
            
            label1.Text = texto;

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
            label1.Text = nombre;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
