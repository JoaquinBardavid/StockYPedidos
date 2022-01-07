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
    public class CN_Proveedor
    {
        CD_Proveedor gestorProveedorCD = new CD_Proveedor();
        public DataTable mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = gestorProveedorCD.mostrar();
            return tabla;
        }
        public void insertar(string id,string nombre)
        {
            gestorProveedorCD.insertar(int.Parse(id), nombre);
        }
        public DataTable buscar(string nombre)
        {
            DataTable tabla = new DataTable();
            tabla = gestorProveedorCD.buscar(nombre);
            return tabla;
        }
        public void modificar(string id, string nombre)
        {
            gestorProveedorCD.modificar(int.Parse(id), nombre);
        }
        public void borrar(string id)
        {
            gestorProveedorCD.borrar(int.Parse(id));
        }
    }
}
