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

        private void TotalizarValores(IList<Funcionario> dadosLidos)
        {
            double totalSemReajuste = 0, totalComReajuste = 0;
            foreach(var funcionario in dadosLidos)
            {
                totalSemReajuste += funcionario.salario;
                totalComReajuste += funcionario.NovoSalario;
            }
            double percentualRejuste = (totalComReajuste - totalSemReajuste) * 100 / totalSemReajuste;
            lblTotalSemReajuste.Text = string.Format("{0:c}", totalSemReajuste);
            lblTotalComReajuste.Text = string.Format("{0:c}", totalComReajuste);
            lblPercentualReajuste.Text = string.Format("{0:n}%", percentualRejuste);
        }

        private void ProcessarArquivo(string text)
        {
            repositorio.ObterTodos().Clear();
            string linhaLida;
            var arquivo = new System.IO.StreamReader(@text);

            while((linhaLida = arquivo.ReadLine()) != null)
            {
                var dadosLidos = linhaLida.Split(';');
                var funcionario = new Funcionario
                {
                    Codigo = Convert.ToInt32(dadosLidos[0]),
                    salario = Convert.ToDouble(dadosLidos[1])
                };
                repositorio.Inserir(funcionario);
            }
            arquivo.Close();
        }

        
    }
}
