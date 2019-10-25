using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
using frmLlamador;
namespace FmrCentralTelefonica
{
  public partial class Form1 : Form
  {
    Centralita c;
    public Form1()
    {
      InitializeComponent();
      this.c = new Centralita();
    }

    private void btnGenerarLlamada_Click(object sender, EventArgs e)
    {
      new frmLlamador.form1(c).ShowDialog();  
    }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(c);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
            frmMostrar.Mostrar();
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(c);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Local;
            frmMostrar.Mostrar();
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionProv_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(c);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Provincial;
            frmMostrar.Mostrar();
            frmMostrar.ShowDialog();
        }
    }
}
