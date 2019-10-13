using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCantina;
using Entidades;

namespace FrmCantina
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.barra.SetCantina = Cantina.GetCantina(10);
            cmbTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbTipo.SelectedValue.ToString(), out tipo);
            

            if (rBtnAgua.Checked)
            {
                Agua botellaAgua = new Agua(txtMarca.Text, (int)numCapacidad.Value, (int)numContenido.Value);
                this.barra.AgregarBotella(botellaAgua);

            }
            else if (rBtnCerveza.Checked)
            {
                Cerveza botellaCerveza = new Cerveza(txtMarca.Text, (int)numCapacidad.Value, (int)numContenido.Value,tipo);
                this.barra.AgregarBotella(botellaCerveza);
            }
            else
            {
                MessageBox.Show("seleccione tipo");
            }
        }
    }
}
