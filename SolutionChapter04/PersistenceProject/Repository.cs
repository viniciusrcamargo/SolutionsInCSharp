using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;

namespace PersistenceProject
{
    class Repository
    {
        private IList<Fornecedor> fornecedores = new List<Fornecedor>();
        private IList<Produto> produto = new List<Produto>();
        private IList<NotaEntrada> notaEntrada = new List<NotaEntrada>();

        public Fornecedor insertFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Add(fornecedor);
            return fornecedor;
        }

        public void removerFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Remove(fornecedor);
        }

        public IList<Fornecedor> GetFornecedor()
        {
            return this.fornecedores;
        }

        public Fornecedor UpdateFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores[this.fornecedores.IndexOf(fornecedor)] = fornecedor;
            return fornecedor;
        }

        public Produto insertProduto(Produto produto)
        {
            this.produto.Add(produto);
            return produto;
        }

        public void removerProduto(Produto produto)
        {
            this.produto.Remove(produto);
        }

        public IList<Produto> GetProduto()
        {
            return this.produto;
        }

        public Produto UpdateProduto(Produto produto)
        {
            this.produto[this.produto.IndexOf(produto)] = produto;
            return produto;
        }

        public NotaEntrada insertNotaEntrada(NotaEntrada notaEntrada)
        {
            this.notaEntrada.Add(notaEntrada);
            return notaEntrada;
        }

        public void removerNotaEntrada(NotaEntrada notaEntrada)
        {
            this.fornecedores.Remove(notaEntrada);
        }

        public IList<NotaEntrada> GetNotaEntrada()
        {
            return this.notaEntrada;
        }

        public NotaEntrada UpdateNotaEntrada(NotaEntrada notaEntrada)
        {
            this.notaEntrada[this.notaEntrada.IndexOf(notaEntrada)] = notaEntrada;
            return notaEntrada;
        }
    }
}
