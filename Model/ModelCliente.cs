using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Model
{
    public class ModelCliente : ModelPessoa
    {
        private string _TextoBuscar;

        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelCliente()
        {

        }

        public ModelCliente(
            int id,
            string nome,
            string sexo,
            string cpf,
            DateTime datanascimento,
            string telefone,
            string email,
            string cep,
            string rua,
            string numcasa,
            string bairro,
            string complemento,
            string cidade,
            string estado,
            string textobuscar)
        {
            ID = id;
            Nome = nome;
            Sexo = sexo;
            CPF = cpf;
            DataNascimento = datanascimento;
            Telefone = telefone;
            Email = email;
            CEP = cep;
            Rua = rua;
            NumCasa = numcasa;
            Bairro = bairro;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            TextoBuscar = textobuscar;
        }

        public string InserirCliente(ModelCliente Cliente)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spinserir_cliente";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParID = new MySqlParameter();
                ParID.ParameterName = "parID_Cliente";
                ParID.MySqlDbType = MySqlDbType.Int32;
                ParID.Direction = ParameterDirection.Output;
                MySqlCmd.Parameters.Add(ParID);

                MySqlParameter ParNome = new MySqlParameter();
                ParNome.ParameterName = "parNM_Cliente";
                ParNome.MySqlDbType = MySqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Cliente.Nome;
                MySqlCmd.Parameters.Add(ParNome);

                MySqlParameter ParSexo = new MySqlParameter();
                ParSexo.ParameterName = "parDS_Sexo";
                ParSexo.MySqlDbType = MySqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Cliente.Sexo;
                MySqlCmd.Parameters.Add(ParSexo);

                MySqlParameter ParDataNascimento = new MySqlParameter();
                ParDataNascimento.ParameterName = "parDT_Nascimento";
                ParDataNascimento.MySqlDbType = MySqlDbType.Date;

                if (Cliente.DataNascimento.HasValue)
                {
                    ParDataNascimento.Value = Cliente.DataNascimento;
                    MySqlCmd.Parameters.Add(ParDataNascimento);
                }
                else
                {

                    ParDataNascimento.Value = DBNull.Value;
                    MySqlCmd.Parameters.Add(ParDataNascimento);
                }

                MySqlParameter ParCPF = new MySqlParameter();
                ParCPF.ParameterName = "parNR_CPF";
                ParCPF.MySqlDbType = MySqlDbType.VarChar;
                ParCPF.Size = 11;
                ParCPF.Value = Cliente.CPF;
                MySqlCmd.Parameters.Add(ParCPF);

                MySqlParameter ParTelefone = new MySqlParameter();
                ParTelefone.ParameterName = "parNR_Telefone";
                ParTelefone.MySqlDbType = MySqlDbType.VarChar;
                ParTelefone.Size = 11;
                ParTelefone.Value = Cliente.Telefone;
                MySqlCmd.Parameters.Add(ParTelefone);

                MySqlParameter ParEmail = new MySqlParameter();
                ParEmail.ParameterName = "parDS_Email";
                ParEmail.MySqlDbType = MySqlDbType.VarChar;
                ParEmail.Size = 80;
                ParEmail.Value = Cliente.Email;
                MySqlCmd.Parameters.Add(ParEmail);

                MySqlParameter ParCEP = new MySqlParameter();
                ParCEP.ParameterName = "parNR_CEP";
                ParCEP.MySqlDbType = MySqlDbType.VarChar;
                ParCEP.Size = 10;
                ParCEP.Value = Cliente.CEP;
                MySqlCmd.Parameters.Add(ParCEP);

                MySqlParameter ParRua = new MySqlParameter();
                ParRua.ParameterName = "parNM_Rua";
                ParRua.MySqlDbType = MySqlDbType.VarChar;
                ParRua.Size = 50;
                ParRua.Value = Cliente.Rua;
                MySqlCmd.Parameters.Add(ParRua);

                MySqlParameter ParNumCasa = new MySqlParameter();
                ParNumCasa.ParameterName = "parNR_Casa";
                ParNumCasa.MySqlDbType = MySqlDbType.VarChar;
                ParNumCasa.Size = 5;
                ParNumCasa.Value = Cliente.NumCasa;
                MySqlCmd.Parameters.Add(ParNumCasa);

                MySqlParameter ParBairro = new MySqlParameter();
                ParBairro.ParameterName = "parNM_Bairro";
                ParBairro.MySqlDbType = MySqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Cliente.Bairro;
                MySqlCmd.Parameters.Add(ParBairro);

                MySqlParameter ParComplemento = new MySqlParameter();
                ParComplemento.ParameterName = "parDS_Complemento";
                ParComplemento.MySqlDbType = MySqlDbType.VarChar;
                ParComplemento.Size = 50;
                ParComplemento.Value = Cliente.Complemento;
                MySqlCmd.Parameters.Add(ParComplemento);

                MySqlParameter ParCidade = new MySqlParameter();
                ParCidade.ParameterName = "parNM_Cidade";
                ParCidade.MySqlDbType = MySqlDbType.VarChar;
                ParCidade.Size = 30;
                ParCidade.Value = Cliente.Cidade;
                MySqlCmd.Parameters.Add(ParCidade);

                MySqlParameter ParEstado = new MySqlParameter();
                ParEstado.ParameterName = "parDS_UF";
                ParEstado.MySqlDbType = MySqlDbType.VarChar;
                ParEstado.Size = 2;
                ParEstado.Value = Cliente.Estado;
                MySqlCmd.Parameters.Add(ParEstado);

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

        public string EditarCliente(ModelCliente Cliente)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "speditar_cliente";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParID = new MySqlParameter();
                ParID.ParameterName = "parID_Cliente";
                ParID.MySqlDbType = MySqlDbType.Int32;
                ParID.Value = Cliente.ID;
                MySqlCmd.Parameters.Add(ParID);

                MySqlParameter ParNome = new MySqlParameter();
                ParNome.ParameterName = "parNM_Cliente";
                ParNome.MySqlDbType = MySqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Cliente.Nome;
                MySqlCmd.Parameters.Add(ParNome);

                MySqlParameter ParSexo = new MySqlParameter();
                ParSexo.ParameterName = "parDS_Sexo";
                ParSexo.MySqlDbType = MySqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Cliente.Sexo;
                MySqlCmd.Parameters.Add(ParSexo);

                MySqlParameter ParDataNascimento = new MySqlParameter();
                ParDataNascimento.ParameterName = "parDT_Nascimento";
                ParDataNascimento.MySqlDbType = MySqlDbType.Date;

                if (Cliente.DataNascimento.HasValue)
                {
                    ParDataNascimento.Value = Cliente.DataNascimento;
                    MySqlCmd.Parameters.Add(ParDataNascimento);
                }
                else
                {

                    ParDataNascimento.Value = DBNull.Value;
                    MySqlCmd.Parameters.Add(ParDataNascimento);
                }

                MySqlParameter ParCPF = new MySqlParameter();
                ParCPF.ParameterName = "parNR_CPF";
                ParCPF.MySqlDbType = MySqlDbType.VarChar;
                ParCPF.Size = 11;
                ParCPF.Value = Cliente.CPF;
                MySqlCmd.Parameters.Add(ParCPF);

                MySqlParameter ParTelefone = new MySqlParameter();
                ParTelefone.ParameterName = "parNR_Telefone";
                ParTelefone.MySqlDbType = MySqlDbType.VarChar;
                ParTelefone.Size = 11;
                ParTelefone.Value = Cliente.Telefone;
                MySqlCmd.Parameters.Add(ParTelefone);

                MySqlParameter ParEmail = new MySqlParameter();
                ParEmail.ParameterName = "parDS_Email";
                ParEmail.MySqlDbType = MySqlDbType.VarChar;
                ParEmail.Size = 80;
                ParEmail.Value = Cliente.Email;
                MySqlCmd.Parameters.Add(ParEmail);

                MySqlParameter ParCEP = new MySqlParameter();
                ParCEP.ParameterName = "parNR_CEP";
                ParCEP.MySqlDbType = MySqlDbType.VarChar;
                ParCEP.Size = 10;
                ParCEP.Value = Cliente.CEP;
                MySqlCmd.Parameters.Add(ParCEP);

                MySqlParameter ParRua = new MySqlParameter();
                ParRua.ParameterName = "parNM_Rua";
                ParRua.MySqlDbType = MySqlDbType.VarChar;
                ParRua.Size = 50;
                ParRua.Value = Cliente.Rua;
                MySqlCmd.Parameters.Add(ParRua);

                MySqlParameter ParNumCasa = new MySqlParameter();
                ParNumCasa.ParameterName = "parNR_Casa";
                ParNumCasa.MySqlDbType = MySqlDbType.VarChar;
                ParNumCasa.Size = 5;
                ParNumCasa.Value = Cliente.NumCasa;
                MySqlCmd.Parameters.Add(ParNumCasa);

                MySqlParameter ParBairro = new MySqlParameter();
                ParBairro.ParameterName = "parNM_Bairro";
                ParBairro.MySqlDbType = MySqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Cliente.Bairro;
                MySqlCmd.Parameters.Add(ParBairro);

                MySqlParameter ParComplemento = new MySqlParameter();
                ParComplemento.ParameterName = "parDS_Complemento";
                ParComplemento.MySqlDbType = MySqlDbType.VarChar;
                ParComplemento.Size = 50;
                ParComplemento.Value = Cliente.Complemento;
                MySqlCmd.Parameters.Add(ParComplemento);

                MySqlParameter ParCidade = new MySqlParameter();
                ParCidade.ParameterName = "parNM_Cidade";
                ParCidade.MySqlDbType = MySqlDbType.VarChar;
                ParCidade.Size = 30;
                ParCidade.Value = Cliente.Cidade;
                MySqlCmd.Parameters.Add(ParCidade);

                MySqlParameter ParEstado = new MySqlParameter();
                ParEstado.ParameterName = "parDS_UF";
                ParEstado.MySqlDbType = MySqlDbType.VarChar;
                ParEstado.Size = 2;
                ParEstado.Value = Cliente.Estado;
                MySqlCmd.Parameters.Add(ParEstado);

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

        public string ExcluirCliente(ModelCliente Cliente)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexcluir_cliente";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParID = new MySqlParameter();
                ParID.ParameterName = "parID_Cliente";
                ParID.MySqlDbType = MySqlDbType.Int32;
                ParID.Value = Cliente.ID;
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

        public DataTable ExibirClientes()
        {
            DataTable DtResultado = new DataTable("tb_cliente");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_cliente";
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

        public DataTable BuscarNomeCliente(ModelCliente Cliente)
        {
            DataTable DtResultado = new DataTable("tb_cliente");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_nome_cliente";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Cliente";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
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

        public DataTable BuscarCPFCliente(ModelCliente Cliente)
        {
            DataTable DtResultado = new DataTable("tb_cliente");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_cpf_cliente";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNR_CPF";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 11;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
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
