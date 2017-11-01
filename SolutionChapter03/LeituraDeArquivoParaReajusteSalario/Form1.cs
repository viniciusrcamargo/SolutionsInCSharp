using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeituraDeArquivoParaReajusteSalario
{
    public partial class FrmLeituraArquivoReajuste : Form
    {
        private RepositorioFuncionario repositorio = new RepositorioFuncionario();
        private BindingSource leituraSource = new BindingSource();

        public FrmLeituraArquivoReajuste()
        {
            InitializeComponent();
            leituraSource.DataSource = repositorio.ObterTodos();
            dgvLeitura.DataSource = leituraSource;
        }

        private void btnAbrirArq_Click(object sender, EventArgs e)
        {
            if(ofdListaFuncionarios.ShowDialog() == DialogResult.OK)
            {
                tbCaminhoArq.Text = ofdListaFuncionarios.FileName;
                ProcessarArquivo(tbCaminhoArq.Text);
                if(repositorio.ObterTodos().Count > 0)
                {
                    TotalizarValores(repositorio.ObterTodos());
                }
            }
        }

        private void TotalizarValores(IList<Funcionario> list)
        {
            //ler e completar
        }

        private void ProcessarArquivo(string text)
        {
            //ler e completar
        }
    }
}
