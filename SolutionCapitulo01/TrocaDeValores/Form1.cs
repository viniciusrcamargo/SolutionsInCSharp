using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDeValores
{
    public partial class frmTrocaDeValores : Form
    {
        public frmTrocaDeValores()
        {
            InitializeComponent();
        }

        private void btnTrocarValor_Click(object sender, EventArgs e)
        {
            string valor3;
            if(txbValor1.Text == txbValor2.Text)
            {
                MessageBox.Show ("Valores inseridos iguais");
                Application.Exit();
            }
            valor3 = txbValor2.Text;
            txbValor2.Text = txbValor1.Text;
            txbValor1.Text = valor3;
        }
    }
}
