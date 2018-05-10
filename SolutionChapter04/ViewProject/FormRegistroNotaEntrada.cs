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
using ModelProject;

namespace ViewProject
{
    public partial class FormRegistroNotaEntrada : Form
    {
        private NotaEntradaController notaController;
        private FornecedorController fornecedorController;
        private ProdutoController produtoController;

        private FormNotaEntrada notaAtual;
                
        public FormRegistroNotaEntrada(NotaEntradaController notaController, FornecedorController fornecedorController,
                                      ProdutoController produtoController)
        {
            InitializeComponent();
            this.notaController = notaController;
            this.fornecedorController = fornecedorController;
            this.produtoController = produtoController;
            InicializaCombobox();
        }

        private void InicializaCombobox()
        {
            cbFornecedor.Items.Clear();
            cbProduto.Items.Clear();

            foreach(Fornecedor fornecedor in this.fornecedorController.GetAll())
            {
                cbFornecedor.Items.Add(fornecedor).ToString();
            }
            foreach (Produto produto in this.produtoController.GetAll())
            {
                cbProduto.Items.Add(produto);
            }
        }
    }
}
