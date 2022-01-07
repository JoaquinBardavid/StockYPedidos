using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        private CD_Conexion miConexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable mostrar()
        {
            DataTable tabla = new DataTable();
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = "SELECT * FROM Proveedores";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            miConexion.cerrarConexion();
            return tabla;
        }
        public void insertar(int id ,string nombre)
        {
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = $"INSERT INTO Proveedores VALUES( '{id}','{nombre}')";
            comando.ExecuteNonQuery();
            miConexion.cerrarConexion();
        }
        public DataTable buscar(string nombre)
        {
            DataTable tabla = new DataTable();
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = $"SELECT * FROM Proveedores WHERE nombre = '{nombre}'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            miConexion.cerrarConexion();
            return tabla;
        }
        public void modificar(int id, string nombre)
        {
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = $"UPDATE Proveedores SET nombre = '{nombre}' WHERE id = '{id}'";
            comando.ExecuteNonQuery();
            miConexion.cerrarConexion();
        }
        public void borrar(int id)
        {
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = $"DELETE FROM Proveedores WHERE id = '{id}'";
            comando.ExecuteNonQuery();
            miConexion.cerrarConexion();
        }
    }
}
