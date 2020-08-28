using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Model
{
    public class ModelItemCompra
    {
        private int _IDCompra;
        private int _IDProduto;
        private DateTime _DataValidade;
        private DateTime _DataValidadeEditar;
        private double _QuantidadeItemCompra;
        private double _ValorItemCompra;
        private string _TextoBuscar;

        public int IDCompra { get => _IDCompra; set => _IDCompra = value; }
        public int IDProduto { get => _IDProduto; set => _IDProduto = value; }
        public DateTime DataValidade { get => _DataValidade; set => _DataValidade = value; }
        public DateTime DataValidadeEditar { get => _DataValidadeEditar; set => _DataValidadeEditar = value; }
        public double QuantidadeItemCompra { get => _QuantidadeItemCompra; set => _QuantidadeItemCompra = value; }
        public double ValorItemCompra { get => _ValorItemCompra; set => _ValorItemCompra = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelItemCompra()
        {

        }


        public ModelItemCompra(int id_compra, int id_produto, DateTime dt_validade, DateTime dt_validadeeditar, int qtde_itemcompra, double vl_itemcompra, string textobuscar)
        {
            IDCompra = id_compra;
            IDProduto = id_produto;
            DataValidade = dt_validade;
            DataValidadeEditar = dt_validadeeditar;
            QuantidadeItemCompra = qtde_itemcompra;
            ValorItemCompra = vl_itemcompra;
            TextoBuscar = textobuscar;
        }


        public string InserirItemCompra(ModelItemCompra ItemCompra)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spinserir_item_compra";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDCompra = new MySqlParameter();
                ParIDCompra.ParameterName = "parID_Compra";
                ParIDCompra.MySqlDbType = MySqlDbType.Int32;
                ParIDCompra.Value = ItemCompra.IDCompra;
                MySqlCmd.Parameters.Add(ParIDCompra);

                MySqlParameter ParIDProduto = new MySqlParameter();
                ParIDProduto.ParameterName = "parID_Produto";
                ParIDProduto.MySqlDbType = MySqlDbType.Int32;
                ParIDProduto.Value = ItemCompra.IDProduto;
                MySqlCmd.Parameters.Add(ParIDProduto);

                MySqlParameter ParDataValidade = new MySqlParameter();
                ParDataValidade.ParameterName = "parDT_Validade";
                ParDataValidade.MySqlDbType = MySqlDbType.Date;
                ParDataValidade.Value = ItemCompra.DataValidade;
                MySqlCmd.Parameters.Add(ParDataValidade);

                MySqlParameter ParQuantidadeItemCompra = new MySqlParameter();
                ParQuantidadeItemCompra.ParameterName = "parQTDE_ItemCompra";
                ParQuantidadeItemCompra.MySqlDbType = MySqlDbType.Decimal;
                ParQuantidadeItemCompra.Value = ItemCompra.QuantidadeItemCompra;
                MySqlCmd.Parameters.Add(ParQuantidadeItemCompra);

                MySqlParameter ParValorItemCompra = new MySqlParameter();
                ParValorItemCompra.ParameterName = "parVL_ItemCompra";
                ParValorItemCompra.MySqlDbType = MySqlDbType.Decimal;
                ParValorItemCompra.Value = ItemCompra.ValorItemCompra;
                MySqlCmd.Parameters.Add(ParValorItemCompra);

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

        public string EditarItemCompra(ModelItemCompra ItemCompra)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "speditar_item_compra";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDCompra = new MySqlParameter();
                ParIDCompra.ParameterName = "parID_Compra";
                ParIDCompra.MySqlDbType = MySqlDbType.Int32;
                ParIDCompra.Value = ItemCompra.IDCompra;
                MySqlCmd.Parameters.Add(ParIDCompra);

                MySqlParameter ParIDProduto = new MySqlParameter();
                ParIDProduto.ParameterName = "parID_Produto";
                ParIDProduto.MySqlDbType = MySqlDbType.Int32;
                ParIDProduto.Value = ItemCompra.IDProduto;
                MySqlCmd.Parameters.Add(ParIDProduto);

                MySqlParameter ParDataValidade = new MySqlParameter();
                ParDataValidade.ParameterName = "parDT_Validade";
                ParDataValidade.MySqlDbType = MySqlDbType.Date;
                ParDataValidade.Value = ItemCompra.DataValidade;
                MySqlCmd.Parameters.Add(ParDataValidade);

                MySqlParameter ParDataValidadeEditar = new MySqlParameter();
                ParDataValidadeEditar.ParameterName = "parDT_ValidadeEditar";
                ParDataValidadeEditar.MySqlDbType = MySqlDbType.Date;
                ParDataValidadeEditar.Value = ItemCompra.DataValidadeEditar;
                MySqlCmd.Parameters.Add(ParDataValidadeEditar);

                MySqlParameter ParQuantidadeItemCompra = new MySqlParameter();
                ParQuantidadeItemCompra.ParameterName = "parQTDE_ItemCompra";
                ParQuantidadeItemCompra.MySqlDbType = MySqlDbType.Decimal;
                ParQuantidadeItemCompra.Value = ItemCompra.QuantidadeItemCompra;
                MySqlCmd.Parameters.Add(ParQuantidadeItemCompra);

                MySqlParameter ParValorItemCompra = new MySqlParameter();
                ParValorItemCompra.ParameterName = "parVL_ItemCompra";
                ParValorItemCompra.MySqlDbType = MySqlDbType.Decimal;
                ParValorItemCompra.Value = ItemCompra.ValorItemCompra;
                MySqlCmd.Parameters.Add(ParValorItemCompra);

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

        public string ExcluirItemCompra(ModelItemCompra ItemCompra)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexcluir_item_compra";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDCompra = new MySqlParameter();
                ParIDCompra.ParameterName = "parID_Compra";
                ParIDCompra.MySqlDbType = MySqlDbType.Int32;
                ParIDCompra.Value = ItemCompra.IDCompra;
                MySqlCmd.Parameters.Add(ParIDCompra);

                MySqlParameter ParIDProduto = new MySqlParameter();
                ParIDProduto.ParameterName = "parID_Produto";
                ParIDProduto.MySqlDbType = MySqlDbType.Int32;
                ParIDProduto.Value = ItemCompra.IDProduto;
                MySqlCmd.Parameters.Add(ParIDProduto);

                MySqlParameter ParDataValidade = new MySqlParameter();
                ParDataValidade.ParameterName = "parDT_Validade";
                ParDataValidade.MySqlDbType = MySqlDbType.Date;
                ParDataValidade.Value = ItemCompra.DataValidade;
                MySqlCmd.Parameters.Add(ParDataValidade);

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


        public DataTable ExibirItemCompra(ModelItemCompra ItemCompra)
        {
            DataTable DtResultado = new DataTable("tb_itemcompra");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_item_compra";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDCompra = new MySqlParameter();
                ParIDCompra.ParameterName = "parID_Compra";
                ParIDCompra.MySqlDbType = MySqlDbType.Int32;
                ParIDCompra.Value = ItemCompra.IDCompra;
                MySqlCmd.Parameters.Add(ParIDCompra);

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

        public DataTable BuscarNomeItemCompra(ModelItemCompra ItemCompra)
        {
            DataTable DtResultado = new DataTable("tb_itemcompra");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_nome_item_compra";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Produto";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = ItemCompra.TextoBuscar;
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
