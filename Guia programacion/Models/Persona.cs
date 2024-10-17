using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_programacion.Models
{
    internal class Persona:IComparable
    {
        public Persona(int dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }

        public int Dni { get; set; }
        public string Nombre { get; set; } 


        public int CompareTo(object obj)
        {
            Persona persona = obj as Persona;
            if(persona != null)
            {
                return this.Dni.CompareTo(persona.Dni);
            }
            
            return 1;
        }
    }
}
