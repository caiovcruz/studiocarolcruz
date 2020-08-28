using Model;
using System;
using System.Data;

namespace Control
{
    public class ControlVenda
    {
        ModelVenda myVenda = new ModelVenda();

        public string InserirVenda(int id_funcionario, int id_cliente)
        {
            myVenda.IDFuncionario = id_funcionario;
            myVenda.IDCliente = id_cliente;

            return myVenda.InserirVenda(myVenda);
        }

        public string EditarVenda(
            int id_venda,
            int id_funcionario,
            int id_cliente,
            string obs_venda,
            string ds_metodopagamento,
            double vl_subtotal,
            double vl_lucro,
            double vl_total)
        {
            myVenda.IDVenda = id_venda;
            myVenda.IDFuncionario = id_funcionario;
            myVenda.IDCliente = id_cliente;
            myVenda.ObservacaoVenda = obs_venda;
            myVenda.MetodoPagamento = ds_metodopagamento;
            myVenda.ValorSubtotal = vl_subtotal;
            myVenda.ValorLucro = vl_lucro;
            myVenda.ValorTotal = vl_total;

            return myVenda.EditarVenda(myVenda);
        }

        public string ExcluirVenda(int id_venda)
        {
            myVenda.IDVenda = id_venda;

            return myVenda.ExcluirVenda(myVenda);
        }

        public string ValidarVenda()
        {
            return myVenda.ValidarVenda();
        }

        public DataTable ExibirVendaAno()
        {
            return myVenda.ExibirVendaAno();
        }

        public DataTable ExibirVendaMes()
        {
            return myVenda.ExibirVendaMes();
        }

        public DataTable BuscarVenda(DateTime dtInicioBuscar, DateTime dtFinalBuscar, string Textobuscar, int id_funcionario)
        {
            myVenda.DataInicioBuscar = dtInicioBuscar;
            myVenda.DataFinalBuscar = dtFinalBuscar;
            myVenda.TextoBuscar = Textobuscar;
            myVenda.IDFuncionario = id_funcionario;

            return myVenda.BuscarVenda(myVenda);
        }

        public DataTable BuscarDataVenda(DateTime dtInicioBuscar, DateTime dtFinalBuscar)
        {
            myVenda.DataInicioBuscar = dtInicioBuscar;
            myVenda.DataFinalBuscar = dtFinalBuscar;

            return myVenda.BuscarDataVenda(myVenda);
        }

        public DataTable BuscarClienteVenda(string Textobuscar)
        {
            myVenda.TextoBuscar = Textobuscar;

            return myVenda.BuscarClienteVenda(myVenda);
        }

        public DataTable BuscarFuncionarioVenda(int id_funcionario)
        {
            myVenda.IDFuncionario = id_funcionario;

            return myVenda.BuscarFuncionarioVenda(myVenda);
        }

        public DataTable BuscarDataClienteVenda(DateTime dtInicioBuscar, DateTime dtFinalBuscar, string Textobuscar)
        {
            myVenda.DataInicioBuscar = dtInicioBuscar;
            myVenda.DataFinalBuscar = dtFinalBuscar;
            myVenda.TextoBuscar = Textobuscar;

            return myVenda.BuscarDataClienteVenda(myVenda);
        }

        public DataTable BuscarDataFuncionarioVenda(DateTime dtInicioBuscar, DateTime dtFinalBuscar, int id_funcionario)
        {
            myVenda.DataInicioBuscar = dtInicioBuscar;
            myVenda.DataFinalBuscar = dtFinalBuscar;
            myVenda.IDFuncionario = id_funcionario;

            return myVenda.BuscarDataFuncionarioVenda(myVenda);
        }

        public DataTable BuscarFuncionarioClienteVenda(int id_funcionario, string Textobuscar)
        {
            myVenda.IDFuncionario = id_funcionario;
            myVenda.TextoBuscar = Textobuscar;

            return myVenda.BuscarFuncionarioClienteVenda(myVenda);
        }
    }
}
