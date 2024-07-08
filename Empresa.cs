using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal class Empresa
    {
        private long cuit;
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }

        public Empresa(long cuit, string razonSocial)
        {
            this.cuit = cuit;
            RazonSocial = razonSocial;
        }
        public override string ToString()
        {
            return "Razon social: " + RazonSocial + " Cuit: " + this.cuit + " Direccion: " + Direccion ;
        }
    }
}
