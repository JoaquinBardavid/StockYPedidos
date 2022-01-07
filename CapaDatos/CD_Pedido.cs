using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Pedido
    {
        private CD_Conexion miConexion = new CD_Conexion();
        SqlDataReader leer;      
        SqlCommand comando = new SqlCommand();

        public DataTable mostrar()
        {
            DataTable tabla = new DataTable();
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = "SELECT * FROM Pedidos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            miConexion.cerrarConexion();
            return tabla;
        }

        public DataTable verPedido(Guid idPedido)
        {
            DataTable tabla = new DataTable();
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = $"SELECT p.*, d.cantidad FROM DetallePedidos d JOIN Productos p ON d.id_producto= p.id WHERE d.id_pedido= '{idPedido}'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            miConexion.cerrarConexion();
            return tabla;
        }
        
        public void agregarPedido(List<Tuple<Guid, int>> lista)
        {
            Guid idPedido = Guid.NewGuid();
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = $"INSERT INTO Pedidos VALUES('{idPedido}','{DateTime.Now.ToString("yyyy-MM-dd")}')";
            comando.ExecuteNonQuery();

            foreach (var tupla in lista)
            {
                Guid id = Guid.NewGuid();
                comando.CommandText = $"INSERT INTO DetallePedidos VALUES( '{tupla.Item1}', '{idPedido}', {tupla.Item2} ,'{id}')";
                comando.ExecuteNonQuery();
            }
            miConexion.cerrarConexion();
        }
        public void borrarPedido(Guid id)
        {
            comando.Connection = miConexion.abrirConexion();
            comando.CommandText = $"DELETE FROM DetallePedidos WHERE id_pedido = '{id}'";
            comando.ExecuteNonQuery();
            comando.CommandText = $"DELETE FROM Pedidos WHERE id = '{id}'";
            comando.ExecuteNonQuery();
            miConexion.cerrarConexion();
        }

    }
}
