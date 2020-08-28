using Model;
using System;
using System.Data;

namespace Control
{
    public class ControlItemCompra
    {
        ModelItemCompra myItemCompra = new ModelItemCompra();

        public string InserirItemCompra(int id_compra, int id_produto, DateTime dt_validade, double qtde_itemcompra, double vl_itemcompra)
        {
            myItemCompra.IDCompra = id_compra;
            myItemCompra.IDProduto = id_produto;
            myItemCompra.DataValidade = dt_validade;
            myItemCompra.QuantidadeItemCompra = qtde_itemcompra;
            myItemCompra.ValorItemCompra = vl_itemcompra;

            return myItemCompra.InserirItemCompra(myItemCompra);
        }

        public string EditarItemCompra(int id_compra, int id_produto, DateTime dt_validade, DateTime dt_validadeeditar, double qtde_itemcompra, double vl_itemcompra)
        {
            myItemCompra.IDCompra = id_compra;
            myItemCompra.IDProduto = id_produto;
            myItemCompra.DataValidade = dt_validade;
            myItemCompra.DataValidadeEditar = dt_validadeeditar;
            myItemCompra.QuantidadeItemCompra = qtde_itemcompra;
            myItemCompra.ValorItemCompra = vl_itemcompra;

            return myItemCompra.EditarItemCompra(myItemCompra);
        }

        public string ExcluirItemCompra(int id_compra, int id_produto, DateTime dt_validade)
        {
            myItemCompra.IDCompra = id_compra;
            myItemCompra.IDProduto = id_produto;
            myItemCompra.DataValidade = dt_validade;

            return myItemCompra.ExcluirItemCompra(myItemCompra);
        }

        public DataTable ExibirItemCompra(int id_compra)
        {
            myItemCompra.IDCompra = id_compra;

            return myItemCompra.ExibirItemCompra(myItemCompra);
        }

        public DataTable BuscarNomeItemCompra(string Textobuscar)
        {
            myItemCompra.TextoBuscar = Textobuscar;

            return myItemCompra.BuscarNomeItemCompra(myItemCompra);
        }
    }
}