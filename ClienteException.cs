using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    internal class ClienteException : ApplicationException
    {
        public ClienteException():base("Error al cargar, saldo excede al tope del cliente") { }
        public ClienteException(string message) : base(message) { }

        public ClienteException(string message, Exception innerException) : base(message, innerException) { }
    }
}
