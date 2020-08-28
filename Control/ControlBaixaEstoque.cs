using Model;
using System;
using System.Data;

namespace Control
{
    public class ControlBaixaEstoque
    {
        ModelBaixaEstoque myBaixaEstoque = new ModelBaixaEstoque();

        public string BaixaEstoque(int id_produto, double qtde_baixaestoque)
        {
            myBaixaEstoque.IDProduto = id_produto;
            myBaixaEstoque.QuantidadeBaixaEstoque = qtde_baixaestoque;

            return myBaixaEstoque.BaixaEstoque(myBaixaEstoque);
        }

        public string RegistrarBaixaEstoque(int id_produto, double qtde_baixaestoque, DateTime dt_validade)
        {
            myBaixaEstoque.IDProduto = id_produto;
            myBaixaEstoque.QuantidadeBaixaEstoque = qtde_baixaestoque;
            myBaixaEstoque.DataValidadeBaixaEstoque = dt_validade;

            return myBaixaEstoque.RegistrarBaixaEstoque(myBaixaEstoque);
        }

        public string ExcluirBaixaEstoque(int id_baixaestoque)
        {
            myBaixaEstoque.IDBaixaEstoque = id_baixaestoque;

            return myBaixaEstoque.ExcluirBaixaEstoque(myBaixaEstoque);
        }

        public DataTable ExibirBaixaEstoque()
        {
            return myBaixaEstoque.ExibirBaixaEstoque();
        }

        public DataTable BuscarBaixaEstoque(DateTime dtInicioBuscar, DateTime dtFinalBuscar, string Textobuscar)
        {
            myBaixaEstoque.DataInicioBuscar = dtInicioBuscar;
            myBaixaEstoque.DataFinalBuscar = dtFinalBuscar;
            myBaixaEstoque.TextoBuscar = Textobuscar;

            return myBaixaEstoque.BuscarBaixaEstoque(myBaixaEstoque);
        }

        public DataTable BuscarDataBaixaEstoque(DateTime dtInicioBuscar, DateTime dtFinalBuscar)
        {
            myBaixaEstoque.DataInicioBuscar = dtInicioBuscar;
            myBaixaEstoque.DataFinalBuscar = dtFinalBuscar;

            return myBaixaEstoque.BuscarDataBaixaEstoque(myBaixaEstoque);
        }

        public DataTable BuscarProdutoBaixaEstoque(string Textobuscar)
        {
            myBaixaEstoque.TextoBuscar = Textobuscar;

            return myBaixaEstoque.BuscarProdutoBaixaEstoque(myBaixaEstoque);
        }
    }
}
