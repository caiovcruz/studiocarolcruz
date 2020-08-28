using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Model
{
    public class ModelLote
    {
        private int _IDLote;
        private int _IDProduto;
        private double _QuantidadeLote;
        private DateTime _DataValidade;

        public int IDLote { get => _IDLote; set => _IDLote = value; }
        public int IDProduto { get => _IDProduto; set => _IDProduto = value; }
        public double QuantidadeLote { get => _QuantidadeLote; set => _QuantidadeLote = value; }
        public DateTime DataValidade { get => _DataValidade; set => _DataValidade = value; }

        public ModelLote()
        {

        }

        public ModelLote(int id_lote, int id_produto, double qtde_lote, DateTime dt_validade)
        {
            IDLote = id_lote;
            IDProduto = id_produto;
            QuantidadeLote = qtde_lote;
            DataValidade = dt_validade;
        }

        public string InserirLote(ModelLote Lote)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spinserir_lote";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDLote = new MySqlParameter();
                ParIDLote.ParameterName = "parID_Lote";
                ParIDLote.MySqlDbType = MySqlDbType.Int32;
                ParIDLote.Direction = ParameterDirection.Output;
                MySqlCmd.Parameters.Add(ParIDLote);

                MySqlParameter ParIDProduto = new MySqlParameter();
                ParIDProduto.ParameterName = "parID_Produto";
                ParIDProduto.MySqlDbType = MySqlDbType.Int32;
                ParIDProduto.Value = Lote.IDProduto;
                MySqlCmd.Parameters.Add(ParIDProduto);

                MySqlParameter ParQuantidadeLote = new MySqlParameter();
                ParQuantidadeLote.ParameterName = "parQTDE_Lote";
                ParQuantidadeLote.MySqlDbType = MySqlDbType.Decimal;
                ParQuantidadeLote.Value = Lote.QuantidadeLote;
                MySqlCmd.Parameters.Add(ParQuantidadeLote);

                MySqlParameter ParDataValidade = new MySqlParameter();
                ParDataValidade.ParameterName = "parDT_Validade";
                ParDataValidade.MySqlDbType = MySqlDbType.DateTime;
                ParDataValidade.Value = Lote.DataValidade;
                MySqlCmd.Parameters.Add(ParDataValidade);

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

        public string EditarLote(ModelLote Lote)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "speditar_lote";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDProduto = new MySqlParameter();
                ParIDProduto.ParameterName = "parID_Produto";
                ParIDProduto.MySqlDbType = MySqlDbType.Int32;
                ParIDProduto.Value = Lote.IDProduto;
                MySqlCmd.Parameters.Add(ParIDProduto);

                MySqlParameter ParQuantidadeLote = new MySqlParameter();
                ParQuantidadeLote.ParameterName = "parQTDE_Lote";
                ParQuantidadeLote.MySqlDbType = MySqlDbType.Decimal;
                ParQuantidadeLote.Value = Lote.QuantidadeLote;
                MySqlCmd.Parameters.Add(ParQuantidadeLote);

                MySqlParameter ParDataValidade = new MySqlParameter();
                ParDataValidade.ParameterName = "parDT_Validade";
                ParDataValidade.MySqlDbType = MySqlDbType.DateTime;
                ParDataValidade.Value = Lote.DataValidade;
                MySqlCmd.Parameters.Add(ParDataValidade);

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

        public DataTable ExibirLote()
        {
            DataTable DtResultado = new DataTable("tb_lote");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_lote";
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

        public DataTable BuscarLote(ModelLote Lote)
        {
            DataTable DtResultado = new DataTable("tb_lote");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_lote";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDBuscar = new MySqlParameter();
                ParIDBuscar.ParameterName = "parID_Produto";
                ParIDBuscar.MySqlDbType = MySqlDbType.Int32;
                ParIDBuscar.Value = Lote.IDProduto;
                MySqlCmd.Parameters.Add(ParIDBuscar);

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

        public DataTable BuscarLoteData(ModelLote Lote)
        {
            DataTable DtResultado = new DataTable("tb_lote");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_lote_data";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDBuscar = new MySqlParameter();
                ParIDBuscar.ParameterName = "parID_Produto";
                ParIDBuscar.MySqlDbType = MySqlDbType.Int32;
                ParIDBuscar.Value = Lote.IDProduto;
                MySqlCmd.Parameters.Add(ParIDBuscar);

                MySqlParameter ParDataValidade = new MySqlParameter();
                ParDataValidade.ParameterName = "parDT_Validade";
                ParDataValidade.MySqlDbType = MySqlDbType.DateTime;
                ParDataValidade.Value = Lote.DataValidade;
                MySqlCmd.Parameters.Add(ParDataValidade);

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

        public string BaixaLote(ModelLote Lote)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbaixa_lote";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDProduto = new MySqlParameter();
                ParIDProduto.ParameterName = "parID_Produto";
                ParIDProduto.MySqlDbType = MySqlDbType.Int32;
                ParIDProduto.Value = Lote.IDProduto;
                MySqlCmd.Parameters.Add(ParIDProduto);

                MySqlParameter ParQuantidadeLote = new MySqlParameter();
                ParQuantidadeLote.ParameterName = "parQTDE_Lote";
                ParQuantidadeLote.MySqlDbType = MySqlDbType.Decimal;
                ParQuantidadeLote.Value = Lote.QuantidadeLote;
                MySqlCmd.Parameters.Add(ParQuantidadeLote);

                MySqlParameter ParDataValidade = new MySqlParameter();
                ParDataValidade.ParameterName = "parDT_Validade";
                ParDataValidade.MySqlDbType = MySqlDbType.DateTime;
                ParDataValidade.Value = Lote.DataValidade;
                MySqlCmd.Parameters.Add(ParDataValidade);

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : " A baixa do lote não foi realizada";

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

        public string ValidarLote()
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spvalidar_lote";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A validação de lote não foi realizada";
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

        public string ObterQuantidadeDoLote(ModelLote Lote)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spobter_quantidade_lote";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDBuscar = new MySqlParameter();
                ParIDBuscar.ParameterName = "parID_Produto";
                ParIDBuscar.MySqlDbType = MySqlDbType.Int32;
                ParIDBuscar.Value = Lote.IDProduto;
                MySqlCmd.Parameters.Add(ParIDBuscar);

                MySqlParameter ParDataValidade = new MySqlParameter();
                ParDataValidade.ParameterName = "parDT_Validade";
                ParDataValidade.MySqlDbType = MySqlDbType.DateTime;
                ParDataValidade.Value = Lote.DataValidade;
                MySqlCmd.Parameters.Add(ParDataValidade);

                MySqlDataReader reader = MySqlCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    resp = reader["QTDE_Lote"].ToString();
                }
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
