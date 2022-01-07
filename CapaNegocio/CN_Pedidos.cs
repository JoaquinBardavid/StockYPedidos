using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;


namespace CapaNegocio
{
    public class CN_Pedidos
    {
        CD_Pedido gestorPedidosCD = new CD_Pedido();
        public DataTable mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = gestorPedidosCD.mostrar();
            return tabla;
        }
        public DataTable verPedido(string idPedido)
        {
            DataTable tabla = gestorPedidosCD.verPedido(Guid.Parse(idPedido));
            return tabla;
        }
        public void agregarPedido(List<Tuple<Guid, int>> lista)
        {
            gestorPedidosCD.agregarPedido(lista);
        }
        public void borrarPedido(string id)
        {
            gestorPedidosCD.borrarPedido(Guid.Parse(id));
        }
    }
}
