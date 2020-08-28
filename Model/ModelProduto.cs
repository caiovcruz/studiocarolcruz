using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Model
{
    public class ModelProduto
    {
        private int _IDProduto;
        private string _Nome;
        private string _TipoArmazenamento;
        private string _TextoBuscar;

        public int IDProduto { get => _IDProduto; set => _IDProduto = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string TipoArmazenamento { get => _TipoArmazenamento; set => _TipoArmazenamento = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelProduto()
        {

        }

        public ModelProduto(int id, string nome, string armazenamento, string textobuscar)
        {
            IDProduto = id;
            Nome = nome;
            TipoArmazenamento = armazenamento;
            TextoBuscar = textobuscar;
        }

        public string InserirProduto(ModelProduto Produto)
        {
            string resp = "";

            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spinserir_produto";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDInsumo = new MySqlParameter();
                ParIDInsumo.ParameterName = "parID_Produto";
                ParIDInsumo.MySqlDbType = MySqlDbType.Int32;
                ParIDInsumo.Direction = ParameterDirection.Output;
                MySqlCmd.Parameters.Add(ParIDInsumo);

                MySqlParameter ParNome = new MySqlParameter();
                ParNome.ParameterName = "parNM_Produto";
                ParNome.MySqlDbType = MySqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Produto.Nome;
                MySqlCmd.Parameters.Add(ParNome);

                MySqlParameter ParArmazenamento = new MySqlParameter();
                ParArmazenamento.ParameterName = "parDS_TipoArmazenamento";
                ParArmazenamento.MySqlDbType = MySqlDbType.VarChar;
                ParArmazenamento.Size = 50;
                ParArmazenamento.Value = Produto.TipoArmazenamento;
                MySqlCmd.Parameters.Add(ParArmazenamento);

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

        public string EditarProduto(ModelProduto Produto)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "speditar_produto";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParID = new MySqlParameter();
                ParID.ParameterName = "parID_Produto";
                ParID.MySqlDbType = MySqlDbType.Int32;
                ParID.Value = Produto.IDProduto;
                MySqlCmd.Parameters.Add(ParID);

                MySqlParameter ParNome = new MySqlParameter();
                ParNome.ParameterName = "parNM_Produto";
                ParNome.MySqlDbType = MySqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Produto.Nome;
                MySqlCmd.Parameters.Add(ParNome);

                MySqlParameter ParArmazenamento = new MySqlParameter();
                ParArmazenamento.ParameterName = "parDS_TipoArmazenamento";
                ParArmazenamento.MySqlDbType = MySqlDbType.VarChar;
                ParArmazenamento.Size = 50;
                ParArmazenamento.Value = Produto.TipoArmazenamento;
                MySqlCmd.Parameters.Add(ParArmazenamento);

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

        public string ExcluirProduto(ModelProduto Produto)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexcluir_produto";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDCategoria = new MySqlParameter();
                ParIDCategoria.ParameterName = "parID_Produto";
                ParIDCategoria.MySqlDbType = MySqlDbType.Int32;
                ParIDCategoria.Value = Produto.IDProduto;
                MySqlCmd.Parameters.Add(ParIDCategoria);

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

        public DataTable ExibirProduto()
        {
            DataTable DtResultado = new DataTable("tb_produto");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_produto";
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

        public DataTable ExibirProdutoEstoque()
        {
            DataTable DtResultado = new DataTable("tb_produto");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_produto_estoque";
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

        public DataTable BuscarNomeProdutoEstoque(ModelProduto Produto)
        {
            DataTable DtResultado = new DataTable("tb_produto");
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
                ParTextoBuscar.Value = Produto.TextoBuscar;
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
