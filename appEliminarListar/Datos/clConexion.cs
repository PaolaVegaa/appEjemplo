using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEliminarListar.Datos
{
    internal class clConexion
    {
        SqlConnection conexion;
        public clConexion()
        {
            conexion = new SqlConnection("Data Source=SOGAPRRBCFSD538;Initial Catalog=dbManageYourBusiness;Integrated Security=True");
            conexion.Open();
        }

        public DataTable mtdDesconectado(string sql) //select
        {
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            conexion.Close();
            return tblDatos;
        }

        public int mtdConectado(string sql) //insert, update, delete
        {
            SqlCommand comando = new SqlCommand(sql, conexion);
            int filasAfectadas = comando.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;
        }
    }
}
