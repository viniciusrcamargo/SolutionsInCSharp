using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastoEmRestaurante
{
    public partial class FrmGastoEmRestaurante : Form
    {
        public FrmGastoEmRestaurante()
        {
            InitializeComponent();
        }

        private void brnCalcular_Click(object sender, EventArgs e)
        {
            double percentual = 0, despesa;
            despesa = Convert.ToDouble(txbDespesa.Text);
            percentual = despesa * 10 / 100;
            txbTotal.Text = (despesa + percentual).ToString();
        }
    }
}
