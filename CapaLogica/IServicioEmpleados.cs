using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public interface IServicioEmpleados
    {
        string Guardar(Empleados empleados);
        bool Buscar(int refer);
        List<Empleados> Leer();
        List<Empleados> VerPorNombre(string name);
        List<Empleados> VerPorEstado(string estatus);
    }
}
