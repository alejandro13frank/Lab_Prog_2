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
namespace FmrCentralTelefonica
{
    public partial class FrmMostrar : Form
    {
        Llamada.TipoLlamada tipoLlamada;
        Centralita c;

        public FrmMostrar(Centralita c)
        {
            this.c = c;
            InitializeComponent();
        }
        public Llamada.TipoLlamada TipoLlamada 
        {
            set
            {
                this.tipoLlamada = value;
            }   
        }
        public void Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("");
            if (this.tipoLlamada == Llamada.TipoLlamada.Local)
            {
                richTextBox1.Text = (stringBuilder.AppendFormat("Facturacion Local total: {0}", c.GananciasPorLocal)).ToString();

            }
            else if ((this.tipoLlamada == Llamada.TipoLlamada.Provincial))
            {
                richTextBox1.Text = (stringBuilder.AppendFormat("Facturacion Provincial total: {0}", c.GananciasPorProvincial)).ToString();
                //stringBuilder.AppendFormat("Facturacion Provincial total: {0}", c.GananciasPorProvincial);
            }
            else
            {
                richTextBox1.Text = (stringBuilder.AppendFormat("Facturacion Total: {0}", c.GananciasPorTotal)).ToString();
                //stringBuilder.AppendFormat("Facturacion Total: {0}", c.GananciasPorTotal);
            }
            //return stringBuilder.ToString();
        }
    }
}
