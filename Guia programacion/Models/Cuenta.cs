using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_programacion.Models
{
    internal class Cuenta:IComparable
    {
        public Cuenta(int numero, Persona persona)
        {
            Numero = numero;
            Persona = persona;
        }

        public Cuenta(int numero, double saldo, DateTime fecha, Persona persona)
        {
            Numero = numero;
            Saldo = saldo;
            Fecha = fecha;
            Persona = persona;
        }

        public int Numero {  get; set; }
        public double Saldo { get; set; }
        public DateTime Fecha { get; set; }

       public Persona Persona { get; set; }

        public int CompareTo(object obj)
        {
            return this.Numero.CompareTo(Numero);
        }





    }
}
