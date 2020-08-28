using Model;
using System.Data;

namespace Control
{
    public class ControlCategoria
    {
        ModelCategoria myCategoria = new ModelCategoria();

        public string InserirCategoria(string nome, string descricao)
        {
            myCategoria.Nome = nome;
            myCategoria.Descricao = descricao;

            return myCategoria.InserirCategoria(myCategoria);
        }

        public string EditarCategoria(int id, string nome, string descricao)
        {
            myCategoria.IDCategoria = id;
            myCategoria.Nome = nome;
            myCategoria.Descricao = descricao;

            return myCategoria.EditarCategoria(myCategoria);
        }

        public string ExcluirCategoria(int id, string nome)
        {
            myCategoria.IDCategoria = id;
            myCategoria.Nome = nome;

            return myCategoria.ExcluirCategoria(myCategoria);
        }

        public DataTable ExibirCategoria()
        {
            return myCategoria.ExibirCategoria();
        }

        public DataTable BuscarNomeCategoria(string Textobuscar)
        {
            myCategoria.TextoBuscar = Textobuscar;

            return myCategoria.BuscarNomeCategoria(myCategoria);
        }
    }
}
