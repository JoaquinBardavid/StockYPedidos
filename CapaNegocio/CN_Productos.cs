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
    public class CN_Productos
    {
        CD_Productos gestorProductosCD = new CD_Productos();

        public DataTable mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = gestorProductosCD.mostrar();
            return tabla;
        }
        public void insertar(string nombre, string descripcion, string precio, string idProveedor)
        {
            gestorProductosCD.insertar(nombre, descripcion,float.Parse(precio),Int32.Parse(idProveedor));
        }
        public DataTable buscar(string nombre)
        {
            DataTable tabla = new DataTable();
            tabla = gestorProductosCD.buscar(nombre);
            return tabla;
        }
        public void modificar(string idProducto, string nombre, string descripcion, string precio, string idProveedor)
        {
            gestorProductosCD.modificar(idProducto,nombre, descripcion, float.Parse(precio), Int32.Parse(idProveedor));
        }
        public void borrar(string idProducto)
        {
            gestorProductosCD.borrar(idProducto);
        }
    }
}
