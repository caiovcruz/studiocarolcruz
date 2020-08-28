using Model;
using System;
using System.Data;

namespace Control
{
    public class ControlLote
    {
        ModelLote myLote = new ModelLote();

        public string InserirLote(int id_produto, double qtde_lote, DateTime dt_validade)
        {
            myLote.IDProduto = id_produto;
            myLote.QuantidadeLote = qtde_lote;
            myLote.DataValidade = dt_validade;

            return myLote.InserirLote(myLote);
        }

        public string EditarLote(int id_produto, double qtde_lote, DateTime dt_validade)
        {
            myLote.IDProduto = id_produto;
            myLote.QuantidadeLote = qtde_lote;
            myLote.DataValidade = dt_validade;

            return myLote.EditarLote(myLote);
        }

        public DataTable ExibirLote()
        {
            return myLote.ExibirLote();
        }

        public DataTable BuscarLote(int id_produto)
        {
            myLote.IDProduto = id_produto;

            return myLote.BuscarLote(myLote);
        }

        public DataTable BuscarLoteData(int id_produto, DateTime dt_validade)
        {
            myLote.IDProduto = id_produto;
            myLote.DataValidade = dt_validade;

            return myLote.BuscarLoteData(myLote);
        }

        public string BaixaLote(int id_produto, double qtde_lote, DateTime dt_validade)
        {
            myLote.IDProduto = id_produto;
            myLote.QuantidadeLote = qtde_lote;
            myLote.DataValidade = dt_validade;

            return myLote.BaixaLote(myLote);
        }

        public string ValidarLote()
        {
            return myLote.ValidarLote();
        }

        public string ObterQuantidadeDoLote(int id_produto, DateTime dt_validade)
        {
            myLote.IDProduto = id_produto;
            myLote.DataValidade = dt_validade;

            return myLote.ObterQuantidadeDoLote(myLote);
        }
    }
}
