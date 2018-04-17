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
    public partial class FormDadosParaGeracaoDeArquivo : Form
    {
        public FormDadosParaGeracaoDeArquivo()
        {
            InitializeComponent();
            dgvFuncionarios.ColumnCount = 2;
            dgvFuncionarios.Columns[0].HeaderText = "Nome";
            dgvFuncionarios.Columns[0].Width = 230;
            dgvFuncionarios.Columns[1].HeaderText = "Salário";
            dgvFuncionarios.Columns[1].Width = 67;
        }

        private void btnCriarLinhas_Click(object sender, EventArgs e)
        {
            int numFuncionarios = 0;

            if (txbNumFuncionario.Text != string.Empty)
            {
                numFuncionarios = Convert.ToInt16(txbNumFuncionario.Text);
            }
            
            if(numFuncionarios < 1)
            {
                numFuncionarios = 1;
            }
            int i = 0;

            do {
                var linhaTabela = new DataGridViewRow();
                linhaTabela.Cells.Add(new DataGridViewTextBoxCell
                {
                    Value = string.Empty
                });
                linhaTabela.Cells.Add(new DataGridViewTextBoxCell { Value = 0 });
                dgvFuncionarios.Rows.Add(linhaTabela);
            }while(++i < numFuncionarios);

            txbNumFuncionario.Enabled = false;
            btnCriarArquivo.Enabled = true;
            btnReiniciar.Enabled = true;
            btnCriarLinhas.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.Rows.Clear();
            txbNumFuncionario.Text = string.Empty;
            txbNumFuncionario.Enabled = true;
            btnCriarArquivo.Enabled = false;
            btnReiniciar.Enabled = false;
            btnCriarLinhas.Enabled = true;
        }

        private void btnCriarArquivo_Click(object sender, EventArgs e)
        {
            if (!ValidaDados())
            {
                MessageBox.Show("Os dados possuem problemas verifique!");
            }else if(sfdGravarArquivo.ShowDialog() == DialogResult.OK)
            {
                GerarArquivo();
                MessageBox.Show("Arquivo gerado com sucesso!");
            }
        }

        private void GerarArquivo()
        {
            StreamWriter wr = new StreamWriter(sfdGravarArquivo.FileName, true);

            for(int j = 0; j < dgvFuncionarios.Rows.Count; j++)
            {
                wr.WriteLine(dgvFuncionarios.Rows[j].Cells[0].Value.ToString() + ";" + dgvFuncionarios.Rows[j].Cells[1].Value.ToString());
            }
            wr.Close();
        }

        private bool ValidaDados()
        {
            int i = 1;
            bool dadosValidados = true;
            double stringToDouble;

            while (i < dgvFuncionarios.Rows.Count)
            { 
                if (string.IsNullOrWhiteSpace(dgvFuncionarios.Rows[i].Cells[0].Value.ToString()))
                {
                    dadosValidados = false;
                }
                if (!Double.TryParse(dgvFuncionarios.Rows[i].Cells[1].Value.ToString(), out stringToDouble))
                {
                    dadosValidados = false;
                }
                ++i;
            }
            return dadosValidados;
        }
    }
}
