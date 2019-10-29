using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio56
{
    public partial class Form1 : Form
    {
        string archivo;  
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "0 Caracteres";
            archivo = null;
        }

        private void stripMenuBtnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
           if (openFileDialog.ShowDialog().ToString() == "OK")
            {
                string sr = openFileDialog.FileName;
                StreamReader streamReader = new StreamReader(sr);

                rtxtboxTexto.Text =streamReader.ReadToEnd();
            }           
        }

        private void stripMenuBtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void rtxtboxTexto_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{rtxtboxTexto.Text.Length.ToString()} Caracteres";
        }
    }
}
