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
    public partial class FormFornecedor : Form
    {
        private FornecedorController controller = new FornecedorController();
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor(){
                id = (txbId.Text == string.Empty ? Guid.NewGuid() : new Guid(txbId.Text)),
                nome = txbNome.Text,
                cnpj = txbCnpj.Text
            };
            fornecedor = (txbId.Text == string.Empty ? this.controller.Insert(fornecedor) : this.controller.Update(fornecedor));
            //txbId.Text = fornecedor.id.ToString();
            dgvResultado.DataSource = null;
            dgvResultado.DataSource = this.controller.GetAll();
            ClearControls();
        }

        private void ClearControls()
        {
            dgvResultado.ClearSelection();
            txbId.Text = string.Empty;
            txbNome.Text = string.Empty;
            txbCnpj.Text = string.Empty;
            txbNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgvResultado_SelectionChanged(object sender, EventArgs e)
        {
            txbId.Text = dgvResultado.CurrentRow.Cells[0].Value.ToString();
            txbNome.Text = dgvResultado.CurrentRow.Cells[1].Value.ToString();
            txbCnpj.Text = dgvResultado.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(txbId.Text == string.Empty)
            {
                MessageBox.Show("Seleciona um fornecedor para excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.controller.Remove(new Fornecedor()
                {
                    id = new Guid(txbId.Text)
                });
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
