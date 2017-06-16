using System;
using System.Windows.Forms;

namespace MatriculaAlunoVersionTwo
{
    public partial class FrmMatriculaAluno : Form
    {
        public FrmMatriculaAluno()
        {
            InitializeComponent();
            lblDataAtual.Text = "Hoje é " + DateTime.Now.ToShortDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIdentificarCat_Click(object sender, EventArgs e)
        {
            if (txbNome.Text == String.Empty || dtpDataNasc.Value == null)
            {
                MessageBox.Show("Não é possível identificar a categoria se algum dos dados não for preenchido", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TimeSpan tsQuantidadeDias = DateTime.Now.Date - dtpDataNasc.Value;
                int idade = (tsQuantidadeDias.Days / 365);
                if (idade>= 5 && idade <= 7)
                {
                    lblRecCat.Text = "Infantil A";
                }
                else if (idade >= 8 && idade <= 10)
                {
                    lblRecCat.Text = "Infantil B";
                }
                else if (idade >= 11 && idade <= 14)
                {
                    lblRecCat.Text = "Juvenil A";
                }
                else if (idade >= 15 && idade <= 17)
                {
                    lblRecCat.Text = "Juvenil B";
                }
                else if (idade > 17)
                {
                    lblRecCat.Text = "Adulto";
                }
            }
        }
    }
}
