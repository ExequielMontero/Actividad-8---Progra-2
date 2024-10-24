using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_programacion.Models
{
        [Serializable]
    internal class Banco
    {
        public int CantidadClientes { get; set; }
        public int CantidadCuentas { get; set; }
        List<Cuenta> cuentas = new List<Cuenta>();
        List<Persona> clientes = new List<Persona>();
        public bool bandera;

        public Cuenta this[int idx]
        {
            get
            {
                if (idx > cuentas.Count)
                {
                    throw new Exception("Indice de cuenta no existente");
                }
                return cuentas[idx];
            }

        }

        public Cuenta AgregarCuenta(int numerocuenta, int dni, string nombre)
        {
            bandera = false;
            Cuenta actual = null;
            Persona persona = null;
            persona = VerClientePorDni(dni);
            actual = VerCuentaPorNumero(numerocuenta);
            if (actual == null)
            {
                if (persona == null)
                {
                    persona = new Persona(dni, nombre);
                }

                actual = new Cuenta(numerocuenta, persona);
                cuentas.Add(actual);
                CantidadCuentas++;
            }
            else
            {
                bandera = true;
            }

            return actual;
        }


        public Cuenta VerCuentaPorNumero(int numeroCuenta)
        {
            cuentas.Sort();
            Cuenta nueva = new Cuenta(numeroCuenta, null);
            int idx = cuentas.BinarySearch(nueva);
            if (idx >= 0)
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
