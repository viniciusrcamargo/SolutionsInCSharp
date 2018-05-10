using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerProject;

namespace ViewProject
{
    public partial class FormJanelaPrincipalcs : Form
    {
        private NotaEntradaController notaController = new NotaEntradaController();
        private FornecedorController fornecedorController = new FornecedorController();
        private ProdutoController produtoController = new ProdutoController();
        public FormJanelaPrincipalcs()
        {
            InitializeComponent();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFornecedor(fornecedorController).ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProduto(produtoController).ShowDialog();
        }

        private void notaEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRegistroNotaEntrada(notaController, fornecedorController, produtoController).ShowDialog();
        }
    }
}
