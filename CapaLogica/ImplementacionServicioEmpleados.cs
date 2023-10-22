using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapaLogica
{
    public class ImplementacionServicioEmpleados : IServicioEmpleados
    {
        ArchivoEmpleado archivoEmpleado = new ArchivoEmpleado();
        string ruta = "Archivo_Empleados.txt";
        public bool Buscar(int refer)
        {
            string[] lineas = File.ReadAllLines("Archivo_Empleados.txt");

            foreach (var linea in lineas)
            {
                string[] campos = linea.Split(';');

                if (campos[0] == refer.ToString())
                {
                    return true;
                }

            }

            return false;
        }
        public string Guardar(Empleados empleados)
        {
            try
            {
                archivoEmpleado.Guardar(empleados);
                return "Producto Registrado con éxito";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public List<Empleados> Leer()
        {
            try
            {
                return archivoEmpleado.Mostrar();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
                return new List<Empleados>();
            }
        }
        public List<Empleados> VerPorEstado(string estatus)
        {
            List<Empleados> empleados = new List<Empleados>();

            string[] lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {

                string[] campos = linea.Split(';');

                if (campos[3] == estatus)
                {
                    if (campos.Length == 4)
                    {
                        if (int.TryParse(campos[0], out int id) &&
                            double.TryParse(campos[2], out double salario))
                        {
                            string nombre = campos[1];
                            string estado = campos[3];

                            Empleados empleado = new Empleados
                            {
                                Identificacion = id,
                                Nombre = nombre,
                                SalarioBase = salario,
                                Estado = estado

                            };

                            empleados.Add(empleado);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No hay coincidencias");
                }


            }

            return empleados;
        }
        public List<Empleados> VerPorNombre(string name)
        {
            List<Empleados> empleados = new List<Empleados>();

            string[] lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {

                string[] campos = linea.Split(';');

                if (campos[1] == name)
                {
                    if (campos.Length == 4)
                    {
                        if (int.TryParse(campos[0], out int id) &&
                            double.TryParse(campos[2], out double salario))
                        {
                            string nombre = campos[1];
                            string estado = campos[3];

                            Empleados empleado = new Empleados
                            {
                                Identificacion = id,
                                Nombre = nombre,
                                SalarioBase = salario,
                                Estado = estado

                            };

                            empleados.Add(empleado);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No hay coincidencias");
                }

                
            }

            return empleados;
        }
    }
}
