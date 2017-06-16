using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotacaoPessoas
{
    public partial class FrmLotacaoPessoas : Form
    {
        int i = 0;
        public FrmLotacaoPessoas()
        {
            InitializeComponent();
        }

        

        private void FrmLotacaoPessoas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && i < 10000)
            {
                lblLotacao.Text = i.ToString();
                i++;
            }
        }

        private void FrmLotacaoPessoas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && i >=0)
            {
                lblLotacao.Text = i.ToString();
                i--;
            }


        }
    }
}
