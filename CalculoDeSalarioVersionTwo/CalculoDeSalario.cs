using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeSalario
{
    public partial class FrmCalculoDeSalario : Form
    {
        public FrmCalculoDeSalario()
        {
            InitializeComponent();
        }

              
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salBruto = getSalarioBruto(getCoeficiente(), Convert.ToDouble(txbHorasTrab.Text));
            double imposto = getImposto(categoria(), salBruto), gratificacao, auxAlim;
            double salLiquido;

           
            if(rbTurno().Equals(rbNoturno) && Convert.ToDouble(txbHorasTrab.Text) > 80)
            {
                gratificacao = 50;
            }
            else
            {
                gratificacao = 30;
            }

            if(categoria().Equals(rbCalouro) && salBruto < (Convert.ToDouble(txbSalMinimo.Text)))
            {
                auxAlim = salBruto / 3;
            }
            else
            {
                auxAlim = (salBruto / 3) / 2;
            }

            salLiquido = ((salBruto - imposto) + gratificacao) + auxAlim;

            if(salLiquido < 350)
            {
                lblSituacao.Text = "Mal remunerado!!";
            }else if(salLiquido < 600)
            {
                lblSituacao.Text = "Normalmente remunerado!!";
            }
            else
            {
                lblSituacao.Text = "Bem remunerado!!";
            }

            lbResultado.Items.Add("Coeficiente R$ " + getCoeficiente().ToString());
            lbResultado.Items.Add("Salário Bruto R$ " + salBruto.ToString());
            lbResultado.Items.Add("Valor do Importo R$ " + imposto.ToString());
            lbResultado.Items.Add("Valor da gratificação R$ " + gratificacao.ToString());
            lbResultado.Items.Add("Valor do auxílio alimentação R$ " + auxAlim.ToString());
            lbResultado.Items.Add("Salário líquido R$ " + salLiquido.ToString());

        }

        private RadioButton rbTurno()
        {
            if (rbMatutino.Checked)
            {
                return rbMatutino;
            }
            else if (rbVespertino.Checked)
            {
                return rbVespertino;
            }
            return rbNoturno;
        }

        private int categoria()
        {
            if (rbCalouro.Checked)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private double getCoeficiente()
        {
            double coeficiente = 0;
            if (rbTurno().Equals(rbMatutino))
            {
                coeficiente = (Convert.ToDouble(txbSalMinimo.Text) / 100) * 1;
            }
            else if (rbTurno().Equals(rbVespertino))
            {
                coeficiente = (Convert.ToDouble(txbSalMinimo.Text) / 100) * 2;
            }
            else if (rbTurno().Equals(rbNoturno))
            {
                coeficiente = (Convert.ToDouble(txbSalMinimo.Text) / 100) * 3;
            }
            return coeficiente;
        }

        private double getSalarioBruto(double getCoeficiente, double horasTrab)
        {
            double salarioBruto = 0;
            salarioBruto = getCoeficiente * horasTrab;

            return salarioBruto;
        }


        private double getImposto(int categoria, double getSalarioBruto)
        {
            double imposto = 0;

            if (getSalarioBruto < 300 && categoria == 0)
            {
                imposto = (getSalarioBruto / 100) * 1;
            }
            else if (getSalarioBruto >= 300 && categoria == 0)
            {
                imposto = (getSalarioBruto / 100) * 2;
            }

            if (getSalarioBruto < 400 && categoria == 1)
            {
                imposto = (getSalarioBruto / 100) * 3;
            }
            if (getSalarioBruto >= 400 && categoria == 1)
            {
                imposto = (getSalarioBruto / 100) * 4;
            }
            return imposto;
        }

    }
}
