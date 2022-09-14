using System.Text;

namespace PrimerWindowsForm
{
    public partial class Form1 : Form
    {

        private Persona[] _persona;
        public Form1()
        {
            InitializeComponent();

            _persona = new Persona[6];
            _persona[0] = new Persona("Ivano", "Fabelon");
            _persona[1] = new Persona("Enano", "Zazu");
            _persona[2] = new Persona("Peluza", "ElDie");
            _persona[3] = new Persona("Luna", "Medina");
            _persona[4] = new Persona("Abu", "Aladin");
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            label1.Text = texto;

            FormAlta fa = new FormAlta();
            

            DialogResult dg = fa.ShowDialog();
            
            if (dg == DialogResult.OK)
            {
                string persona = fa.persona.MostrarInfo();
                MessageBox.Show(persona);
            }
            else
            {
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Hola gato";
         
        }

        private void cargarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormAlta fa = new FormAlta();
           
            DialogResult dg = fa.ShowDialog();

            if (dg == DialogResult.OK)
            {

                _persona[5] = new Persona(fa.persona.name, fa.persona.lastname);
            

               // mostrarNombreAp.Text = persona;
              //  MessageBox.Show(persona);
            }
            else
            {
                MessageBox.Show("Mal ahi perrito malvado");
            }
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _persona.Length; i++)
            {
               sb.AppendLine(_persona[i].MostrarInfo());
            }
            mostrarNombreAp.Text = sb.ToString();
            // mostrarNombreAp
        }
    }
}