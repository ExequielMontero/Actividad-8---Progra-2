using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_programacion.Models
{
    class INumero : ApplicationException
    {
        public INumero():base("Numero de cuenta ya existente")
        {
        }

        public INumero(string message) : base(message)
        {
        }

        public INumero(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
