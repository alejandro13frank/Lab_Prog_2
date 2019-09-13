using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int compararKey(KeyValuePair<string,int> a, KeyValuePair<string, int> b)
        {
            return -a.Value.CompareTo(b.Value);
        }

        private void btnCalcularPalabras(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();
            string[] arrayDeString;
            char[] arrayDeChar = {' ',',',';','.',':','\n','\t'};
            arrayDeString = rtxtTexto.Text.Split(arrayDeChar);
            for (int i = 0; i < arrayDeString.Length; i++)
            {
                if (arrayDeString[i] != "")
                {
                    try
                    {
                        contadorPalabras.Add(arrayDeString[i], 1);
                    }
                    catch (ArgumentException)
                    {
                        contadorPalabras[arrayDeString[i]]++;
                    }
                }
                
            }
           foreach (KeyValuePair<string, int> palabra in contadorPalabras)
            {
                MessageBox.Show($"Palabra : {palabra.Key}\n repeticiones: {palabra.Value}");
            }
            List<KeyValuePair<string, int>> auxLista = contadorPalabras.ToList();

            auxLista.Sort(compararKey);

            foreach (KeyValuePair<string, int> palabra in auxLista)
            {
                MessageBox.Show($"palabra: {palabra.Key}\n  repeticiones: {palabra.Value}");
            } 
        }
    }
}
