using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace FrmSistemaSolar
{
    public partial class Form1 : Form
    {
        private List<Astro> planeta;
        public Form1()
        {
            InitializeComponent();
            cmbTipo.Items.Add(Tipo.Gaseoso);
            cmbTipo.Items.Add(Tipo.Rocoso);
        }

        private void BtnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            if (txtNombrePlaneta.Text=="" || txtOrbitaPlaneta.Text=="" || numRotacion.Value<=0 || numSatelite.Value<=0 || cmbTipo.Text=="" )
            {
                MessageBox.Show("se deben ingresar todos los datos del planeta");
            }
            else
            {
                Planeta planetaNuevo = new Planeta(int.Parse(txtOrbitaPlaneta.Text), (int)numRotacion.Value, txtNombrePlaneta.Text,(int)numSatelite.Value,Tipo.Gaseoso);
            }
        }
    }
}
