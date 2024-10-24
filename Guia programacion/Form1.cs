using Guia_programacion.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_programacion
{
    public partial class Form1 : Form
    {
        Banco banco;
        int btnver = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {


            lbVer.Items.Clear();

            lbVer.Items.Add($"Número cuenta\tNombre\t\tSaldo");
            lbVer.Items.Add(new string('-', 80));

            if (banco.CantidadCuentas > 0)
            {
                Cuenta cuenta;
                for (int idx = 0; idx < banco.CantidadCuentas; idx++)
                {
                    cuenta = banco[idx];
                    lbVer.Items.Add($"{cuenta.Numero}\t{cuenta.Persona.Nombre}\t\t{cuenta.Saldo:f2}");
                }
            }
            else
            {
                if (btnver != 0)
                {
                    MessageBox.Show("No hay cuentas cargadas en el sistema para mostrar");
                }
            }


        }



        private void btnImportar_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Title = "Buscar archivo";
            openFileDialog1.Filter = "Archivos de texto .txt|*.txt|Todos los archivos *.*|*.*|Archivos separados por coma .CSV|*.CSV";
            openFileDialog1.DefaultExt = "CSV";
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.FileName = null;
            StreamReader leer = null;
            FileStream flujo = null;
            string[] partes = new string[3];
            string linea;
            string nombre;
            int dni;
            int numerocuenta;
            double saldo;
            Cuenta cuenta;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog1.FileName))
                    {
                        flujo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                        leer = new StreamReader(flujo);
                        leer.ReadLine();
                        while (leer.EndOfStream == false)
                        {
                            linea = leer.ReadLine();
                            partes = linea.Split(';');
                            nombre = partes[1];
                            dni = Convert.ToInt32(partes[0].Trim());
                            numerocuenta = Convert.ToInt32(partes[2].Trim());
                            saldo = Convert.ToDouble(partes[3].Trim());
                            cuenta = banco.AgregarCuenta(numerocuenta, dni, nombre);
                            cuenta.Saldo += Convert.ToInt32(partes[3]);

                        }
                        if (banco.bandera)
                        {
                            throw new Exception("En el archivo hay numeros de cuentas repetidas, por lo que solo se cargara la primer cuenta que este primera en la lista con ese numero");
                        }
                        else
                        {
                            MessageBox.Show("Cuentas cargadas con exito");
                        }
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show($"{E.Message}");
            }
            finally
            {
                if (leer != null)
                {
                    leer.Close();
                }

                if (flujo != null)
                {
                    flujo.Close();
                }
                btnLimpiar.Enabled = true;
                btnVer.Enabled = true;
                btnVer.PerformClick();
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "Ejercicio1.txt");
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = null;
            if (File.Exists(path))
            {
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    banco = (Banco)bf.Deserialize(fs);
                }
                catch
                {

                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }
            if (banco == null)
            {
                banco = new Banco();
            }
            btnVer.PerformClick();
            btnver++;
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Guardar archivo .txt";
            saveFileDialog1.Filter = "Archivos de texto .txt|*.txt|Archivos separados por coma .CSV|*.CSV";
            saveFileDialog1.DefaultExt = "CSV";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.FileName = "Cuentas";
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    string linea = $"DNI; nombre; numero de cuenta; saldo";
                    sw.WriteLine(linea);
                    for (int i = 0; i < banco.CantidadCuentas; i++)
                    {
                        Cuenta actual = banco[i];
                        if (actual.Saldo >= 10000)
                        {
                            sw.WriteLine($"{actual.Persona.Dni};{actual.Persona.Nombre};{actual.Numero};{actual.Saldo}");
                        }

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Excepcion desconocida");
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
                if (fs != null)
                {
                    sw.Close();
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            banco = new Banco();
            btnLimpiar.Enabled = false;
            MessageBox.Show("Cuentas limpiadas internamente con exito");
            btnVer.PerformClick();
            btnVer.Enabled = false;
        }

        private void btnResguardar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbVer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            string path = Path.Combine(Application.StartupPath, "Ejercicio1.txt");
            FileStream fs = null;
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                bf.Serialize(fs, banco);
            }
            catch (Exception)
            {
                MessageBox.Show($"Error al querer persistir los datos");
            }
            finally
            {
                if (fs == null)
                {
                    fs.Close();
                }
            }
        }
    }
}
