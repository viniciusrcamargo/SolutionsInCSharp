using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;
using PersistenceProject;

namespace ControllerProject
{
    public class FornecedorController
    {
        private Repository repository = new Repository();

        public Fornecedor Insert(Fornecedor fornecedor)
        {
            return this.repository.insertFornecedor(fornecedor);
        }

        public void Remove(Fornecedor fornecedor)
        {
            this.repository.removerFornecedor(fornecedor);
        }

        public IList<Fornecedor> GetAll()
        {
            return this.repository.GetAllFornecedor();
        }

        public Fornecedor Update(Fornecedor fornecedor)
        {
            return this.repository.UpdateFornecedor(fornecedor);
        }
    }
}
