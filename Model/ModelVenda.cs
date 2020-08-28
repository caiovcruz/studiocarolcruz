using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Model
{
    public class ModelVenda
    {
        private int _IDVenda;
        private int _IDFuncionario;
        private int _IDCliente;
        private string _ObservacaoVenda;
        private string _MetodoPagamento;
        private double _ValorSubtotal;
        private double _ValorLucro;
        private double _ValorTotal;
        private DateTime _DataInicioBuscar;
        private DateTime _DataFinalBuscar;
        private string _TextoBuscar;

        public int IDVenda { get => _IDVenda; set => _IDVenda = value; }
        public int IDFuncionario { get => _IDFuncionario; set => _IDFuncionario = value; }
        public int IDCliente { get => _IDCliente; set => _IDCliente = value; }
        public string ObservacaoVenda { get => _ObservacaoVenda; set => _ObservacaoVenda = value; }
        public string MetodoPagamento { get => _MetodoPagamento; set => _MetodoPagamento = value; }
        public double ValorSubtotal { get => _ValorSubtotal; set => _ValorSubtotal = value; }
        public double ValorLucro { get => _ValorLucro; set => _ValorLucro = value; }
        public double ValorTotal { get => _ValorTotal; set => _ValorTotal = value; }
        public DateTime DataInicioBuscar { get => _DataInicioBuscar; set => _DataInicioBuscar = value; }
        public DateTime DataFinalBuscar { get => _DataFinalBuscar; set => _DataFinalBuscar = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelVenda()
        {

        }

        public ModelVenda(
            int id_venda,
            int id_cliente,
            int id_funcionario,
            string obs_venda,
            string ds_metodopagamento,
            double vl_subtotal,
            double vl_lucro,
            double vl_total,
            DateTime dtiniciobuscar,
            DateTime dtfinalbuscar,
            string textobuscar)
        {
            IDVenda = id_venda;
            IDCliente = id_cliente;
            IDFuncionario = id_funcionario;
            ObservacaoVenda = obs_venda;
            MetodoPagamento = ds_metodopagamento;
            ValorSubtotal = vl_subtotal;
            ValorLucro = vl_lucro;
            ValorTotal = vl_total;
            DataInicioBuscar = dtiniciobuscar;
            DataFinalBuscar = dtfinalbuscar;
            TextoBuscar = textobuscar;
        }


        public string InserirVenda(ModelVenda Venda)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spinserir_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDVenda = new MySqlParameter();
                ParIDVenda.ParameterName = "parID_Venda";
                ParIDVenda.MySqlDbType = MySqlDbType.Int32;
                ParIDVenda.Direction = ParameterDirection.Output;
                MySqlCmd.Parameters.Add(ParIDVenda);

                MySqlParameter ParIDFuncionario = new MySqlParameter();
                ParIDFuncionario.ParameterName = "parID_Funcionario";
                ParIDFuncionario.MySqlDbType = MySqlDbType.Int32;
                ParIDFuncionario.Value = Venda.IDFuncionario;
                MySqlCmd.Parameters.Add(ParIDFuncionario);

                MySqlParameter ParIDCliente = new MySqlParameter();
                ParIDCliente.ParameterName = "parID_Cliente";
                ParIDCliente.MySqlDbType = MySqlDbType.Int32;
                ParIDCliente.Value = Venda.IDCliente;
                MySqlCmd.Parameters.Add(ParIDCliente);

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

        public string EditarVenda(ModelVenda Venda)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "speditar_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDVenda = new MySqlParameter();
                ParIDVenda.ParameterName = "parID_Venda";
                ParIDVenda.MySqlDbType = MySqlDbType.Int32;
                ParIDVenda.Value = Venda.IDVenda;
                MySqlCmd.Parameters.Add(ParIDVenda);

                MySqlParameter ParIDFuncionario = new MySqlParameter();
                ParIDFuncionario.ParameterName = "parID_Funcionario";
                ParIDFuncionario.MySqlDbType = MySqlDbType.Int32;
                ParIDFuncionario.Value = Venda.IDFuncionario;
                MySqlCmd.Parameters.Add(ParIDFuncionario);

                MySqlParameter ParIDCliente = new MySqlParameter();
                ParIDCliente.ParameterName = "parID_Cliente";
                ParIDCliente.MySqlDbType = MySqlDbType.Int32;
                ParIDCliente.Value = Venda.IDCliente;
                MySqlCmd.Parameters.Add(ParIDCliente);

                MySqlParameter ParOBSVenda = new MySqlParameter();
                ParOBSVenda.ParameterName = "parOBS_Venda";
                ParOBSVenda.MySqlDbType = MySqlDbType.VarChar;
                ParOBSVenda.Size = 1500;
                ParOBSVenda.Value = Venda.ObservacaoVenda;
                MySqlCmd.Parameters.Add(ParOBSVenda);

                MySqlParameter parDSMetodoPagamento = new MySqlParameter();
                parDSMetodoPagamento.ParameterName = "parDS_MetodoPagamento";
                parDSMetodoPagamento.MySqlDbType = MySqlDbType.VarChar;
                parDSMetodoPagamento.Size = 20;
                parDSMetodoPagamento.Value = Venda.MetodoPagamento;
                MySqlCmd.Parameters.Add(parDSMetodoPagamento);

                MySqlParameter ParVLSubtotal = new MySqlParameter();
                ParVLSubtotal.ParameterName = "parVL_Subtotal";
                ParVLSubtotal.MySqlDbType = MySqlDbType.Decimal;
                ParVLSubtotal.Value = Venda.ValorSubtotal;
                MySqlCmd.Parameters.Add(ParVLSubtotal);

                MySqlParameter ParVLLucro = new MySqlParameter();
                ParVLLucro.ParameterName = "parVL_Lucro";
                ParVLLucro.MySqlDbType = MySqlDbType.Decimal;
                ParVLLucro.Value = Venda.ValorLucro;
                MySqlCmd.Parameters.Add(ParVLLucro);

                MySqlParameter ParVLTotal = new MySqlParameter();
                ParVLTotal.ParameterName = "parVL_Total";
                ParVLTotal.MySqlDbType = MySqlDbType.Decimal;
                ParVLTotal.Value = Venda.ValorTotal;
                MySqlCmd.Parameters.Add(ParVLTotal);

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

        public string ExcluirVenda(ModelVenda Venda)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexcluir_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDVenda = new MySqlParameter();
                ParIDVenda.ParameterName = "parID_Venda";
                ParIDVenda.MySqlDbType = MySqlDbType.Int32;
                ParIDVenda.Value = Venda.IDVenda;
                MySqlCmd.Parameters.Add(ParIDVenda);

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A exclusão nâo foi realizada";

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

        public string ValidarVenda()
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spvalidar_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                resp = MySqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A validacão não foi realizada";
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

        public DataTable ExibirVendaAno()
        {
            DataTable DtResultado = new DataTable("tb_venda");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_venda_ano";
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

        public DataTable ExibirVendaMes()
        {
            DataTable DtResultado = new DataTable("tb_venda");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_venda_mes";
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

        public DataTable BuscarVenda(ModelVenda Venda)
        {
            DataTable DtResultado = new DataTable("tb_venda");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParDataInicioBuscar = new MySqlParameter();
                ParDataInicioBuscar.ParameterName = "DataInicio";
                ParDataInicioBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataInicioBuscar.Value = Venda.DataInicioBuscar;
                MySqlCmd.Parameters.Add(ParDataInicioBuscar);

                MySqlParameter ParDataFinalBuscar = new MySqlParameter();
                ParDataFinalBuscar.ParameterName = "DataFinal";
                ParDataFinalBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataFinalBuscar.Value = Venda.DataFinalBuscar;
                MySqlCmd.Parameters.Add(ParDataFinalBuscar);

                MySqlParameter ParNomeCliente = new MySqlParameter();
                ParNomeCliente.ParameterName = "parNM_Cliente";
                ParNomeCliente.MySqlDbType = MySqlDbType.VarChar;
                ParNomeCliente.Size = 50;
                ParNomeCliente.Value = Venda.TextoBuscar;
                MySqlCmd.Parameters.Add(ParNomeCliente);

                MySqlParameter ParIDFuncionario = new MySqlParameter();
                ParIDFuncionario.ParameterName = "parID_Funcionario";
                ParIDFuncionario.MySqlDbType = MySqlDbType.Int32;
                ParIDFuncionario.Value = Venda.IDFuncionario;
                MySqlCmd.Parameters.Add(ParIDFuncionario);

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

        public DataTable BuscarDataVenda(ModelVenda Venda)
        {
            DataTable DtResultado = new DataTable("tb_venda");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_data_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParDataInicioBuscar = new MySqlParameter();
                ParDataInicioBuscar.ParameterName = "DataInicio";
                ParDataInicioBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataInicioBuscar.Value = Venda.DataInicioBuscar;
                MySqlCmd.Parameters.Add(ParDataInicioBuscar);

                MySqlParameter ParDataFinalBuscar = new MySqlParameter();
                ParDataFinalBuscar.ParameterName = "DataFinal";
                ParDataFinalBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataFinalBuscar.Value = Venda.DataFinalBuscar;
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

        public DataTable BuscarClienteVenda(ModelVenda Venda)
        {
            DataTable DtResultado = new DataTable("tb_venda");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_cliente_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParNomeCliente = new MySqlParameter();
                ParNomeCliente.ParameterName = "parNM_Cliente";
                ParNomeCliente.MySqlDbType = MySqlDbType.VarChar;
                ParNomeCliente.Size = 50;
                ParNomeCliente.Value = Venda.TextoBuscar;
                MySqlCmd.Parameters.Add(ParNomeCliente);

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

        public DataTable BuscarFuncionarioVenda(ModelVenda Venda)
        {
            DataTable DtResultado = new DataTable("tb_venda");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_funcionario_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDFuncionario = new MySqlParameter();
                ParIDFuncionario.ParameterName = "parID_Funcionario";
                ParIDFuncionario.MySqlDbType = MySqlDbType.Int32;
                ParIDFuncionario.Value = Venda.IDFuncionario;
                MySqlCmd.Parameters.Add(ParIDFuncionario);

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

        public DataTable BuscarDataClienteVenda(ModelVenda Venda)
        {
            DataTable DtResultado = new DataTable("tb_venda");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_data_cliente_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParDataInicioBuscar = new MySqlParameter();
                ParDataInicioBuscar.ParameterName = "DataInicio";
                ParDataInicioBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataInicioBuscar.Value = Venda.DataInicioBuscar;
                MySqlCmd.Parameters.Add(ParDataInicioBuscar);

                MySqlParameter ParDataFinalBuscar = new MySqlParameter();
                ParDataFinalBuscar.ParameterName = "DataFinal";
                ParDataFinalBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataFinalBuscar.Value = Venda.DataFinalBuscar;
                MySqlCmd.Parameters.Add(ParDataFinalBuscar);

                MySqlParameter ParNomeCliente = new MySqlParameter();
                ParNomeCliente.ParameterName = "parNM_Cliente";
                ParNomeCliente.MySqlDbType = MySqlDbType.VarChar;
                ParNomeCliente.Size = 50;
                ParNomeCliente.Value = Venda.TextoBuscar;
                MySqlCmd.Parameters.Add(ParNomeCliente);

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

        public DataTable BuscarDataFuncionarioVenda(ModelVenda Venda)
        {
            DataTable DtResultado = new DataTable("tb_venda");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_data_funcionario_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParDataInicioBuscar = new MySqlParameter();
                ParDataInicioBuscar.ParameterName = "DataInicio";
                ParDataInicioBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataInicioBuscar.Value = Venda.DataInicioBuscar;
                MySqlCmd.Parameters.Add(ParDataInicioBuscar);

                MySqlParameter ParDataFinalBuscar = new MySqlParameter();
                ParDataFinalBuscar.ParameterName = "DataFinal";
                ParDataFinalBuscar.MySqlDbType = MySqlDbType.Date;
                ParDataFinalBuscar.Value = Venda.DataFinalBuscar;
                MySqlCmd.Parameters.Add(ParDataFinalBuscar);

                MySqlParameter ParIDFuncionario = new MySqlParameter();
                ParIDFuncionario.ParameterName = "parID_Funcionario";
                ParIDFuncionario.MySqlDbType = MySqlDbType.Int32;
                ParIDFuncionario.Value = Venda.IDFuncionario;
                MySqlCmd.Parameters.Add(ParIDFuncionario);

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

        public DataTable BuscarFuncionarioClienteVenda(ModelVenda Venda)
        {
            DataTable DtResultado = new DataTable("tb_venda");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_funcionario_cliente_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDFuncionario = new MySqlParameter();
                ParIDFuncionario.ParameterName = "parID_Funcionario";
                ParIDFuncionario.MySqlDbType = MySqlDbType.Int32;
                ParIDFuncionario.Value = Venda.IDFuncionario;
                MySqlCmd.Parameters.Add(ParIDFuncionario);

                MySqlParameter ParNomeCliente = new MySqlParameter();
                ParNomeCliente.ParameterName = "parNM_Cliente";
                ParNomeCliente.MySqlDbType = MySqlDbType.VarChar;
                ParNomeCliente.Size = 50;
                ParNomeCliente.Value = Venda.TextoBuscar;
                MySqlCmd.Parameters.Add(ParNomeCliente);

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
