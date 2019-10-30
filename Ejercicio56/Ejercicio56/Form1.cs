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
        string ultimoTxt; 
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "0 Caracteres";
            ultimoTxt = "";
        }

        private void stripMenuBtnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
           if (openFileDialog.ShowDialog().ToString() == "OK")
            {
                string sr = openFileDialog.FileName;
                StreamReader streamReader = new StreamReader(sr);
                this.ultimoTxt = sr;
                rtxtboxTexto.Text =streamReader.ReadToEnd();
                streamReader.Close();
            }           
        }

        private void stripMenuBtnGuardar_Click(object sender, EventArgs e)
        {
            if (ultimoTxt=="")
            {
                stripMenuBtnGuardarComo_Click(sender,e);
            }
            else
            {
                StreamWriter streamWriter = new StreamWriter(ultimoTxt);
                streamWriter.Write(rtxtboxTexto.Text);
                streamWriter.Close();
            }
        }

        private void rtxtboxTexto_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{rtxtboxTexto.Text.Length.ToString()} Caracteres";
        }

        private void stripMenuBtnGuardarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog().ToString() == "OK")
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.Write(rtxtboxTexto.Text);
                streamWriter.Close();
            }
        }
    }
}
