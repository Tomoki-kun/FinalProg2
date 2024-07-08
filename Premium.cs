using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FinalProg2
{
    [Serializable]
    internal class Premium:Producto
    {
        public Premium(string descripcion, double precioA, double precioB)
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
