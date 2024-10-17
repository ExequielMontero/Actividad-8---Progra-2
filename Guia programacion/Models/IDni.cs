using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_programacion.Models
{
    class IDni : ApplicationException
    {
        public IDni():base("Dni ya existente")
        {
        }

        public IDni(string message) : base(message)
        {
        }

        public IDni(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
