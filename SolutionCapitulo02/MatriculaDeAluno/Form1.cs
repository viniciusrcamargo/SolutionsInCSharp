using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaDeAluno
{
    public partial class FrmMatriculaDeAluno : Form
    {
        public FrmMatriculaDeAluno()
        {
            InitializeComponent();
        }

        private void FrmMatriculaDeAluno_Load(object sender, EventArgs e)
        {

        }

      

       
        private void button1_Click(object sender, EventArgs e)
        {
            if(txbAnoNascimento.Text == String.Empty || txbAnoAniversario.Text == String.Empty || txtNome.Text == String.Empty)
            {
                MessageBox.Show("Todos os dados devem ser informados", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                int idade = Convert.ToInt32(txbAnoAniversario.Text) - Convert.ToInt32(txbAnoNascimento.Text);

                if(idade >= 5 && idade <=7)
                {
                    lblCategoriaResp.Text = "Infantil A";
                }else if(idade >= 8 && idade <= 10)
                {
                    lblCategoriaResp.Text = "Infantil B";
                }else if(idade >= 11 && idade <= 13)
                {
                    lblCategoriaResp.Text = "Juvenil A";
                }else if(idade >= 14 && idade <= 17)
                {
                    lblCategoriaResp.Text = "Juvenil B";
                }else if(idade > 17)
                {
                    lblCategoriaResp.Text = "Adulto";
                }
            }
        }

        private void txbAnoAniversario_Validating(object sender, CancelEventArgs e)
        {
            if ((Convert.ToInt32(txbAnoAniversario.Text) <= Convert.ToInt32(txbAnoNascimento)))
            {
                MessageBox.Show("O ano do aniversário não pode ser menor que o ano de nascimento", " Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
           
        }
    }
}
