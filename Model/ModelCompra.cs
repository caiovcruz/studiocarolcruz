using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Model
{
    public class ModelCompra
    {
        private int _IDCompra;
        private int _IDProduto;
        private double _ValorCompra;
        private DateTime _DataInicioBuscar;
        private DateTime _DataFinalBuscar;
        private string _TextoBuscar;

        public int IDCompra { get => _IDCompra; set => _IDCompra = value; }
        public int IDProduto { get => _IDProduto; set => _IDProduto = value; }
        public double ValorCompra { get => _ValorCompra; set => _ValorCompra = value; }
        public DateTime DataInicioBuscar { get => _DataInicioBuscar; set => _DataInicioBuscar = value; }
        public DateTime DataFinalBuscar { get => _DataFinalBuscar; set => _DataFinalBuscar = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelCompra()
        {

        }

        public ModelCompra(
            int id_compra, 
            int id_produto, 
            double vl_compra, 
            DateTime dt_iniciobuscar, 
            DateTime dt_finalbuscar,
            string textobuscar)
        {
            IDCompra = id_compra;
            IDProduto = id_produto;
            ValorCompra = vl_compra;
            DataInicioBuscar = dt_iniciobuscar;
            DataFinalBuscar = dt_finalbuscar;
            TextoBuscar = textobuscar;
        }

        public string InserirCompra()
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spinserir_compra";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : "O registro não foi inserido";
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

        public string FinalizarCompra(ModelCompra Compra)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spfinalizar_compra";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDCompra = new MySqlParameter();
                ParIDCompra.ParameterName = "parID_Compra";
                ParIDCompra.MySqlDbType = MySqlDbType.Int32;
                ParIDCompra.Value = Compra.IDCompra;
                MySqlCmd.Parameters.Add(ParIDCompra);

                MySqlParameter ParValorCompra = new MySqlParameter();
                ParValorCompra.ParameterName = "parVL_Compra";
                ParValorCompra.MySqlDbType = MySqlDbType.Decimal;
                ParValorCompra.Value = Compra.ValorCompra;
                MySqlCmd.Parameters.Add(ParValorCompra);

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A compra não foi finalizada";

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

        public string ExcluirCompra(ModelCompra Compra)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexcluir_compra";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDCompra = new MySqlParameter();
                ParIDCompra.ParameterName = "parID_Compra";
                ParIDCompra.MySqlDbType = MySqlDbType.Int32;
                ParIDCompra.Value = Compra.IDCompra;
                MySqlCmd.Parameters.Add(ParIDCompra);

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


        public DataTable ExibirCompra()
        {
            DataTable DtResultado = new DataTable("tb_compra");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_compra";
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

        public DataTable BuscarCompra(ModelCompra Compra)
        {
            DataTable DtResultado = new DataTable("tb_compra");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_compra";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParDataInicioBuscar = new MySqlParameter();
                ParDataInicioBuscar.ParameterName = "DataInicio";
                ParDataInicioBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataInicioBuscar.Value = Compra.DataInicioBuscar;
                MySqlCmd.Parameters.Add(ParDataInicioBuscar);

                MySqlParameter ParDataFinalBuscar = new MySqlParameter();
                ParDataFinalBuscar.ParameterName = "DataFinal";
                ParDataFinalBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataFinalBuscar.Value = Compra.DataFinalBuscar;
                MySqlCmd.Parameters.Add(ParDataFinalBuscar);

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Produto";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Compra.TextoBuscar;
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

        public DataTable BuscarDataCompra(ModelCompra Compra)
        {
            DataTable DtResultado = new DataTable("tb_compra");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_data_compra";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParDataInicioBuscar = new MySqlParameter();
                ParDataInicioBuscar.ParameterName = "DataInicio";
                ParDataInicioBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataInicioBuscar.Value = Compra.DataInicioBuscar;
                MySqlCmd.Parameters.Add(ParDataInicioBuscar);

                MySqlParameter ParDataFinalBuscar = new MySqlParameter();
                ParDataFinalBuscar.ParameterName = "DataFinal";
                ParDataFinalBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataFinalBuscar.Value = Compra.DataFinalBuscar;
                MySqlCmd.Parameters.Add(ParDataFinalBuscar);

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

        public DataTable BuscarProdutoCompra(ModelCompra Compra)
        {
            DataTable DtResultado = new DataTable("tb_compra");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_produto_compra";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Produto";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Compra.TextoBuscar;
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

        public string ValidarCompra()
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spvalidar_compra";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A validação não foi realizada";
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
    }
}
