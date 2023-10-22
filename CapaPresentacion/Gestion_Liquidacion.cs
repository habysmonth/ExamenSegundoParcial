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
            
            int mess = int.Parse(txtBuscarLiquidacion.Text);
            servicioLiquidacion.VerLiquidaciones(mess);

            if (servicioLiquidacion.VerLiquidaciones(mess) == null)
            {
                Liquidar liquidar = new Liquidar();
                liquidar.Show();
            }
            else
            {
                dtgLiquidaciones.DataSource = servicioLiquidacion.VerLiquidaciones(mess);
            }
        }
    }
}
