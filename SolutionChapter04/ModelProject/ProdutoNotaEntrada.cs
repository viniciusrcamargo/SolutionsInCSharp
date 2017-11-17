using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class ProdutoNotaEntrada
    {
        public Guid id { get; set; }
        public Produto ProdutoNota { get; set; }
        public double PrecoCusto { get; set; }
        public double QuantComprada { get; set; }

        protected bool Equals(ProdutoNotaEntrada other)
        {
            return id.Equals(other.id);
        }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(null, obj))
            {
                return false;
            }
            if(ReferenceEquals(this, obj))
            {
                return true;
            }
            if(obj.GetType() != typeof(ProdutoNotaEntrada))
            {
                return false;
            }
            return base.Equals((ProdutoNotaEntrada) obj);
        }

        public override int GetHashCode()
        {
            return ProdutoNota.GetHashCode();
        }
    }
}
