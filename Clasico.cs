using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal class Clasico : Producto
    {
        public Clasico(double precioA, string detalle)
        {

        }
        public override string Descripcion()
        {
            throw new NotImplementedException();
        }

        public override double Precio(double kilo)
        {
            throw new NotImplementedException();
        }
    }
}
