using Model;
using System.Data;

namespace Control
{
    public class ControlSessao
    {
        ModelSessao mySessao = new ModelSessao();

        public string InserirSessao(int id_venda, int id_procedimento, int qtde_sessao)
        {
            mySessao.IDVenda = id_venda;
            mySessao.IDProcedimento = id_procedimento;
            mySessao.QuantidadeSessao = qtde_sessao;

            return mySessao.InserirSessao(mySessao);
        }

        public string EditarSessao(int id_venda, int id_procedimento, int nr_sessaoatual, int qtde_sessao, string obs_sessao)
        {
            mySessao.IDVenda = id_venda;
            mySessao.IDProcedimento = id_procedimento;
            mySessao.SessaoAtual = nr_sessaoatual;
            mySessao.QuantidadeSessao = qtde_sessao;
            mySessao.ObservacaoSessao = obs_sessao;

            return mySessao.EditarSessao(mySessao);
        }

        public string ExcluirSessao(int id_venda, int id_procedimento)
        {
            mySessao.IDVenda = id_venda;
            mySessao.IDProcedimento = id_procedimento;

            return mySessao.ExcluirSessao(mySessao);
        }

        public DataTable ExibirSessao()
        {
            return mySessao.ExibirSessao();
        }

        public DataTable ExibirSessaoDisponivel()
        {
            return mySessao.ExibirSessaoDisponivel();
        }

        public DataTable BuscarClienteSessao(string Texbobuscar)
        {
            mySessao.TextoBuscar = Texbobuscar;

            return mySessao.BuscarClienteSessao(mySessao);
        }

        public DataTable BuscarClienteSessaoDisponivel(string Texbobuscar)
        {
            mySessao.TextoBuscar = Texbobuscar;

            return mySessao.BuscarClienteSessaoDisponivel(mySessao);
        }

        public DataTable BuscarProcedimentoSessao(string Texbobuscar)
        {
            mySessao.TextoBuscar = Texbobuscar;

            return mySessao.BuscarProcedimentoSessao(mySessao);
        }

        public DataTable BuscarProcedimentoSessaoDisponivel(string Texbobuscar)
        {
            mySessao.TextoBuscar = Texbobuscar;

            return mySessao.BuscarProcedimentoSessaoDisponivel(mySessao);
        }
    }
}
