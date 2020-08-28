using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Model
{
    public class ModelCategoria
    {
        private int _IDCategoria;
        private string _Nome;
        private string _Descricao;
        private string _TextoBuscar;

        public int IDCategoria { get => _IDCategoria; set => _IDCategoria = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Descricao { get => _Descricao; set => _Descricao = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelCategoria()
        {

        }

        public string InserirCategoria(ModelCategoria Categoria)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spinserir_categoria";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParID = new MySqlParameter();
                ParID.ParameterName = "parID_Categoria";
                ParID.MySqlDbType = MySqlDbType.Int32;
                ParID.Direction = ParameterDirection.Output;
                MySqlCmd.Parameters.Add(ParID);

                MySqlParameter ParNome = new MySqlParameter();
                ParNome.ParameterName = "parNM_Categoria";
                ParNome.MySqlDbType = MySqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Categoria.Nome;
                MySqlCmd.Parameters.Add(ParNome);

                MySqlParameter ParDescricao = new MySqlParameter();
                ParDescricao.ParameterName = "parDS_Categoria";
                ParDescricao.MySqlDbType = MySqlDbType.VarChar;
                ParDescricao.Size = 1500;
                ParDescricao.Value = Categoria.Descricao;
                MySqlCmd.Parameters.Add(ParDescricao);

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

        public string EditarCategoria(ModelCategoria Categoria)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "speditar_categoria";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParID = new MySqlParameter();
                ParID.ParameterName = "parID_Categoria";
                ParID.MySqlDbType = MySqlDbType.Int32;
                ParID.Value = Categoria.IDCategoria;
                MySqlCmd.Parameters.Add(ParID);

                MySqlParameter ParNome = new MySqlParameter();
                ParNome.ParameterName = "parNM_Categoria";
                ParNome.MySqlDbType = MySqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Categoria.Nome;
                MySqlCmd.Parameters.Add(ParNome);

                MySqlParameter ParDescricao = new MySqlParameter();
                ParDescricao.ParameterName = "parDS_Categoria";
                ParDescricao.MySqlDbType = MySqlDbType.VarChar;
                ParDescricao.Size = 1500;
                ParDescricao.Value = Categoria.Descricao;
                MySqlCmd.Parameters.Add(ParDescricao);

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : " A edição não foi realizada";

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

        public string ExcluirCategoria(ModelCategoria Categoria)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexcluir_categoria";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParID = new MySqlParameter();
                ParID.ParameterName = "parID_Categoria";
                ParID.MySqlDbType = MySqlDbType.Int32;
                ParID.Value = Categoria.IDCategoria;
                MySqlCmd.Parameters.Add(ParID);

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A exclusão não foi realizada";

                MySqlCmd.Parameters.Clear();
            }
            catch (Exception)
            {
                resp = "Categoria [" + Categoria.Nome + "] vinculada a um ou mais procedimentos.\nPara excluí-la, é preciso desvinculá-la dos procedimentos primeiro";
            }
            finally
            {
                if (MariaDBCon.State == ConnectionState.Open) MariaDBCon.Close();
            }

            return resp;
        }

        public DataTable ExibirCategoria()
        {
            DataTable DtResultado = new DataTable("tb_categoria");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_categoria";
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

        public DataTable BuscarNomeCategoria(ModelCategoria Categoria)
        {
            DataTable DtResultado = new DataTable("tb_categoria");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_categoria";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Categoria";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Categoria.TextoBuscar;
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
    }
}
