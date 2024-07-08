using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal class GestionVenta
    {
        private Empresa dueño;
        private double montoFacturado;
        private readonly DateTime incioOperaciones;
        public List<Producto> lista;
        public ArrayList listaClientes;

        public GestionVenta(long cuit, string razonSocial)
        {
            dueño = new Empresa(cuit, razonSocial);
            this.incioOperaciones = DateTime.Now;
            lista = new List<Producto>();
            montoFacturado = 0;
            listaClientes = new ArrayList();
        }

        public void AgregarCliente(ClienteCuenta unCliente)
        {

        }

        public ClienteCuenta BuscarCLiente(long cuit)
        {
            return null;
        }

        public Pedido GenerarPedido(int nro, List<Producto> lista)
        {
            return null;
        }

        public bool SumarPedido(ClienteCuenta cliente, Pedido nuevoPedido)
        {
            bool sumado = false;
            int pos = listaClientes.BinarySearch(cliente);
            if (pos == -1)
            {
                if (((ClienteCuenta)listaClientes[pos]).AgregarPedido(nuevoPedido) != -1)
                    sumado = true;
            }

            return sumado;
        }

        public bool AgregarPago(long cuit, double monto)
        {
            bool agregado = false;
            ClienteCuenta buscado = new ClienteCuenta("", cuit, 0);
            int pos = listaClientes.BinarySearch(buscado);
            if (pos != -1)
                agregado = ((ClienteCuenta)listaClientes[pos]).AgregarPago(monto);
            return agregado;
        }

        public double VerSaldo(long cuit)
        {
            double saldo = -1;
            ClienteCuenta buscado = new ClienteCuenta("", cuit, 0);
            int pos = listaClientes.BinarySearch(buscado);
            if (pos != -1)
            {
                saldo = ((ClienteCuenta)listaClientes[pos]).SaldoCuenta;
            }
            return saldo;
        }
    }
}
