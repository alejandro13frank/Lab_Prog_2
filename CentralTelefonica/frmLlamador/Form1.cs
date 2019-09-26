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
            this.c = c;
    }
  }
}
