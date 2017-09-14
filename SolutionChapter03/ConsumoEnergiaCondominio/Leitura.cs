using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoEnergiaCondominio
{
    class Leitura
    {
        public String casa { get; set; }
        public double consumo { get; set; }
        public double desconto { get
            { return consumo * 0.20;
               }
        }

        public Leitura(String casa, double consumo)
        {
            this.casa = casa;
            this.consumo = consumo;
        }

        public override bool Equals(object obj)
        {
            Leitura leitura = obj as Leitura;
            if(leitura == null)
            {
                return false;
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return new { casa, consumo}.GetHashCode();
        }


    }
}
