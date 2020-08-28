using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Model
{
    public class ModelEstoque
    {
        private int _IDProduto;
        private double _QuantidadeEstoque;
        private string _TextoBuscar;

        public int IDProduto { get => _IDProduto; set => _IDProduto = value; }
        public double QuantidadeEstoque { get => _QuantidadeEstoque; set => _QuantidadeEstoque = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelEstoque()
        {

        }

        public ModelEstoque(int id_produto, double qtde_estoque)
        {
            IDProduto = id_produto;
            QuantidadeEstoque = qtde_estoque;
        }

        public string InserirEstoque(ModelEstoque Estoque)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spinserir_estoque";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDProduto = new MySqlParameter();
                ParIDProduto.ParameterName = "parID_Produto";
                ParIDProduto.MySqlDbType = MySqlDbType.Int32;
                ParIDProduto.Value = Estoque.IDProduto;
                MySqlCmd.Parameters.Add(ParIDProduto);

                MySqlParameter ParQTDEEstoque = new MySqlParameter();
                ParQTDEEstoque.ParameterName = "parQTDE_Estoque";
                ParQTDEEstoque.MySqlDbType = MySqlDbType.Decimal;
                ParQTDEEstoque.Value = Estoque.QuantidadeEstoque;
                MySqlCmd.Parameters.Add(ParQTDEEstoque);

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

        public string EditarEstoque(ModelEstoque Estoque)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "speditar_estoque";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDProduto = new MySqlParameter();
                ParIDProduto.ParameterName = "parID_Produto";
                ParIDProduto.MySqlDbType = MySqlDbType.Int32;
                ParIDProduto.Value = Estoque.IDProduto;
                MySqlCmd.Parameters.Add(ParIDProduto);

                MySqlParameter ParQTDEEstoque = new MySqlParameter();
                ParQTDEEstoque.ParameterName = "parQTDE_Estoque";
                ParQTDEEstoque.MySqlDbType = MySqlDbType.Decimal;
                ParQTDEEstoque.Value = Estoque.QuantidadeEstoque;
                MySqlCmd.Parameters.Add(ParQTDEEstoque);

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

        public string ExcluirEstoque(ModelEstoque Estoque)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexcluir_estoque";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDProduto = new MySqlParameter();
                ParIDProduto.ParameterName = "parID_Produto";
                ParIDProduto.MySqlDbType = MySqlDbType.Int32;
                ParIDProduto.Value = Estoque.IDProduto;
                MySqlCmd.Parameters.Add(ParIDProduto);

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

        public DataTable ExibirEstoque()
        {
            DataTable DtResultado = new DataTable("tb_estoque");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_estoque";
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

        public DataTable BuscarNomeProdutoEstoque(ModelEstoque Estoque)
        {
            DataTable DtResultado = new DataTable("tb_estoque");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_produto_estoque";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Produto";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Estoque.TextoBuscar;
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
