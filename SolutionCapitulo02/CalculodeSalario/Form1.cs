using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculodeSalario
{
    public partial class FrmCalculodeSalario : Form
    {
        double salarioMinimo = 0, auxAlimentacao;
        double horasTrabalhadas = 0, gratificacao;
        double coeficiente = 0, imposto = 0, salarioLiquido;

        public FrmCalculodeSalario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            salarioMinimo = Double.Parse(tbSalMinimo.Text);
            horasTrabalhadas = Double.Parse(tbHorasTrab.Text);
            
            
            //calcular o coeficiente
            if (rbMatutino.Checked)
            {
                coeficiente = (salarioMinimo / 100) * 1;
            }else if (rbVespertino.Checked)
            {
                coeficiente = (salarioMinimo / 100) * 2;
            }else if (rbNoturno.Checked)
            {
                coeficiente = (salarioMinimo / 100) * 3;
            }

            //calcular o imposto
            if(rbCalouro.Checked && salarioMinimo < 300)
            {
                imposto = (salarioMinimo / 100) * 1;
            }else if(rbCalouro.Checked && salarioMinimo >= 300)
            {
                imposto = (salarioMinimo / 100) * 2;
            }else if(rbVeterano.Checked && salarioMinimo < 400)
            {
                imposto = (salarioMinimo / 100) * 3;
            }else if(rbVeterano.Checked && salarioMinimo >= 400)
            {
                imposto = (salarioMinimo / 100) * 4;
            }

            //calcular gratificação
            if(rbNoturno.Checked && horasTrabalhadas > 80)
            {
                gratificacao = 50;
            }
            else
            {
                gratificacao = 30;
            }

            //calcular auxilio alimentação
            if(rbCalouro.Checked && salarioMinimo < (salarioMinimo / 2))
            {
                auxAlimentacao = salarioMinimo / 3;
                
            }
            else
            {
                auxAlimentacao = (salarioMinimo / 3) / 2;
            }

            
            salarioLiquido = ((salarioMinimo - imposto) + gratificacao) + auxAlimentacao;

            //classificação
            if (salarioLiquido < 350)
            {
                lblSituacao.Text = "Mal Remunerado";
            }
            else if (salarioLiquido > 350 && salarioLiquido <= 600)
            {
                lblSituacao.Text = "Normalmente Remunerado";
            }
            else if (salarioLiquido > 600)
            {
                lblSituacao.Text = "Bem Remunerado";
            }

            exibirDadosNaTela(salarioMinimo, horasTrabalhadas, imposto, auxAlimentacao, gratificacao, coeficiente, salarioLiquido);
        }

       private void exibirDadosNaTela(double salarioMinimo, double horasTrabalhadas, double imposto, double auxAlimentacao, double gratificacao, double coeficiente, double salarioLiquido)
        {
            lbResultado.Items.Add(String.Format("{0,-29}{1,12:C}","Valor do coeficiente: " , coeficiente));
            lbResultado.Items.Add(String.Format("{0,-29}{1,12:C}","Salário Bruto: " , salarioMinimo));
            lbResultado.Items.Add(String.Format("{0,-29}{1,12:C}","Valor do imposto: " , imposto)); 
            lbResultado.Items.Add(String.Format("{0,-29}{1,12:C}","Valor da gratificação: " , gratificacao));
            lbResultado.Items.Add(String.Format("{0,-29}{1,12:C}","Valor do Auxilio Alimentação: " , auxAlimentacao));
            lbResultado.Items.Add(String.Format("{0,-29}{1,12:C}","Salário Líquido: " , salarioLiquido));
        }
    }
}
