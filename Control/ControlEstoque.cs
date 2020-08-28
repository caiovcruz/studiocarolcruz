using Model;
using System;
using System.Data;

namespace Control
{
    public class ControlEstoque
    {
        ModelEstoque myEstoque = new ModelEstoque();

        public string InserirEstoque(int id_produto, double qtde_estoque)
        {
            myEstoque.IDProduto = id_produto;
            myEstoque.QuantidadeEstoque = qtde_estoque;

            return myEstoque.InserirEstoque(myEstoque);
        }

        public string EditarEstoque(int id_produto, double qtde_estoque)
        {
            myEstoque.IDProduto = id_produto;
            myEstoque.QuantidadeEstoque = qtde_estoque;

            return myEstoque.EditarEstoque(myEstoque);
        }

        public string ExcluirEstoque(int id_produto)
        {
            myEstoque.IDProduto = id_produto;

            return myEstoque.ExcluirEstoque(myEstoque);
        }

        public DataTable ExibirEstoque()
        {
            return myEstoque.ExibirEstoque();
        }

        public DataTable BuscarNomeProdutoEstoque(string Textobuscar)
        {
            myEstoque.TextoBuscar = Textobuscar;

            return myEstoque.BuscarNomeProdutoEstoque(myEstoque);
        }
    }
}
