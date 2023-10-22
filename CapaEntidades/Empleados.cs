using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Empleados
    {
        public Empleados(int identificacion, string nombre, double salarioBase, string estado)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            SalarioBase = salarioBase;
            Estado = estado;
        }

        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public double SalarioBase { get; set; }
        public string Estado { get; set; }

        public Empleados() { }

        public override string ToString()
        {
            return $"{Identificacion};{Nombre};{SalarioBase};{Estado}";
        }
    }
}
