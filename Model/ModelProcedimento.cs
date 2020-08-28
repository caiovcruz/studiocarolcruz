using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Model
{
    public class ModelProcedimento
    {
        private int _IDProcedimento;
        private int _IDCategoria;
        private string _Nome;
        private string _Descricao;
        private string _TextoBuscar;

        public int IDProcedimento { get => _IDProcedimento; set => _IDProcedimento = value; }
        public int IDCategoria { get => _IDCategoria; set => _IDCategoria = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Descricao { get => _Descricao; set => _Descricao = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelProcedimento()
        {

        }

        public ModelProcedimento(int id, int categoria, string nome, string descricao, string textobuscar)
        {
            IDProcedimento = id;
            IDCategoria = categoria;
            Nome = nome;
            Descricao = descricao;
            TextoBuscar = textobuscar;
        }

        public string InserirProcedimento(ModelProcedimento Procedimento)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spinserir_procedimento";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParID = new MySqlParameter();
                ParID.ParameterName = "parID_Procedimento";
                ParID.MySqlDbType = MySqlDbType.Int32;
                ParID.Direction = ParameterDirection.Output;
                MySqlCmd.Parameters.Add(ParID);

                MySqlParameter ParIDCategoria = new MySqlParameter();
                ParIDCategoria.ParameterName = "parID_Categoria";
                ParIDCategoria.MySqlDbType = MySqlDbType.Int32;
                ParIDCategoria.Value = Procedimento.IDCategoria;
                MySqlCmd.Parameters.Add(ParIDCategoria);

                MySqlParameter ParNome = new MySqlParameter();
                ParNome.ParameterName = "parNM_Procedimento";
                ParNome.MySqlDbType = MySqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Procedimento.Nome;
                MySqlCmd.Parameters.Add(ParNome);

                MySqlParameter ParDescricao = new MySqlParameter();
                ParDescricao.ParameterName = "parDS_Procedimento";
                ParDescricao.MySqlDbType = MySqlDbType.VarChar;
                ParDescricao.Size = 3000;
                ParDescricao.Value = Procedimento.Descricao;
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

        public string EditarProcedimento(ModelProcedimento Procedimento)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "speditar_procedimento";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParID = new MySqlParameter();
                ParID.ParameterName = "parID_Procedimento";
                ParID.MySqlDbType = MySqlDbType.Int32;
                ParID.Value = Procedimento.IDProcedimento;
                MySqlCmd.Parameters.Add(ParID);

                MySqlParameter ParIDCategoria = new MySqlParameter();
                ParIDCategoria.ParameterName = "parID_Categoria";
                ParIDCategoria.MySqlDbType = MySqlDbType.Int32;
                ParIDCategoria.Value = Procedimento.IDCategoria;
                MySqlCmd.Parameters.Add(ParIDCategoria);

                MySqlParameter ParNome = new MySqlParameter();
                ParNome.ParameterName = "parNM_Procedimento";
                ParNome.MySqlDbType = MySqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Procedimento.Nome;
                MySqlCmd.Parameters.Add(ParNome);

                MySqlParameter ParDescricao = new MySqlParameter();
                ParDescricao.ParameterName = "parDS_Procedimento";
                ParDescricao.MySqlDbType = MySqlDbType.VarChar;
                ParDescricao.Size = 3000;
                ParDescricao.Value = Procedimento.Descricao;
                MySqlCmd.Parameters.Add(ParDescricao);

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

        public string ExcluirProcedimento(ModelProcedimento Procedimento)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexcluir_procedimento";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParID = new MySqlParameter();
                ParID.ParameterName = "parID_Procedimento";
                ParID.MySqlDbType = MySqlDbType.Int32;
                ParID.Value = Procedimento.IDProcedimento;
                MySqlCmd.Parameters.Add(ParID);

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

        public DataTable ExibirProcedimento()
        {
            DataTable DtResultado = new DataTable("tb_procedimento");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_procedimento";
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

        public DataTable BuscarProcedimento(ModelProcedimento Procedimento)
        {
            DataTable DtResultado = new DataTable("tb_procedimento");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_procedimento";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDCategoria = new MySqlParameter();
                ParIDCategoria.ParameterName = "parID_Categoria";
                ParIDCategoria.MySqlDbType = MySqlDbType.Int32;
                ParIDCategoria.Value = Procedimento.IDCategoria;
                MySqlCmd.Parameters.Add(ParIDCategoria);

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Procedimento";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Procedimento.TextoBuscar;
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

        public DataTable BuscarNomeProcedimento(ModelProcedimento Procedimento)
        {
            DataTable DtResultado = new DataTable("tb_procedimento");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_nome_procedimento";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Procedimento";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Procedimento.TextoBuscar;
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

        public DataTable BuscarCategoriaProcedimento(ModelProcedimento Procedimento)
        {
            DataTable DtResultado = new DataTable("tb_procedimento");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_categoria_procedimento";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDCategoria = new MySqlParameter();
                ParIDCategoria.ParameterName = "parID_Categoria";
                ParIDCategoria.MySqlDbType = MySqlDbType.Int32;
                ParIDCategoria.Value = Procedimento.IDCategoria;
                MySqlCmd.Parameters.Add(ParIDCategoria);

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
