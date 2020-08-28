using Model;
using System.Data;

namespace Control
{
    public class ControlLogin
    {
        ModelLogin myLogin = new ModelLogin();

        public string InserirLogin(string usuario, string senha)
        {
            myLogin.Usuario = usuario;
            myLogin.Senha = senha;

            return myLogin.InserirLogin(myLogin);
        }

        public string EditarLogin(int id_login, string usuario, string senha)
        {
            myLogin.IDLogin = id_login;
            myLogin.Usuario = usuario;
            myLogin.Senha = senha;

            return myLogin.EditarLogin(myLogin);
        }

        public string ExcluirLogin(int id_login)
        {
            myLogin.IDLogin = id_login;

            return myLogin.ExcluirLogin(myLogin);
        }

        public DataTable ExibirLogin()
        {
            return myLogin.ExibirLogin();
        }

        public DataTable BuscarUsuarioLogin(string Textobuscar)
        {
            myLogin.TextoBuscar = Textobuscar;

            return myLogin.BuscarUsuarioLogin(myLogin);
        }

        public bool ValidaLogin(string ds_usuario, string ds_senha)
        {
            myLogin.Usuario = ds_usuario;
            myLogin.Senha = ds_senha;

            return myLogin.ValidaLogin(myLogin);
        }
    }
}
