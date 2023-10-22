using CapaLogica;
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
    public partial class Gestion_Liquidacion : Form
    {
        ImplementacionServicioLiquidacion servicioLiquidacion = new ImplementacionServicioLiquidacion();
        public Gestion_Liquidacion()
        {
            InitializeComponent();
        }

        private void btnBuscarLiquidacion_Click(object sender, EventArgs e)
        {
            int idFactura = int.Parse(txtBuscarLiquidacion.Text);
            servicioLiquidacion.VerLiquidaciones(idFactura);


        }
    }
}
