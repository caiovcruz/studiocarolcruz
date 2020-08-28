using Model;
using System.Data;

namespace Control
{
    public class ControlProduto
    {
        ModelProduto myProduto = new ModelProduto();

        public string InserirProduto(string nome, string armazenamento)
        {
            myProduto.Nome = nome;
            myProduto.TipoArmazenamento = armazenamento;

            return myProduto.InserirProduto(myProduto);
        }

        public string EditarProduto(int id, string nome, string armazenamento)
        {
            myProduto.IDProduto = id;
            myProduto.Nome = nome;
            myProduto.TipoArmazenamento = armazenamento;

            return myProduto.EditarProduto(myProduto);
        }

        public string ExcluirProduto(int id)
        {
            myProduto.IDProduto = id;

            return myProduto.ExcluirProduto(myProduto);
        }

        public DataTable ExibirProduto()
        {
            return myProduto.ExibirProduto();
        }

        public DataTable ExibirProdutoEstoque()
        {
            return myProduto.ExibirProdutoEstoque();
        }

        public DataTable BuscarNomeProduto(string Textobuscar)
        {
            myProduto.TextoBuscar = Textobuscar;

            return myProduto.BuscarNomeProdutoEstoque(myProduto);
        }
    }
}
