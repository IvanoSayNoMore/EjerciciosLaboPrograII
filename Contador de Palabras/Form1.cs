using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador_de_Palabras
{
    public partial class ContadorPalabras : Form
    {
        private Dictionary<string, int> diccionario;
        private List<string> listaPalabras;
        public ContadorPalabras()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
            listaPalabras = new List<string>();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            ContarPalabras(textIn.Text);         
            MessageBox.Show(Mostrar());
        }

        public void ContarPalabras(string texto)
        {
            char[] separacion = new char[] { ' ', ',', '.', ':', '\t' };
            listaPalabras.AddRange(texto.Split(separacion, StringSplitOptions.RemoveEmptyEntries));
            
            foreach (string palabra in listaPalabras)
            {
                if (!diccionario.ContainsKey(palabra) && palabra != " ")
                {
                    diccionario.Add(palabra, 1);
                }
                else
                {
                    diccionario[palabra] += 1;
                }
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            string eliminar = "";
            int lenlist = listaPalabras.Count;
            MessageBox.Show("Cantidad "+lenlist);
            while (i < lenlist)
            {
                foreach (KeyValuePair<string, int> elemento in diccionario)
                {
                    MessageBox.Show("paso1");
                    if (diccionario.Values.Max() == elemento.Value && i < lenlist)
                    {
                        MessageBox.Show("paso2");
                        eliminar = elemento.Key;
                        sb.AppendLine($"{elemento.Key}   {elemento.Value}");
                        break;
                    }
                }

                if (diccionario.Remove(eliminar))
                { 
                    i++;
                    MessageBox.Show("i" + i);
                }
            }

            return sb.ToString();
        }
    }
}