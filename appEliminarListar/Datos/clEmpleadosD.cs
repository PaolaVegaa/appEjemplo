using appEliminarListar.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEliminarListar.Datos
{
    internal class clEmpleadosD
    {
        public List<clEmpleadosE> mtdListar()
        {
            string sql = "select * from empleado";
            clConexion objConexion = new clConexion();
            DataTable tblEmpleados = new DataTable();
            tblEmpleados = objConexion.mtdDesconectado(sql);

            List<clEmpleadosE> listaEmpleados = new List<clEmpleadosE>();

            int cantReg = tblEmpleados.Rows.Count;

            for (int i = 0; i < cantReg; i++)
            {
                clEmpleadosE objDatosEmpleado = new clEmpleadosE();
                objDatosEmpleado.idEmpleado = int.Parse(tblEmpleados.Rows[i]["idEmpleado"].ToString());
                objDatosEmpleado.nombre = tblEmpleados.Rows[i]["nombre"].ToString();
                objDatosEmpleado.apellido = tblEmpleados.Rows[i]["apellido"].ToString();
                objDatosEmpleado.cedula = tblEmpleados.Rows[i]["cedula"].ToString();
                objDatosEmpleado.telefono = tblEmpleados.Rows[i]["telefono"].ToString();
                objDatosEmpleado.correo = tblEmpleados.Rows[i]["correo"].ToString();
                listaEmpleados.Add(objDatosEmpleado);

            }

            return listaEmpleados;

        }

        public void mtdEliminarEmpleado(int idEmpleado)
        {
            string sql = "delete  from empleado where idEmpleado=" + idEmpleado + "";
            clConexion objConexion = new clConexion();
            objConexion.mtdConectado(sql);

        }
    }
}
