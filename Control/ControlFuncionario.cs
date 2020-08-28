using Model;
using System;
using System.Data;

namespace Control
{
    public class ControlFuncionario
    {
        ModelFuncionario myFuncionario = new ModelFuncionario();

        public string InserirFuncionario(
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
            DateTime admissao)
        {
            myFuncionario.Nome = nome;
            myFuncionario.Sexo = sexo;
            myFuncionario.CPF = cpf;
            myFuncionario.DataNascimento = datanascimento;
            myFuncionario.Telefone = telefone;
            myFuncionario.Email = email;
            myFuncionario.CEP = cep;
            myFuncionario.Rua = rua;
            myFuncionario.NumCasa = numcasa;
            myFuncionario.Bairro = bairro;
            myFuncionario.Complemento = complemento;
            myFuncionario.Cidade = cidade;
            myFuncionario.Estado = estado;
            myFuncionario.Cargo = cargo;
            myFuncionario.Salario = salario;
            myFuncionario.Admissao = admissao;

            return myFuncionario.InserirFuncionario(myFuncionario);
        }

        public string EditarFuncionario(
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
            DateTime admissao)
        {
            myFuncionario.ID = id;
            myFuncionario.Nome = nome;
            myFuncionario.Sexo = sexo;
            myFuncionario.CPF = cpf;
            myFuncionario.DataNascimento = datanascimento;
            myFuncionario.Telefone = telefone;
            myFuncionario.Email = email;
            myFuncionario.CEP = cep;
            myFuncionario.Rua = rua;
            myFuncionario.NumCasa = numcasa;
            myFuncionario.Bairro = bairro;
            myFuncionario.Complemento = complemento;
            myFuncionario.Cidade = cidade;
            myFuncionario.Estado = estado;
            myFuncionario.Cargo = cargo;
            myFuncionario.Salario = salario;
            myFuncionario.Admissao = admissao;

            return myFuncionario.EditarFuncionario(myFuncionario);
        }

        public string ExcluirFuncionario(int id_funcionario)
        {
            myFuncionario.ID = id_funcionario;

            return myFuncionario.ExcluirFuncionario(myFuncionario);
        }

        public DataTable ExibirFuncionario()
        {
            return myFuncionario.ExibirFuncionario();
        }

        public DataTable BuscarNomeFuncionario(string Textobuscar)
        {
            myFuncionario.TextoBuscar = Textobuscar;

            return myFuncionario.BuscarNomeFuncionario(myFuncionario);
        }

        public DataTable BuscarCPFFuncionario(string Textobuscar)
        {
            myFuncionario.TextoBuscar = Textobuscar;

            return myFuncionario.BuscarCPFFuncionario(myFuncionario);
        }
    }
}
