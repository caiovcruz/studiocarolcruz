using Model;
using System.Data;

namespace Control
{
    public class ControlItemVenda
    {
        ModelItemVenda myItemVenda = new ModelItemVenda();

        public string InserirItemVenda(int id_venda, int id_procedimento, double pr_itemvenda, double vl_lucro, int qtde_sessao, double vl_subtotal)
        {
            myItemVenda.IDVenda = id_venda;
            myItemVenda.IDProcedimento = id_procedimento;
            myItemVenda.PrecoItemVenda = pr_itemvenda;
            myItemVenda.ValorLucro = vl_lucro;
            myItemVenda.QuantidadeSessao = qtde_sessao;
            myItemVenda.ValorSubtotal = vl_subtotal;

            return myItemVenda.InserirItemVenda(myItemVenda);
        }

        public string EditarItemVenda(int id_venda, int id_procedimento, double pr_itemvenda, double vl_lucro, int qtde_sessao, double vl_subtotal)
        {
            myItemVenda.IDVenda = id_venda;
            myItemVenda.IDProcedimento = id_procedimento;
            myItemVenda.PrecoItemVenda = pr_itemvenda;
            myItemVenda.ValorLucro = vl_lucro;
            myItemVenda.QuantidadeSessao = qtde_sessao;
            myItemVenda.ValorSubtotal = vl_subtotal;

            return myItemVenda.EditarItemVenda(myItemVenda);
        }

        public string ExcluirItemVenda(int id_venda, int id_procedimento)
        {
            myItemVenda.IDVenda = id_venda;
            myItemVenda.IDProcedimento = id_procedimento;

            return myItemVenda.ExcluirItemVenda(myItemVenda);
        }

        public DataTable ExibirItemVenda(int id_venda)
        {
            myItemVenda.IDVenda = id_venda;

            return myItemVenda.ExibirItemVenda(myItemVenda);
        }

        public DataTable BuscarNomeItemVenda(string Textobuscar)
        {
            myItemVenda.TextoBuscar = Textobuscar;

            return myItemVenda.BuscarNomeItemVenda(myItemVenda);
        }
    }
}
