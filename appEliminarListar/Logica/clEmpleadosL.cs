using appEliminarListar.Datos;
using appEliminarListar.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEliminarListar.Logica
{
    internal class clEmpleadosL
    {
        public List<clEmpleadosE> mtdListarEmple()
        {
            clEmpleadosD objEmpleadosD = new clEmpleadosD();
            List<clEmpleadosE> listaEmpleados = new List<clEmpleadosE>();
            listaEmpleados = objEmpleadosD.mtdListar();
            return listaEmpleados;

        }

        public void mtdEliminarEmpleado(int idEmpleado)
        {
            clEmpleadosD objEmpleadoD = new clEmpleadosD();
            objEmpleadoD.mtdEliminarEmpleado(idEmpleado);

        }
    }
}
