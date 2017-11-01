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
            dgvLeitura.DataSource = leituraSource;
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

        private void btnProcessarDados_Click(object sender, EventArgs e)
        {
            ProcessarLeituras(dgvLeitura);
        }

        private void ProcessarLeituras(DataGridView dgv)
        {
            DataGridViewCell cell = dgv.Rows[0].Cells[0];
            this.leituras.Add(new Leitura("Total", 0));

            for(int i = 0; i < 3; i++)
            {
                dgv.Rows[dgv.Rows.Count - 1].Cells[i].Style.BackColor = Color.Blue;
                dgv.Rows[dgv.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Yellow;
                dgv.Rows[dgv.Rows.Count - 1].Cells[i].Style.Font = new Font(cell.InheritedStyle.Font,FontStyle.Bold);
            }

            double totalConsumo = 0, totalDesconto = 0;
            foreach(var leitura in leituras)
            {
                totalConsumo += leitura.consumo;
                totalDesconto += leitura.desconto;
            }
            dgv[0, dgv.Rows.Count - 1].Value = "total";
            dgv[1, dgv.Rows.Count - 1].Value = totalConsumo.ToString("N");
            dgv[2, dgv.Rows.Count - 1].Value = totalDesconto.ToString("N");
            lblTotalSemDesc.Text = (totalConsumo - totalDesconto).ToString("N");

        }
    }
}
