using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelSessao
    {
        private int _IDVenda;
        private int _IDProcedimento;
        private int _SessaoAtual;
        private int _QuantidadeSessao;
        private string _ObservacaoSessao;
        private string _TextoBuscar;

        public int IDVenda { get => _IDVenda; set => _IDVenda = value; }
        public int IDProcedimento { get => _IDProcedimento; set => _IDProcedimento = value; }
        public int SessaoAtual { get => _SessaoAtual; set => _SessaoAtual = value; }
        public int QuantidadeSessao { get => _QuantidadeSessao; set => _QuantidadeSessao = value; }
        public string ObservacaoSessao { get => _ObservacaoSessao; set => _ObservacaoSessao = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelSessao()
        {

        }

        public ModelSessao(int id_venda, int id_procedimento, int nr_sessaoatual, int qtde_sessao, string obs_sessao, string textobuscar)
        {
            IDVenda = id_venda;
            IDProcedimento = id_procedimento;
            SessaoAtual = nr_sessaoatual;
            QuantidadeSessao = qtde_sessao;
            ObservacaoSessao = obs_sessao;
            TextoBuscar = textobuscar;
        }

        public string InserirSessao(ModelSessao Sessao)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spinserir_sessao";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDVenda = new MySqlParameter();
                ParIDVenda.ParameterName = "parID_Venda";
                ParIDVenda.MySqlDbType = MySqlDbType.Int32;
                ParIDVenda.Value = Sessao.IDVenda;
                MySqlCmd.Parameters.Add(ParIDVenda);

                MySqlParameter ParIDProcedimento = new MySqlParameter();
                ParIDProcedimento.ParameterName = "parID_Procedimento";
                ParIDProcedimento.MySqlDbType = MySqlDbType.Int32;
                ParIDProcedimento.Value = Sessao.IDProcedimento;
                MySqlCmd.Parameters.Add(ParIDProcedimento);

                MySqlParameter ParQuantidadeSessao = new MySqlParameter();
                ParQuantidadeSessao.ParameterName = "parQTDE_Sessao";
                ParQuantidadeSessao.MySqlDbType = MySqlDbType.Int32;
                ParQuantidadeSessao.Value = Sessao.QuantidadeSessao;
                MySqlCmd.Parameters.Add(ParQuantidadeSessao);

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

        public string EditarSessao(ModelSessao Sessao)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "speditar_sessao";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDVenda = new MySqlParameter();
                ParIDVenda.ParameterName = "parID_Venda";
                ParIDVenda.MySqlDbType = MySqlDbType.Int32;
                ParIDVenda.Value = Sessao.IDVenda;
                MySqlCmd.Parameters.Add(ParIDVenda);

                MySqlParameter ParIDProcedimento = new MySqlParameter();
                ParIDProcedimento.ParameterName = "parID_Procedimento";
                ParIDProcedimento.MySqlDbType = MySqlDbType.Int32;
                ParIDProcedimento.Value = Sessao.IDProcedimento;
                MySqlCmd.Parameters.Add(ParIDProcedimento);

                MySqlParameter ParSessaoAtual = new MySqlParameter();
                ParSessaoAtual.ParameterName = "parNR_SessaoAtual";
                ParSessaoAtual.MySqlDbType = MySqlDbType.Int32;
                ParSessaoAtual.Value = Sessao.SessaoAtual;
                MySqlCmd.Parameters.Add(ParSessaoAtual);

                MySqlParameter ParQuantidadeSessao = new MySqlParameter();
                ParQuantidadeSessao.ParameterName = "parQTDE_Sessao";
                ParQuantidadeSessao.MySqlDbType = MySqlDbType.Int32;
                ParQuantidadeSessao.Value = Sessao.QuantidadeSessao;
                MySqlCmd.Parameters.Add(ParQuantidadeSessao);

                MySqlParameter ParObservacaoSessao = new MySqlParameter();
                ParObservacaoSessao.ParameterName = "parOBS_Sessao";
                ParObservacaoSessao.MySqlDbType = MySqlDbType.VarChar;
                ParObservacaoSessao.Size = 3000;
                ParObservacaoSessao.Value = Sessao.ObservacaoSessao;
                MySqlCmd.Parameters.Add(ParObservacaoSessao);

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

        public string ExcluirSessao(ModelSessao Sessao)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexcluir_sessao";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDVenda = new MySqlParameter();
                ParIDVenda.ParameterName = "parID_Venda";
                ParIDVenda.MySqlDbType = MySqlDbType.Int32;
                ParIDVenda.Value = Sessao.IDVenda;
                MySqlCmd.Parameters.Add(ParIDVenda);

                MySqlParameter ParIDProcedimento = new MySqlParameter();
                ParIDProcedimento.ParameterName = "parID_Procedimento";
                ParIDProcedimento.MySqlDbType = MySqlDbType.Int32;
                ParIDProcedimento.Value = Sessao.IDProcedimento;
                MySqlCmd.Parameters.Add(ParIDProcedimento);

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

        public DataTable ExibirSessao()
        {
            DataTable DtResultado = new DataTable("tb_sessao");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_sessao";
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

        public DataTable ExibirSessaoDisponivel()
        {
            DataTable DtResultado = new DataTable("tb_sessao");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_sessao_disponivel";
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

        public DataTable BuscarClienteSessao(ModelSessao Sessao)
        {
            DataTable DtResultado = new DataTable("tb_sessao");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_cliente_sessao";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Cliente";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Sessao.TextoBuscar;
                MySqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(MySqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        public DataTable BuscarClienteSessaoDisponivel(ModelSessao Sessao)
        {
            DataTable DtResultado = new DataTable("tb_sessao");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_cliente_sessao_disponivel";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Cliente";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Sessao.TextoBuscar;
                MySqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(MySqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        public DataTable BuscarProcedimentoSessao(ModelSessao Sessao)
        {
            DataTable DtResultado = new DataTable("tb_sessao");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_procedimento_sessao";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Procedimento";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Sessao.TextoBuscar;
                MySqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(MySqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        public DataTable BuscarProcedimentoSessaoDisponivel(ModelSessao Sessao)
        {
            DataTable DtResultado = new DataTable("tb_sessao");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_procedimento_sessao_disponivel";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Procedimento";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Sessao.TextoBuscar;
                MySqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(MySqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }
    }
}
