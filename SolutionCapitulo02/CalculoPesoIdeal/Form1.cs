﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoPesoIdeal
{
    public partial class FrmCalculoPesoIdeal : Form
    {
        //RadioButton rbnSelecionado = null;

        public FrmCalculoPesoIdeal()
        {
            InitializeComponent();
        }

        /*private void rbtnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;

            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();
            }
        }*/

        private void SetPesoIdeal()
        {
            try
            {
                double altura = Convert.ToDouble(txbAltura.Text);
                double pesoIdeal;
                if (rbtnMasculino.Text.Equals("Masculino"))//rbnSelecionado.Text.Equals("Masculino")
                {
                    pesoIdeal = (72.7 * altura) - 58;
                }
                else
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                }
                lblPesoIdeal.Text = pesoIdeal.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Selecione o sexo e informe a altura corretamente", "Atenção!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbAltura_TextChanged(object sender, EventArgs e)
        {
            SetPesoIdeal();
        }
    }
}
