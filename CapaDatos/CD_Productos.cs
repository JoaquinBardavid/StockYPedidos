using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion miConexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();       

        public DataTable mostrar()
        {
            DataTable tabla = new DataTable();
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = "SELECT * FROM Productos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            miConexion.cerrarConexion();
            return tabla;
        }
        public void insertar(string nombre, string descripcion, float precio, int idProveedor)
        {
            Guid id = Guid.NewGuid();
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = $"INSERT INTO Productos VALUES( '{id}',' {nombre} ',' {descripcion}','{precio}','{idProveedor}')";
            comando.ExecuteNonQuery();
            miConexion.cerrarConexion();
        }
        public DataTable buscar(string nombre)
        {
            DataTable tabla = new DataTable();
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = $"SELECT * FROM Productos WHERE nombre = '{nombre}'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            miConexion.cerrarConexion();
            return tabla;
        }
        public void modificar(string idProducto ,string nombre, string descripcion, float precio, int idProveedor)
        {
            Guid id = Guid.Parse(idProducto);
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = $"UPDATE Productos SET nombre= '{nombre}', descripcion= '{descripcion}', precio= '{precio}', id_Proveedor= '{idProveedor}' WHERE id = '{id}'";
            comando.ExecuteNonQuery();
            miConexion.cerrarConexion();
        }
        public void borrar(string idProducto)
        {
            Guid id = Guid.Parse(idProducto);
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = $"DELETE FROM Productos WHERE id = '{id}'";
            comando.ExecuteNonQuery();
            miConexion.cerrarConexion();
        }
    }
}
