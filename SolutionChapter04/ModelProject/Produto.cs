using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Produto
    {
        public Guid id { get; set; }
        public string descricao { get; set; }
        public double precoCusto { get; set; }
        public double prevoVenda { get; set; }
        public double Estoque { get; set; }
    }
}
