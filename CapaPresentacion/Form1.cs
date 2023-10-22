using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Gestion_Empleados gestion_Empleados = new Gestion_Empleados();
            gestion_Empleados.ShowDialog();
        }

        private void btnLiquidacion_Click(object sender, EventArgs e)
        {
            Gestion_Liquidacion gestion_Liquidacion = new Gestion_Liquidacion();
            gestion_Liquidacion.ShowDialog();
        }
    }
}
