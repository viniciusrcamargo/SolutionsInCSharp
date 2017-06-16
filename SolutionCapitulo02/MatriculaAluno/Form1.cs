using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaAluno
{
    public partial class FrmMatriculaAluno : Form
    {
        public FrmMatriculaAluno()
        {
            InitializeComponent();
        }

        private void txbAnoNiver_Validating(object sender, CancelEventArgs e)
        {
            if(Convert.ToInt32(txbAnoNiver.Text) < Convert.ToInt32(txbAnoNasc.Text))
            {
                MessageBox.Show("Ano do aniversário não pode ser menor que o ano de nascimento", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void btnIdentificarCat_Click(object sender, EventArgs e)
        {
            if(txbNome.Text == String.Empty || txbAnoNasc.Text == String.Empty || txbAnoNiver.Text == String.Empty)
            {
                MessageBox.Show("Não é possível identificar a categoria se algum dos dados não for preenchido", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int categoria = Convert.ToInt32(txbAnoNiver.Text) - Convert.ToInt32(txbAnoNasc.Text);

                if(categoria >= 5 && categoria <= 7)
                {
                    txbRecCategoria.Text = "Infantil A";
                }else if(categoria >= 8 && categoria <= 10)
                {
                    txbRecCategoria.Text = "Infantil B";
                }else if(categoria >= 11 && categoria <= 14)
                {
                    txbRecCategoria.Text = "Juvenil A";
                }else if(categoria >= 15 && categoria <= 17)
                {
                    txbRecCategoria.Text = "Juvenil B";
                }else if(categoria > 17)
                {
                    txbRecCategoria.Text = "Adulto";
                }
            }
        }

    }
}
