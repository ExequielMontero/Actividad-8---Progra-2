using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_programacion.Models
{
    internal class Banco
    {
        public int CantidadClientes { get; set; }
        public int CantidadCuentas { get; set; }
        List<Cuenta> cuentas = new List<Cuenta>();
        List<Persona> clientes = new List<Persona>();

        public Cuenta this[int idx]
        {
            get
            {
                if (idx > cuentas.Count)
                {
                    throw new Exception();
                }
                return cuentas[idx];
            }

        }

        public Cuenta AgregarCuenta(int numerocuenta, int dni, string nombre)
        {
            Cuenta actual=null;
            Persona persona=null;
            if ((VerClientePorDni(dni) == null))
            {
                persona = new Persona(dni, nombre);
            }
            else
            {
                throw new IDni();
            }

            if (VerCuentaPorNumero(numerocuenta) == null)
            {
                actual = new Cuenta(numerocuenta, persona);
            }
            else
            {
                throw new INumero();
            }

            return actual;
        }


        public Cuenta VerCuentaPorNumero(int numeroCuenta)
        {
            cuentas.Sort();
            Cuenta nueva = new Cuenta(numeroCuenta, new Persona(0,""));
            int idx = cuentas.BinarySearch(nueva);
            if(idx >= 0)
            {
                return cuentas[idx];
            }
            return null;
        }

        public Persona VerClientePorDni(int dni)
        {
            clientes.Sort();
            Persona nueva = new Persona(dni, "");
            int idx = clientes.BinarySearch(nueva);
            if (idx >= 0)
            {
                return clientes[idx];
            }
            return null;
        }
    }
}
