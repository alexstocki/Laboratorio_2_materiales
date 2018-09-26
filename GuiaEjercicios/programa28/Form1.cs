using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            Dictionary<string, int> palabrasMasUsadas = new Dictionary<string, int>();
            string[] arrayPalabras;
            string caja = cajaDeTexto.Text;

            arrayPalabras = caja.Split(' ');

            int min = -1;
            int top;

            KeyValuePair<string, int> maximo = new KeyValuePair<string, int>("duoy", 1);

            for(int i = 0; i < arrayPalabras.Count(); i++)
            {
                if (!diccionario.ContainsKey(arrayPalabras[i]))
                {
                    diccionario.Add(arrayPalabras[i], 1);
                }
                else
                {
                    diccionario[arrayPalabras[i]] += 1;
                }
            }

            cajaDeTexto.Text = string.Empty;

            diccionario.Remove(" ");

            foreach (KeyValuePair<string, int> palabra in diccionario)
                cajaDeTexto.Text = cajaDeTexto.Text + "\n" + palabra.Key + palabra.Value;

            if (diccionario.Count() < 3)
                top = diccionario.Count();
            else
                top = 3;

            for (int i = 0; i < top; i++)
            {
                min = -1;
                foreach (KeyValuePair<string, int> palabra in diccionario)
                    if (palabra.Value > min && !palabrasMasUsadas.ContainsKey(palabra.Key))
                    {
                        min = palabra.Value;
                        maximo = palabra;
                    }
                palabrasMasUsadas.Add(maximo.Key, maximo.Value);
                cajaDeTexto.Text = cajaDeTexto.Text + "\nLa palabra mas usada es : " + maximo.Key;
            }

        }
    }
}
