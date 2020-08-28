using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Model
{
    public class ModelLogin
    {
        private int _IDLogin;
        private string _Usuario;
        private string _Senha;
        private string _TextoBuscar;

        public int IDLogin { get => _IDLogin; set => _IDLogin = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Senha { get => _Senha; set => _Senha = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelLogin()
        {

        }

        public ModelLogin(int id_login, string usuario, string senha)
        {
            IDLogin = id_login;
            Usuario = usuario;
            Senha = senha;
        }

        public string InserirLogin(ModelLogin Login)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spinserir_login";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDLogin = new MySqlParameter();
                ParIDLogin.ParameterName = "parID_Login";
                ParIDLogin.MySqlDbType = MySqlDbType.Int32;
                ParIDLogin.Direction = ParameterDirection.Output;
                MySqlCmd.Parameters.Add(ParIDLogin);

                MySqlParameter ParUsuario = new MySqlParameter();
                ParUsuario.ParameterName = "parDS_Usuario";
                ParUsuario.MySqlDbType = MySqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Login.Usuario;
                MySqlCmd.Parameters.Add(ParUsuario);

                MySqlParameter ParSenha = new MySqlParameter();
                ParSenha.ParameterName = "parDS_Senha";
                ParSenha.MySqlDbType = MySqlDbType.VarChar;
                ParSenha.Size = 20;
                ParSenha.Value = Login.Senha;
                MySqlCmd.Parameters.Add(ParSenha);

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : "O registro não foi inserido";

                MySqlCmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (MariaDBCon.State == ConnectionState.Open) MariaDBCon.Close();
            }

            return resp;
        }

        public string EditarLogin(ModelLogin Login)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "speditar_login";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDLogin = new MySqlParameter();
                ParIDLogin.ParameterName = "parID_Login";
                ParIDLogin.MySqlDbType = MySqlDbType.Int32;
                ParIDLogin.Value = Login.IDLogin;
                MySqlCmd.Parameters.Add(ParIDLogin);

                MySqlParameter ParUsuario = new MySqlParameter();
                ParUsuario.ParameterName = "parDS_Usuario";
                ParUsuario.MySqlDbType = MySqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Login.Usuario;
                MySqlCmd.Parameters.Add(ParUsuario);

                MySqlParameter ParSenha = new MySqlParameter();
                ParSenha.ParameterName = "parDS_Senha";
                ParSenha.MySqlDbType = MySqlDbType.VarChar;
                ParSenha.Size = 20;
                ParSenha.Value = Login.Senha;
                MySqlCmd.Parameters.Add(ParSenha);

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A edição não foi realizada";

                MySqlCmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (MariaDBCon.State == ConnectionState.Open) MariaDBCon.Close();
            }

            return resp;
        }

        public string ExcluirLogin(ModelLogin Login)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexcluir_login";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDLogin = new MySqlParameter();
                ParIDLogin.ParameterName = "parID_Login";
                ParIDLogin.MySqlDbType = MySqlDbType.Int32;
                ParIDLogin.Value = Login.IDLogin;
                MySqlCmd.Parameters.Add(ParIDLogin);

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A exclusão não foi realizada";

                MySqlCmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (MariaDBCon.State == ConnectionState.Open) MariaDBCon.Close();
            }

            return resp;
        }

        public DataTable ExibirLogin()
        {
            DataTable DtResultado = new DataTable("tb_login");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_login";
                MySqlCmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter SqlDat = new MySqlDataAdapter(MySqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        public DataTable BuscarUsuarioLogin(ModelLogin Login)
        {
            DataTable DtResultado = new DataTable("tb_login");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_usuario_login";
                MySqlCmd.CommandType = CommandType.StoredProcedure;


                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parDS_Usuario";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Login.TextoBuscar;
                MySqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(MySqlCmd);
                SqlDat.Fill(DtResultado);

                MySqlCmd.Parameters.Clear();
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        public bool ValidaLogin(ModelLogin Login)
        {
            MySqlConnection MariaDBCon = new MySqlConnection();

            MariaDBCon.ConnectionString = ModelConexao.Conexao;
            MariaDBCon.Open();
            MySqlCommand MySqlCmd = new MySqlCommand();
            MySqlCmd.Connection = MariaDBCon;
            MySqlCmd.CommandText = "spvalidar_login";
            MySqlCmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter PArUsuario = new MySqlParameter();
            PArUsuario.ParameterName = "parDS_Usuario";
            PArUsuario.MySqlDbType = MySqlDbType.VarChar;
            PArUsuario.Size = 20;
            PArUsuario.Value = Login.Usuario;
            MySqlCmd.Parameters.Add(PArUsuario);

            MySqlParameter ParSenha = new MySqlParameter();
            ParSenha.ParameterName = "parDS_Senha";
            ParSenha.MySqlDbType = MySqlDbType.VarChar;
            ParSenha.Size = 20;
            ParSenha.Value = Login.Senha;
            MySqlCmd.Parameters.Add(ParSenha);

            MySqlDataReader reader = MySqlCmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
