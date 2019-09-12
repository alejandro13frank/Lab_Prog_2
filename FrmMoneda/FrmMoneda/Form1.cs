using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMoneda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        private void btnLockCotizacion(object sender, EventArgs e)
        {
            if (btnCandado.ImageIndex==1)
            {
                btnCandado.ImageIndex = 0;
                txtNombre.Text = "PIKACHU";
            }
            else
            {
                btnCandado.ImageIndex = 1;
                txtNombre.Text = "EEVEE";
            }
        }
    }
}
