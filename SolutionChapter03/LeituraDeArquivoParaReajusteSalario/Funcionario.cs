using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraDeArquivoParaReajusteSalario
{
    class Funcionario
    {
        public int Codigo { get; set; }
        public double salario { get; set; }
        public double Percentual { get
            {
                if(this.salario < 1000)
                {
                    return 15;
                }else if(this.salario < 1500)
                {
                    return 10;
                }
                else
                {
                    return 5;
                }
            }
        }

        public double NovoSalario
        {
            get
            {
                return ((this.salario * this.Percentual) / 100) + this.salario;
            }

        }
    }
}
