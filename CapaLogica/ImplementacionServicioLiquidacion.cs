using CapaEntidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ImplementacionServicioLiquidacion : IServiciosLiquidacion
    {
        string ruta = "Archivo_Liquidaciones.txt";

        public List<Liquidacion> VerLiquidaciones(int mess)
        {
            List<Liquidacion> liquidaciones = new List<Liquidacion>();

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (var linea in lineas)
                {

                    string[] campos = linea.Split(';');

                    if (campos[2] == mess.ToString())
                    {
                        if (campos.Length == 8)
                        {
                            if (int.TryParse(campos[0], out int id) &&
                                int.TryParse(campos[1], out int año) &&
                                int.TryParse(campos[2], out int mes) &&
                                float.TryParse(campos[3], out float tsalario) &&
                                float.TryParse(campos[4], out float tsalud) &&
                                float.TryParse(campos[5], out float tpension) &&
                                float.TryParse(campos[6], out float tauxtrans) &&
                                float.TryParse(campos[7], out float total))
                            {


                                Liquidacion liquidacion = new Liquidacion
                                {

                                    Id = id,
                                    Año = año,
                                    Mes = mes,
                                    TotalSalario = tsalario,
                                    TotalSalud = tsalud,
                                    TotalPension = tpension,
                                    TotalAuxTrans = tauxtrans,
                                    Total = total

                                };

                                liquidaciones.Add(liquidacion);
                            }
                        }
                    }
                    else
                    {
                        return null;
                    }


                }

                return liquidaciones;
            }
            else
            {
                return null;
            }
            
        }
    }
}
