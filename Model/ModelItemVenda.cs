using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelItemVenda
    {
        private int _IDVenda;
        private int _IDProcedimento;
        private double _PrecoItemVenda;
        private double _ValorLucro;
        private int _QuantidadeSessao;
        private double _ValorSubtotal;
        private string _TextoBuscar;

        public int IDVenda { get => _IDVenda; set => _IDVenda = value; }
        public int IDProcedimento { get => _IDProcedimento; set => _IDProcedimento = value; }
        public double PrecoItemVenda { get => _PrecoItemVenda; set => _PrecoItemVenda = value; }
        public double ValorLucro { get => _ValorLucro; set => _ValorLucro = value; }
        public int QuantidadeSessao { get => _QuantidadeSessao; set => _QuantidadeSessao = value; }
        public double ValorSubtotal { get => _ValorSubtotal; set => _ValorSubtotal = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }
        
        public ModelItemVenda()
        {

        }

        public ModelItemVenda(int id_venda, int id_procedimento, double pr_itemvenda, double vl_lucro, int qtde_sessao, double vl_subtotal, string textobuscar)
        {
            IDVenda = id_venda;
            IDProcedimento = id_procedimento;
            PrecoItemVenda = pr_itemvenda;
            ValorLucro = vl_lucro;
            QuantidadeSessao = qtde_sessao;
            ValorSubtotal = vl_subtotal;
            TextoBuscar = textobuscar;
        }

        public string InserirItemVenda(ModelItemVenda ItemVenda)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spinserir_item_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDVenda = new MySqlParameter();
                ParIDVenda.ParameterName = "parID_Venda";
                ParIDVenda.MySqlDbType = MySqlDbType.Int32;
                ParIDVenda.Value = ItemVenda.IDVenda;
                MySqlCmd.Parameters.Add(ParIDVenda);

                MySqlParameter ParIDProcedimento = new MySqlParameter();
                ParIDProcedimento.ParameterName = "parID_Procedimento";
                ParIDProcedimento.MySqlDbType = MySqlDbType.Int32;
                ParIDProcedimento.Value = ItemVenda.IDProcedimento;
                MySqlCmd.Parameters.Add(ParIDProcedimento);

                MySqlParameter ParPrecoItemVenda = new MySqlParameter();
                ParPrecoItemVenda.ParameterName = "parPR_ItemVenda";
                ParPrecoItemVenda.MySqlDbType = MySqlDbType.Decimal;
                ParPrecoItemVenda.Value = ItemVenda.PrecoItemVenda;
                MySqlCmd.Parameters.Add(ParPrecoItemVenda);

                MySqlParameter ParValorLucro = new MySqlParameter();
                ParValorLucro.ParameterName = "parVL_Lucro";
                ParValorLucro.MySqlDbType = MySqlDbType.Decimal;
                ParValorLucro.Value = ItemVenda.ValorLucro;
                MySqlCmd.Parameters.Add(ParValorLucro);

                MySqlParameter ParQuantidadeSessao = new MySqlParameter();
                ParQuantidadeSessao.ParameterName = "parQTDE_Sessao";
                ParQuantidadeSessao.MySqlDbType = MySqlDbType.Int32;
                ParQuantidadeSessao.Value = ItemVenda.QuantidadeSessao;
                MySqlCmd.Parameters.Add(ParQuantidadeSessao);

                MySqlParameter ParVLSubtotal = new MySqlParameter();
                ParVLSubtotal.ParameterName = "parVL_Subtotal";
                ParVLSubtotal.MySqlDbType = MySqlDbType.Decimal;
                ParVLSubtotal.Value = ItemVenda.ValorSubtotal;
                MySqlCmd.Parameters.Add(ParVLSubtotal);

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

        public string EditarItemVenda(ModelItemVenda ItemVenda)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "speditar_item_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDVenda = new MySqlParameter();
                ParIDVenda.ParameterName = "parID_Venda";
                ParIDVenda.MySqlDbType = MySqlDbType.Int32;
                ParIDVenda.Value = ItemVenda.IDVenda;
                MySqlCmd.Parameters.Add(ParIDVenda);

                MySqlParameter ParIDProcedimento = new MySqlParameter();
                ParIDProcedimento.ParameterName = "parID_Procedimento";
                ParIDProcedimento.MySqlDbType = MySqlDbType.Int32;
                ParIDProcedimento.Value = ItemVenda.IDProcedimento;
                MySqlCmd.Parameters.Add(ParIDProcedimento);

                MySqlParameter ParPrecoItemVenda = new MySqlParameter();
                ParPrecoItemVenda.ParameterName = "parPR_ItemVenda";
                ParPrecoItemVenda.MySqlDbType = MySqlDbType.Decimal;
                ParPrecoItemVenda.Value = ItemVenda.PrecoItemVenda;
                MySqlCmd.Parameters.Add(ParPrecoItemVenda);

                MySqlParameter ParValorLucro = new MySqlParameter();
                ParValorLucro.ParameterName = "parVL_Lucro";
                ParValorLucro.MySqlDbType = MySqlDbType.Decimal;
                ParValorLucro.Value = ItemVenda.ValorLucro;
                MySqlCmd.Parameters.Add(ParValorLucro);

                MySqlParameter ParQuantidadeSessao = new MySqlParameter();
                ParQuantidadeSessao.ParameterName = "parQTDE_Sessao";
                ParQuantidadeSessao.MySqlDbType = MySqlDbType.Int32;
                ParQuantidadeSessao.Value = ItemVenda.QuantidadeSessao;
                MySqlCmd.Parameters.Add(ParQuantidadeSessao);

                MySqlParameter ParVLSubtotal = new MySqlParameter();
                ParVLSubtotal.ParameterName = "parVL_Subtotal";
                ParVLSubtotal.MySqlDbType = MySqlDbType.Decimal;
                ParVLSubtotal.Value = ItemVenda.ValorSubtotal;
                MySqlCmd.Parameters.Add(ParVLSubtotal);

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

        public string ExcluirItemVenda(ModelItemVenda ItemVenda)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexcluir_item_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDVenda = new MySqlParameter();
                ParIDVenda.ParameterName = "parID_Venda";
                ParIDVenda.MySqlDbType = MySqlDbType.Int32;
                ParIDVenda.Value = ItemVenda.IDVenda;
                MySqlCmd.Parameters.Add(ParIDVenda);

                MySqlParameter ParIDProcedimento = new MySqlParameter();
                ParIDProcedimento.ParameterName = "parID_Procedimento";
                ParIDProcedimento.MySqlDbType = MySqlDbType.Int32;
                ParIDProcedimento.Value = ItemVenda.IDProcedimento;
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

        public DataTable ExibirItemVenda(ModelItemVenda ItemVenda)
        {
            DataTable DtResultado = new DataTable("tb_itemvenda");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_item_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDVenda = new MySqlParameter();
                ParIDVenda.ParameterName = "parID_Venda";
                ParIDVenda.MySqlDbType = MySqlDbType.Int32;
                ParIDVenda.Value = ItemVenda.IDVenda;
                MySqlCmd.Parameters.Add(ParIDVenda);

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

        public DataTable BuscarNomeItemVenda(ModelItemVenda ItemVenda)
        {
            DataTable DtResultado = new DataTable("tb_itemvenda");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_nome_item_venda";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Procedimento";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = ItemVenda.TextoBuscar;
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
