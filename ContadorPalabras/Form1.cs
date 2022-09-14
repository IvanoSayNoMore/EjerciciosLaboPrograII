using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorPalabras
{
    public partial class ContadorDePalabras : Form
    {
        private Dictionary<string, int> diccionario;
        private List<string> listaPalabras;
        private Stack<string> soloPalabras = new Stack<string>();
        public ContadorDePalabras()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
            listaPalabras = new List<string>();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ContarPalabras(rchTextIn.Text);
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
            string dlt = "" ;
           
            int lenlistDiccionario = diccionario.Count;
            if(lenlistDiccionario == 0)
            {
                sb.AppendLine("No se cargaron palabras en esta vuelta ");
            }
            else
            {
                while (i < lenlistDiccionario)
                {
                    //foreach (var elemento in diccionario)
                    foreach (KeyValuePair<string, int> elemento in diccionario)
                    {
                        if (diccionario.Values.Min() == elemento.Value && i < lenlistDiccionario)//Ordena Mayor a menor. Values.Min() o Values.Max()
                        {
                            dlt = elemento.Key;
                            sb.AppendLine($"{elemento.Key}   {elemento.Value}");
                            break;
                        }
                    }

                    if (diccionario.Remove(dlt))
                    {
                        i++;
                    }
                }
            }


            return sb.ToString();
        }

    }
}

