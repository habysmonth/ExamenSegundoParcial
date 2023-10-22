using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ImplementacionServicioEmpleados : IServicioEmpleados
    {
        ArchivoEmpleado archivoEmpleado = new ArchivoEmpleado();

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
    }
}
