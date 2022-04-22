using appEliminarListar.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEliminarListar.Presentacion
{
    public partial class frmEmpleados : Form
    {
        int idEmpleado;

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clEmpleadosL objEmpleadosL = new clEmpleadosL();
            dgvEmpleados.DataSource = objEmpleadosL.mtdListarEmple();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Registros", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                idEmpleado = int.Parse(dgvEmpleados.CurrentRow.Cells[0].Value.ToString());

                clEmpleadosL objEmpleadosL = new clEmpleadosL();
                objEmpleadosL.mtdEliminarEmpleado(idEmpleado);


                MessageBox.Show("Registro eliminado");
                dgvEmpleados.DataSource = objEmpleadosL.mtdListarEmple();

            }

            else

            {

                MessageBox.Show("Registro no eliminado");

            }
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            frmInformeEmpleado objInformeEmpleados = new frmInformeEmpleado();
            objInformeEmpleados.Show();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
