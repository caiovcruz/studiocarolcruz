using Model;
using System.Data;

namespace Control
{
    public class ControlProcedimento
    {
        ModelProcedimento myProcedimento = new ModelProcedimento();

        public string InserirProcedimento(int categoria, string nome, string descricao)
        {
            myProcedimento.IDCategoria = categoria;
            myProcedimento.Nome = nome;
            myProcedimento.Descricao = descricao;

            return myProcedimento.InserirProcedimento(myProcedimento);
        }

        public string EditarProcedimento(int id, int id_categoria, string nome, string descricao)
        {
            myProcedimento.IDProcedimento = id;
            myProcedimento.IDCategoria = id_categoria;
            myProcedimento.Nome = nome;
            myProcedimento.Descricao = descricao;

            return myProcedimento.EditarProcedimento(myProcedimento);
        }

        public string ExcluirProcedimento(int id)
        {
            myProcedimento.IDProcedimento = id;

            return myProcedimento.ExcluirProcedimento(myProcedimento);
        }

        public DataTable ExibirProcedimento()
        {
            return myProcedimento.ExibirProcedimento();
        }

        public DataTable BuscarProcedimento(int id_categoria, string Textobuscar)
        {
            myProcedimento.IDCategoria = id_categoria;
            myProcedimento.TextoBuscar = Textobuscar;

            return myProcedimento.BuscarProcedimento(myProcedimento);
        }

        public DataTable BuscarNomeProcedimento(string Textobuscar)
        {
            myProcedimento.TextoBuscar = Textobuscar;

            return myProcedimento.BuscarNomeProcedimento(myProcedimento);
        }

        public DataTable BuscarCategoriaProcedimento(int id_categoria)
        {
            myProcedimento.IDCategoria = id_categoria;

            return myProcedimento.BuscarCategoriaProcedimento(myProcedimento);
        }
    }
}
