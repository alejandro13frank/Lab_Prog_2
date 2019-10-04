using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;
namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Producto producto;
        private Comiqueria comiqueria;
        public VentasForm(Producto producto,Comiqueria comiqueria)
        {
            InitializeComponent();
            this.producto = producto;
            this.comiqueria = comiqueria;
        }

        private void NumericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            lblPrecioFinal.Text = $"Precio Final: ${this.producto.Precio*int.Parse(lblCantidad.Text)}";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            if (int.Parse(numericUpDownCantidad.Text)>this.producto.Stock)
            {
                this.comiqueria.Vender(producto, int.Parse(lblCantidad.Text));
                MessageBox.Show("se vendio correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, supera el stock", "Falta stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
