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
namespace frmLlamador
{
  public partial class form1 : Form
  {
    Centralita c;
        
        public Centralita Central
        {
            get
            {
                return this.c;
            }
        }
        public form1()
    {
        InitializeComponent();
    }
    public form1(Centralita c)
    {
        InitializeComponent();
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.c = c;
    }
        private void SetNumeroDestino(string numero)
        {
            if (this.txtNroDestino.Text == "Nro Destino")
            {
                this.txtNroDestino.Text = numero;
            }
            else
            {
                this.txtNroDestino.Text += numero;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetNumeroDestino("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SetNumeroDestino("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SetNumeroDestino("3");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SetNumeroDestino("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SetNumeroDestino("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            SetNumeroDestino("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SetNumeroDestino("7");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            SetNumeroDestino("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            SetNumeroDestino("9");
        }
        private void button0_Click(object sender, EventArgs e)
        {
            SetNumeroDestino("0");
        }

        private void buttonAsterisco_Click(object sender, EventArgs e)
        {
            SetNumeroDestino("*");
        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            SetNumeroDestino("#");
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (txtNroDestino.Text== "#")
            {
                cmbFranja.Enabled = true;
            }
            else
            {
                cmbFranja.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
            txtNroOrigen.Text = "";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Provincial.Franja franja;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);
            Random random = new Random();
            if (txtNroDestino.Text[0]=='#')
            {
                this.c += (new Provincial(txtNroOrigen.Text,franja,random.Next(1,50),txtNroDestino.Text));
            }
            else
            {

                try
                {
                    this.c += (new Local(txtNroOrigen.Text, random.Next(1, 50), txtNroDestino.Text, (float)random.Next(5, 56) / 10));
                }
                catch (CentralitaException nombreque)
                {   
                    MessageBox.Show(nombreque.Message);
                }
               
            }
            MessageBox.Show("La llamada se agrego correctamente");
        }

        private void txtNroOrigen_Click(object sender, EventArgs e)
        {
            txtNroOrigen.Clear();
        }
    }
}
