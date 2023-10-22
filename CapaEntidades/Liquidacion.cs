using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Liquidacion
    {
        public Liquidacion(int id, int año, int mes,
            float totalSalario, float totalSalud, float totalPension, float totalAuxTrans, float total)
        {
            Id = id;
            Año = año;
            Mes = mes;
            TotalSalario = totalSalario;
            TotalSalud = totalSalud;
            TotalPension = totalPension;
            TotalAuxTrans = totalAuxTrans;
            Total = total;
        }

        public Liquidacion() { }
        public int Id { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public float TotalSalario { get; set; }
        public float TotalSalud { get; set; }
        public float TotalPension { get; set; }
        public float TotalAuxTrans { get; set; }
        public float Total { get; set; }

        public override string ToString()
        {
            return $"{Id};{Año};{Mes};{TotalSalario};{TotalSalud};{TotalPension};{TotalAuxTrans};{Total}";
        }

    }
}
