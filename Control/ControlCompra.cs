using Model;
using System;
using System.Data;

namespace Control
{
    public class ControlCompra
    {
        ModelCompra myCompra = new ModelCompra();

        public string InserirCompra()
        {
            return myCompra.InserirCompra();
        }

        public string FinalizarCompra(int id_compra, double vl_compra)
        {
            myCompra.IDCompra = id_compra;
            myCompra.ValorCompra = vl_compra;

            return myCompra.FinalizarCompra(myCompra);
        }

        public string ExcluirCompra(int id_compra)
        {
            myCompra.IDCompra = id_compra;

            return myCompra.ExcluirCompra(myCompra);
        }

        public DataTable ExibirCompra()
        {
            return myCompra.ExibirCompra();
        }

        public DataTable BuscarCompra(DateTime dtInicioBuscar, DateTime dtFinalBuscar, string Textobuscar)
        {
            myCompra.DataInicioBuscar = dtInicioBuscar;
            myCompra.DataFinalBuscar = dtFinalBuscar;
            myCompra.TextoBuscar = Textobuscar;

            return myCompra.BuscarCompra(myCompra);
        }

        public DataTable BuscarDataCompra(DateTime dtInicioBuscar, DateTime dtFinalBuscar)
        {
            myCompra.DataInicioBuscar = dtInicioBuscar;
            myCompra.DataFinalBuscar = dtFinalBuscar;

            return myCompra.BuscarDataCompra(myCompra);
        }

        public DataTable BuscarProdutoCompra(string Textobuscar)
        {
            myCompra.TextoBuscar = Textobuscar;

            return myCompra.BuscarProdutoCompra(myCompra);
        }

        public string ValidarCompra()
        {
            return myCompra.ValidarCompra();
        }
    }
}
