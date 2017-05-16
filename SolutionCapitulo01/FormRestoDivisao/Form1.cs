using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRestoDivisao
{
    public partial class FrmRestoDeDivisao : Form
    {
        public FrmRestoDeDivisao()
        {
            InitializeComponent();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            int num1, num2;
            double resto = 0;
            num1 = Convert.ToInt32(txbDividendo.Text);
            num2 = Convert.ToInt32(txbDivisor.Text);
            resto = num1 % num2;
            txbResto.Text = resto.ToString();
        }
    }
}
