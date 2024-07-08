using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal class Pedido : ISavable
    {
        public double Valor { get; set; }
        public int Nro { get; set; }
        public DateTime FechaHora { get; set; }
        public string Detalle { get; set; }


        public Pedido(int nro, List<Producto> lista)
        {
            Nro = nro;
            FechaHora = DateTime.Now;
            Valor = 0;
            foreach (Producto p in lista)
            {
                Valor += p.Precio(p.CantidadKilos);
            }
        }

        public string VerResumen()
        {
            return null;
        }
        public void Escribir(object obj)
        {

        }
    }
}
