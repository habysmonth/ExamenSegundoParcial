using CapaEntidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ArchivoEmpleado
    {
        string ruta = "Archivo_Empleados.txt";

        public string Guardar(Empleados empleados)
        {
            StreamWriter sw = new StreamWriter(ruta, true);

            sw.WriteLine(empleados.ToString());
            sw.Close();

            return "Establecimiento registrado con éxito";
        }
        public List<Empleados> Mostrar()
        {
            List<Empleados> empleados = new List<Empleados>();

            string[] lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas) {

                string[] campos = linea.Split(';');

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

            return empleados;
        }
    }
}
