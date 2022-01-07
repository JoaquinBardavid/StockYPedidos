using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private string cadenaConexion;

        public SqlConnection conectarDB;

        public CD_Conexion()
        {
            cadenaConexion = "Data Source=DESKTOP-JR30H5O\\SQLEXPRESS;Initial Catalog=ParcialLab; Integrated Security=True";
            conectarDB = new SqlConnection();
            conectarDB.ConnectionString = cadenaConexion;
        }
        public SqlConnection abrirConexion()
        {
            conectarDB.Open();
            return conectarDB;
        }
        public SqlConnection cerrarConexion()
        {
            conectarDB.Close();
            return conectarDB;
        }
        public SqlConnection getConexion()
        {
            return conectarDB;
        }

    }
}
