using CapaEntidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ArchivoLiquidacion
    {
        string ruta = "Archivo_Liquidaciones.txt";

        public string Guardar(Liquidacion liquidacion)
        {
            StreamWriter sw = new StreamWriter(ruta, true);

            sw.WriteLine(liquidacion.ToString());
            sw.Close();

            return "Establecimiento registrado con éxito";
        }
    }
}
