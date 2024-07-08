using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal abstract class Producto
    {
        protected string descripcion;
        protected double precioBaseA;
        public double CantidadKilos {  get; set; }

        public abstract double Precio(double kilo);
        public abstract string Descripcion();
    }
}
