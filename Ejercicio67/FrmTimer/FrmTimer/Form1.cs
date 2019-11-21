using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTimer
{
    public partial class Form1 : Form
    {
        Timer temporizador;
        public Form1()
        {
            InitializeComponent();
            this.temporizador = new Timer();
        }

        private void ActualizarHora()
        {
            if (this.lblHora.InvokeRequired)
            {
                EncargadoTiempo d = new EncargadoTiempo(ActualizarHora);
                this.Invoke(d);
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            this.temporizador.eventoTiempo += ActualizarHora;
            this.temporizador.Activo = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.temporizador.Activo = false;
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            this.temporizador.Activo = !this.temporizador.Activo;
        }
    }
}
