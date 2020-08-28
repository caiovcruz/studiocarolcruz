using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Model
{
    public class ModelFuncionario : ModelPessoa
    {
        private string _Cargo;
        private double _Salario;
        private DateTime _Admissao;
        private string _TextoBuscar;

        public string Cargo { get => _Cargo; set => _Cargo = value; }
        public double Salario { get => _Salario; set => _Salario = value; }
        public DateTime Admissao { get => _Admissao; set => _Admissao = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public ModelFuncionario()
        {

        }

        public ModelFuncionario(
            int id_unidaderede,
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
            string cargo,
            double salario,
            DateTime admissao,
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
            Cargo = cargo;
            Salario = salario;
            Admissao = admissao;
            TextoBuscar = textobuscar;
        }

        public string InserirFuncionario(ModelFuncionario Funcionario)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spinserir_funcionario";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParID = new MySqlParameter();
                ParID.ParameterName = "parID_Funcionario";
                ParID.MySqlDbType = MySqlDbType.Int32;
                ParID.Direction = ParameterDirection.Output;
                MySqlCmd.Parameters.Add(ParID);

                MySqlParameter ParNome = new MySqlParameter();
                ParNome.ParameterName = "parNM_Funcionario";
                ParNome.MySqlDbType = MySqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Funcionario.Nome;
                MySqlCmd.Parameters.Add(ParNome);

                MySqlParameter ParSexo = new MySqlParameter();
                ParSexo.ParameterName = "parDS_Sexo";
                ParSexo.MySqlDbType = MySqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Funcionario.Sexo;
                MySqlCmd.Parameters.Add(ParSexo);

                MySqlParameter ParCPF = new MySqlParameter();
                ParCPF.ParameterName = "parNR_CPF";
                ParCPF.MySqlDbType = MySqlDbType.VarChar;
                ParCPF.Size = 11;
                ParCPF.Value = Funcionario.CPF;
                MySqlCmd.Parameters.Add(ParCPF);

                MySqlParameter ParDataNascimento = new MySqlParameter();
                ParDataNascimento.ParameterName = "parDT_Nascimento";
                ParDataNascimento.MySqlDbType = MySqlDbType.Date;
                ParDataNascimento.Value = Funcionario.DataNascimento;
                MySqlCmd.Parameters.Add(ParDataNascimento);

                MySqlParameter ParTelefone = new MySqlParameter();
                ParTelefone.ParameterName = "parNR_Telefone";
                ParTelefone.MySqlDbType = MySqlDbType.VarChar;
                ParTelefone.Size = 11;
                ParTelefone.Value = Funcionario.Telefone;
                MySqlCmd.Parameters.Add(ParTelefone);

                MySqlParameter ParEmail = new MySqlParameter();
                ParEmail.ParameterName = "parDS_Email";
                ParEmail.MySqlDbType = MySqlDbType.VarChar;
                ParEmail.Size = 80;
                ParEmail.Value = Funcionario.Email;
                MySqlCmd.Parameters.Add(ParEmail);

                MySqlParameter ParCEP = new MySqlParameter();
                ParCEP.ParameterName = "parNR_CEP";
                ParCEP.MySqlDbType = MySqlDbType.VarChar;
                ParCEP.Size = 10;
                ParCEP.Value = Funcionario.CEP;
                MySqlCmd.Parameters.Add(ParCEP);

                MySqlParameter ParRua = new MySqlParameter();
                ParRua.ParameterName = "parNM_Rua";
                ParRua.MySqlDbType = MySqlDbType.VarChar;
                ParRua.Size = 50;
                ParRua.Value = Funcionario.Rua;
                MySqlCmd.Parameters.Add(ParRua);

                MySqlParameter ParNumCasa = new MySqlParameter();
                ParNumCasa.ParameterName = "parNR_Casa";
                ParNumCasa.MySqlDbType = MySqlDbType.VarChar;
                ParNumCasa.Size = 5;
                ParNumCasa.Value = Funcionario.NumCasa;
                MySqlCmd.Parameters.Add(ParNumCasa);

                MySqlParameter ParBairro = new MySqlParameter();
                ParBairro.ParameterName = "parNM_Bairro";
                ParBairro.MySqlDbType = MySqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Funcionario.Bairro;
                MySqlCmd.Parameters.Add(ParBairro);

                MySqlParameter ParComplemento = new MySqlParameter();
                ParComplemento.ParameterName = "parDS_Complemento";
                ParComplemento.MySqlDbType = MySqlDbType.VarChar;
                ParComplemento.Size = 50;
                ParComplemento.Value = Funcionario.Complemento;
                MySqlCmd.Parameters.Add(ParComplemento);

                MySqlParameter ParCidade = new MySqlParameter();
                ParCidade.ParameterName = "parNM_Cidade";
                ParCidade.MySqlDbType = MySqlDbType.VarChar;
                ParCidade.Size = 30;
                ParCidade.Value = Funcionario.Cidade;
                MySqlCmd.Parameters.Add(ParCidade);

                MySqlParameter ParEstado = new MySqlParameter();
                ParEstado.ParameterName = "parDS_UF";
                ParEstado.MySqlDbType = MySqlDbType.VarChar;
                ParEstado.Size = 2;
                ParEstado.Value = Funcionario.Estado;
                MySqlCmd.Parameters.Add(ParEstado);

                MySqlParameter ParCargo = new MySqlParameter();
                ParCargo.ParameterName = "parDS_Cargo";
                ParCargo.MySqlDbType = MySqlDbType.VarChar;
                ParCargo.Size = 30;
                ParCargo.Value = Funcionario.Cargo;
                MySqlCmd.Parameters.Add(ParCargo);

                MySqlParameter ParSalario = new MySqlParameter();
                ParSalario.ParameterName = "parVL_Salario";
                ParSalario.MySqlDbType = MySqlDbType.Decimal;
                ParSalario.Value = Funcionario.Salario;
                MySqlCmd.Parameters.Add(ParSalario);

                MySqlParameter ParAdmissao = new MySqlParameter();
                ParAdmissao.ParameterName = "parDT_Admissao";
                ParAdmissao.MySqlDbType = MySqlDbType.Date;
                ParAdmissao.Value = Funcionario.Admissao;
                MySqlCmd.Parameters.Add(ParAdmissao);

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

        public string EditarFuncionario(ModelFuncionario Funcionario)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "speditar_funcionario";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParID = new MySqlParameter();
                ParID.ParameterName = "parID_Funcionario";
                ParID.MySqlDbType = MySqlDbType.Int32;
                ParID.Value = Funcionario.ID;
                MySqlCmd.Parameters.Add(ParID);

                MySqlParameter ParNome = new MySqlParameter();
                ParNome.ParameterName = "parNM_Funcionario";
                ParNome.MySqlDbType = MySqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Funcionario.Nome;
                MySqlCmd.Parameters.Add(ParNome);

                MySqlParameter ParSexo = new MySqlParameter();
                ParSexo.ParameterName = "parDS_Sexo";
                ParSexo.MySqlDbType = MySqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Funcionario.Sexo;
                MySqlCmd.Parameters.Add(ParSexo);

                MySqlParameter ParCPF = new MySqlParameter();
                ParCPF.ParameterName = "parNR_CPF";
                ParCPF.MySqlDbType = MySqlDbType.VarChar;
                ParCPF.Size = 11;
                ParCPF.Value = Funcionario.CPF;
                MySqlCmd.Parameters.Add(ParCPF);

                MySqlParameter ParDataNascimento = new MySqlParameter();
                ParDataNascimento.ParameterName = "parDT_Nascimento";
                ParDataNascimento.MySqlDbType = MySqlDbType.Date;
                ParDataNascimento.Value = Funcionario.DataNascimento;
                MySqlCmd.Parameters.Add(ParDataNascimento);

                MySqlParameter ParTelefone = new MySqlParameter();
                ParTelefone.ParameterName = "parNR_Telefone";
                ParTelefone.MySqlDbType = MySqlDbType.VarChar;
                ParTelefone.Size = 11;
                ParTelefone.Value = Funcionario.Telefone;
                MySqlCmd.Parameters.Add(ParTelefone);

                MySqlParameter ParEmail = new MySqlParameter();
                ParEmail.ParameterName = "parDS_Email";
                ParEmail.MySqlDbType = MySqlDbType.VarChar;
                ParEmail.Size = 80;
                ParEmail.Value = Funcionario.Email;
                MySqlCmd.Parameters.Add(ParEmail);

                MySqlParameter ParCEP = new MySqlParameter();
                ParCEP.ParameterName = "parNR_CEP";
                ParCEP.MySqlDbType = MySqlDbType.VarChar;
                ParCEP.Size = 10;
                ParCEP.Value = Funcionario.CEP;
                MySqlCmd.Parameters.Add(ParCEP);

                MySqlParameter ParRua = new MySqlParameter();
                ParRua.ParameterName = "parNM_Rua";
                ParRua.MySqlDbType = MySqlDbType.VarChar;
                ParRua.Size = 50;
                ParRua.Value = Funcionario.Rua;
                MySqlCmd.Parameters.Add(ParRua);

                MySqlParameter ParNumCasa = new MySqlParameter();
                ParNumCasa.ParameterName = "parNR_Casa";
                ParNumCasa.MySqlDbType = MySqlDbType.VarChar;
                ParNumCasa.Size = 5;
                ParNumCasa.Value = Funcionario.NumCasa;
                MySqlCmd.Parameters.Add(ParNumCasa);

                MySqlParameter ParBairro = new MySqlParameter();
                ParBairro.ParameterName = "parNM_Bairro";
                ParBairro.MySqlDbType = MySqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Funcionario.Bairro;
                MySqlCmd.Parameters.Add(ParBairro);

                MySqlParameter ParComplemento = new MySqlParameter();
                ParComplemento.ParameterName = "parDS_Complemento";
                ParComplemento.MySqlDbType = MySqlDbType.VarChar;
                ParComplemento.Size = 50;
                ParComplemento.Value = Funcionario.Complemento;
                MySqlCmd.Parameters.Add(ParComplemento);

                MySqlParameter ParCidade = new MySqlParameter();
                ParCidade.ParameterName = "parNM_Cidade";
                ParCidade.MySqlDbType = MySqlDbType.VarChar;
                ParCidade.Size = 30;
                ParCidade.Value = Funcionario.Cidade;
                MySqlCmd.Parameters.Add(ParCidade);

                MySqlParameter ParEstado = new MySqlParameter();
                ParEstado.ParameterName = "parDS_UF";
                ParEstado.MySqlDbType = MySqlDbType.VarChar;
                ParEstado.Size = 2;
                ParEstado.Value = Funcionario.Estado;
                MySqlCmd.Parameters.Add(ParEstado);

                MySqlParameter ParCargo = new MySqlParameter();
                ParCargo.ParameterName = "parDS_Cargo";
                ParCargo.MySqlDbType = MySqlDbType.VarChar;
                ParCargo.Size = 30;
                ParCargo.Value = Funcionario.Cargo;
                MySqlCmd.Parameters.Add(ParCargo);

                MySqlParameter ParSalario = new MySqlParameter();
                ParSalario.ParameterName = "parVL_Salario";
                ParSalario.MySqlDbType = MySqlDbType.Decimal;
                ParSalario.Value = Funcionario.Salario;
                MySqlCmd.Parameters.Add(ParSalario);

                MySqlParameter ParAdmissao = new MySqlParameter();
                ParAdmissao.ParameterName = "parDT_Admissao";
                ParAdmissao.MySqlDbType = MySqlDbType.Date;
                ParAdmissao.Value = Funcionario.Admissao;
                MySqlCmd.Parameters.Add(ParAdmissao);

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

        public string ExcluirFuncionario(ModelFuncionario Funcionario)
        {
            string resp = "";
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MariaDBCon.Open();

                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexcluir_funcionario";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParID = new MySqlParameter();
                ParID.ParameterName = "parID_Funcionario";
                ParID.MySqlDbType = MySqlDbType.Int32;
                ParID.Value = Funcionario.ID;
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

        public DataTable ExibirFuncionario()
        {
            DataTable DtResultado = new DataTable("tb_funcionario");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spexibir_funcionario";
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

        public DataTable BuscarNomeFuncionario(ModelFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("tb_funcionario");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_nome_funcionario";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNM_Funcionario";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Funcionario.TextoBuscar;
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

        public DataTable BuscarCPFFuncionario(ModelFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("tb_funcionario");
            MySqlConnection MariaDBCon = new MySqlConnection();

            try
            {
                MariaDBCon.ConnectionString = ModelConexao.Conexao;
                MySqlCommand MySqlCmd = new MySqlCommand();
                MySqlCmd.Connection = MariaDBCon;
                MySqlCmd.CommandText = "spbuscar_cpf_funcionario";
                MySqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "parNR_CPF";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 11;
                ParTextoBuscar.Value = Funcionario.TextoBuscar;
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
