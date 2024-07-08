using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeerdrunFinalProg2
{
    [Serializable]
    internal class ClienteCuenta: IComparable ,ISavable
    {
        public string Nombre {  get; set; }

        public double SaldoCuenta {  get; set; }
        public double Tope {  get; set; }

        public long Cuit {  get; set; }
        public Queue<Pedido> listaPedidos;

        public ClienteCuenta(string nombre, long cuit, double topeCuenta)
        {
            this.Nombre = nombre;
            this.Cuit = cuit;
            this.Tope = topeCuenta;
            listaPedidos = new Queue<Pedido>();
        }
        public double AgregarPedido(Pedido nuevoPedido)
        {
            double valor = -1;
            if (nuevoPedido.Valor + SaldoCuenta < Tope)
            {
                listaPedidos.Enqueue(nuevoPedido);
                SaldoCuenta += nuevoPedido.Valor;
                valor = nuevoPedido.Valor;
            }
            return valor;
        }
        public bool AgregarPago(double monto)
        {
            bool agregado = false;
            if((SaldoCuenta - monto)< 0)
            {
                SaldoCuenta -= monto;
                agregado = true;
            }    
            return agregado;
        }
        public void Escribir ( object obj)
        {

        }
        public int CompareTo(object obj)
        {
            return this.Cuit.CompareTo(((ClienteCuenta)obj).Cuit);
        }
    }
}
