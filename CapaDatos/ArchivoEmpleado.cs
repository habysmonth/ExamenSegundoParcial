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
    }
}
