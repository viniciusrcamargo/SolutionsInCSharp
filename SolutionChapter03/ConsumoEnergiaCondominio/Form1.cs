using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoEnergiaCondominio
{
    public partial class FrmConsEnergiaCond : Form
    {
        private IList<Leitura> leituras = new BindingList<Leitura>();
        private BindingSource leituraSource = new BindingSource();
        public FrmConsEnergiaCond()
        {
            InitializeComponent();
            leituraSource.DataSource = leituras;
            dataGridView1.DataSource = leituraSource;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarConsumo(txbNumCasa.Text, Convert.ToDouble(txbConsumo.Text));
        }

        private void RegistrarConsumo(String casa, double consumo)
        {
            Leitura leitura = new Leitura(casa, consumo);
            if (leituras.Contains(leitura))
            {
                MessageBox.Show("A leitura para esta casa ja foi registrada", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.leituras.Add(leitura);
                InicializaFormulario();
            }
        }

        private void InicializaFormulario()
        {
            txbNumCasa.Clear();
            txbNumCasa.Clear();
            txbNumCasa.Focus();
        }
    }
}
