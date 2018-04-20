using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;
using PersistenceProject;

namespace ControllerProject
{
    public class ProdutoController
    {
        private Repository repository = new Repository();

        public Produto Insert(Produto produto)
        {
            return this.repository.insertProduto(produto);
        }

        public void Remove(Produto produto)
        {
            this.repository.removerProduto(produto);
        }

        public IList<Produto> GetAll()
        {
            return this.repository.GetAllProduto();
        }

        public Produto Update(Produto produto)
        {
            return this.repository.UpdateProduto(produto);
        }
    }
}
