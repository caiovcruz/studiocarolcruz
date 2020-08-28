using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Model
{
    public class ModelBaixaEstoque
    {
        private int _IDBaixaEstoque;
        private int _IDProduto;
        private double _QuantidadeBaixaEstoque;
        private DateTime _DataValidadeBaixaEstoque;
        private DateTime _DataInicioBuscar;
        private DateTime _DataFinalBuscar;
        private string _TextoBuscar;


        public int IDBaixaEstoque { get => _IDBaixaEstoque; set => _IDBaixaEstoque = value; }
        public int IDProduto { get => _IDProduto; set => _IDProduto = value; }
        public double QuantidadeBaixaEstoque { get => _QuantidadeBaixaEstoque; set => _QuantidadeBaixaEstoque = value; }
        public DateTime DataValidadeBaixaEstoque { get => _DataValidadeBaixaEstoque; set => _DataValidadeBaixaEstoque = value; }
        public DateTime DataInicioBuscar { get => _DataInicioBuscar; set => _DataInicioBuscar = value; }
        public DateTime DataFinalBuscar { get => _DataFinalBuscar; set => _DataFinalBuscar = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelBaixaEstoque()
        {

        }

        public ModelBaixaEstoque(
            int id_baixaestoque, 
            int id_produto, 
            double qtde_baixaestoque, 
            DateTime dt_validade, 
            DateTime dtinicio_buscar, 
            DateTime dtfinal_buscar, 
            string textobuscar)
        {
            IDBaixaEstoque = id_baixaestoque;
            IDProduto = id_produto;
            QuantidadeBaixaEstoque = qtde_baixaestoque;
            DataValidadeBaixaEstoque = dt_validade;
            DataInicioBuscar = dtinicio_buscar;
            DataFinalBuscar = dtfinal_buscar;
            TextoBuscar = textobuscar;
        }

        public string BaixaEstoque(ModelBaixaEstoque BaixaEstoque)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbaixa_estoque";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDProduto = new MySqlParameter();
                ParIDProduto.ParameterName = "parID_Produto";
                ParIDProduto.MySqlDbType = MySqlDbType.Int32;
                ParIDProduto.Value = BaixaEstoque.IDProduto;
                MySqlCmd.Parameters.Add(ParIDProduto);

                MySqlParameter ParQTDEEstoque = new MySqlParameter();
                ParQTDEEstoque.ParameterName = "parQTDE_BaixaEstoque";
                ParQTDEEstoque.MySqlDbType = MySqlDbType.Decimal;
                ParQTDEEstoque.Value = BaixaEstoque.QuantidadeBaixaEstoque;
                MySqlCmd.Parameters.Add(ParQTDEEstoque);

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A baixa não foi realizada";

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

        public string RegistrarBaixaEstoque(ModelBaixaEstoque BaixaEstoque)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spregistrar_baixa_estoque";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDProduto = new MySqlParameter();
                ParIDProduto.ParameterName = "parID_Produto";
                ParIDProduto.MySqlDbType = MySqlDbType.Int32;
                ParIDProduto.Value = BaixaEstoque.IDProduto;
                MySqlCmd.Parameters.Add(ParIDProduto);

                MySqlParameter ParQTDEEstoque = new MySqlParameter();
                ParQTDEEstoque.ParameterName = "parQTDE_BaixaEstoque";
                ParQTDEEstoque.MySqlDbType = MySqlDbType.Decimal;
                ParQTDEEstoque.Value = BaixaEstoque.QuantidadeBaixaEstoque;
                MySqlCmd.Parameters.Add(ParQTDEEstoque);

                MySqlParameter ParDataBaixa = new MySqlParameter();
                ParDataBaixa.ParameterName = "parDT_ValidadeBaixaEstoque";
                ParDataBaixa.MySqlDbType = MySqlDbType.Date;
                ParDataBaixa.Value = BaixaEstoque.DataValidadeBaixaEstoque;
                MySqlCmd.Parameters.Add(ParDataBaixa);

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : "O registro da baixa não foi realizado";

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

        public string ExcluirBaixaEstoque(ModelBaixaEstoque BaixaEstoque)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexcluir_baixa_estoque";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDBaixaEstoque = new MySqlParameter();
                ParIDBaixaEstoque.ParameterName = "parID_BaixaEstoque";
                ParIDBaixaEstoque.MySqlDbType = MySqlDbType.Int32;
                ParIDBaixaEstoque.Value = BaixaEstoque.IDProduto;
                MySqlCmd.Parameters.Add(ParIDBaixaEstoque);

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

        public DataTable ExibirBaixaEstoque()
        {
            DataTable DtResultado = new DataTable("tb_baixaestoque");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_baixa_estoque";
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

        public DataTable BuscarBaixaEstoque(ModelBaixaEstoque BaixaEstoque)
        {
            DataTable DtResultado = new DataTable("tb_baixaestoque");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_baixa_estoque";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParDataInicioBuscar = new MySqlParameter();
                ParDataInicioBuscar.ParameterName = "DataInicio";
                ParDataInicioBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataInicioBuscar.Value = BaixaEstoque.DataInicioBuscar;
                MySqlCmd.Parameters.Add(ParDataInicioBuscar);

                MySqlParameter ParDataFinalBuscar = new MySqlParameter();
                ParDataFinalBuscar.ParameterName = "DataFinal";
                ParDataFinalBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataFinalBuscar.Value = BaixaEstoque.DataFinalBuscar;
                MySqlCmd.Parameters.Add(ParDataFinalBuscar);

                MySqlParameter ParNomeProduto = new MySqlParameter();
                ParNomeProduto.ParameterName = "parNM_Produto";
                ParNomeProduto.MySqlDbType = MySqlDbType.VarChar;
                ParNomeProduto.Size = 50;
                ParNomeProduto.Value = BaixaEstoque.TextoBuscar;
                MySqlCmd.Parameters.Add(ParNomeProduto);

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

        public DataTable BuscarDataBaixaEstoque(ModelBaixaEstoque BaixaEstoque)
        {
            DataTable DtResultado = new DataTable("tb_baixaestoque");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_data_baixa_estoque";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParDataInicioBuscar = new MySqlParameter();
                ParDataInicioBuscar.ParameterName = "DataInicio";
                ParDataInicioBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataInicioBuscar.Value = BaixaEstoque.DataInicioBuscar;
                MySqlCmd.Parameters.Add(ParDataInicioBuscar);

                MySqlParameter ParDataFinalBuscar = new MySqlParameter();
                ParDataFinalBuscar.ParameterName = "DataFinal";
                ParDataFinalBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataFinalBuscar.Value = BaixaEstoque.DataFinalBuscar;
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

        public DataTable BuscarProdutoBaixaEstoque(ModelBaixaEstoque BaixaEstoque)
        {
            DataTable DtResultado = new DataTable("tb_baixaestoque");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_produto_baixa_estoque";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParNomeProduto = new MySqlParameter();
                ParNomeProduto.ParameterName = "parNM_Produto";
                ParNomeProduto.MySqlDbType = MySqlDbType.VarChar;
                ParNomeProduto.Size = 50;
                ParNomeProduto.Value = BaixaEstoque.TextoBuscar;
                MySqlCmd.Parameters.Add(ParNomeProduto);

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
