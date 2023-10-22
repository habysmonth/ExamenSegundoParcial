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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class Gestion_Empleados : Form
    {
        ImplementacionServicioEmpleados servicioEmpleados = new ImplementacionServicioEmpleados();
        public Gestion_Empleados()
        {
            InitializeComponent();
        }

        private void txtRNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se ingrese el carácter no deseado
            }
        }
        private void txtRIdentifiacion_Validating(object sender, CancelEventArgs e)
        {
            
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registroEmpleados();
        }
        public void registroEmpleados()
        {
            if (string.IsNullOrWhiteSpace(txtRIdentifiacion.Text))
            {
                MessageBox.Show("El campo de Identificación no puede estar vacío.");
            }
            else if (string.IsNullOrWhiteSpace(txtRNombre.Text))
            {
                MessageBox.Show("El campo de Nombre no puede estar vacío.");
            }
            else if (string.IsNullOrWhiteSpace(txtRSalarioBase.Text))
            {
                MessageBox.Show("El campo de Salario Base no puede estar vacío.");
            }
            else if (string.IsNullOrWhiteSpace(cboEstado.Text))
            {
                MessageBox.Show("El campo de Estados no puede estar vacío");
            }
            else
            {
                int id;
                string nombre, estado;
                double salario;

                id = int.Parse(txtRIdentifiacion.Text);
                nombre = txtRNombre.Text;
                salario = double.Parse(txtRSalarioBase.Text);
                estado = cboEstado.Text;

                bool verificar = servicioEmpleados.Buscar(id);

                if (verificar == true)
                {
                    MessageBox.Show("El empleado ya existe en la base de datos");
                }
                else
                {
                    servicioEmpleados.Guardar(new Empleados(id, nombre, salario, estado));
                }

            }
        }
        private void txtRSalarioBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que se ingrese el carácter no deseado
            }
        }
        
    }
}
