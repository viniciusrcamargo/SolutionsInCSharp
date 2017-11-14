using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DadosParaGeracaoDeArquivoTexto
{
    public partial class FrmDadosParaGeracaoArqTexto : Form
    {
        public FrmDadosParaGeracaoArqTexto()
        {
            InitializeComponent();
            dgvLeitura.ColumnCount = 2;
            dgvLeitura.Columns[0].HeaderText = "Nome";
            dgvLeitura.Columns[0].Width = 230;
            dgvLeitura.Columns[1].HeaderText = "Salário";
            dgvLeitura.Columns[1].Width = 67;
        }

        private void btnCriarLinhas_Click(object sender, EventArgs e)
        {
            int numFuncionario = Convert.ToInt16(txbNumFunc.Text);
            if(numFuncionario < 1)
            {
                numFuncionario = 1;
            }
            int i = 0;

            do
            {
                var linhaTabela = new DataGridViewRow();
                linhaTabela.Cells.Add(new DataGridViewTextBoxCell { Value = String.Empty });
                linhaTabela.Cells.Add(new DataGridViewTextBoxCell { Value = 0 });
                dgvLeitura.Rows.Add(linhaTabela);
            } while (++i < numFuncionario);

            txbNumFunc.Enabled = false;
            btnCriarArq.Enabled = true;
            btnReiniciar.Enabled = true;
            btnCriarLinhas.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvLeitura.Rows.Clear();
            txbNumFunc.Text = string.Empty;
            txbNumFunc.Enabled = true;
            btnCriarArq.Enabled = false;
            btnReiniciar.Enabled = false;
            btnCriarLinhas.Enabled = true;
        }

        private void btnCriarArq_Click(object sender, EventArgs e)
        {
            if (!validaDados())
            {
                MessageBox.Show("Os dados possuem problemas. Verifique se não deixou " +
                                "nenhum nome em branco ou se existe um valor correto para os " +
                                "salários de cada um");
            }
            else if(sfdGravarArquivos.ShowDialog() == DialogResult.OK)
            {
                gerarArquivo();
                MessageBox.Show("Arquivo gerado com sucesso!");
            }
        }

        private void gerarArquivo()
        {
            StreamWriter wr = new StreamWriter(sfdGravarArquivos.FileName, true);

            for (int j = 0; j < (dgvLeitura.Rows.Count-1); j++){
                wr.WriteLine(dgvLeitura.Rows[j].Cells[0].Value.ToString() + ";" +
                    dgvLeitura.Rows[j].Cells[1].Value.ToString());
            }
            wr.Close();
        }

        private bool validaDados()
        {
            int i = 0;
            bool dadosValidados = true;
            double stringToDouble;

            do
            {
                if (string.IsNullOrWhiteSpace(dgvLeitura.Rows[i].Cells[0].Value.ToString()))
                {
                    dadosValidados = false;
                }
                if (!Double.TryParse(dgvLeitura.Rows[i].Cells[1].Value.ToString(), out stringToDouble))
                {
                    dadosValidados = false;
                }
            } while (++i < (dgvLeitura.Rows.Count-1));
            return dadosValidados;
        }
    }
}
