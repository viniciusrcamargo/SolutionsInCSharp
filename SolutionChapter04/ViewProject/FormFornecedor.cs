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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.controller.Insert(new Fornecedor(){
                id = Guid.NewGuid(),
                nome = txbNome.Text,
                cnpj = txbCnpj.Text
            });
        }
        
    }
}
