using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Productos : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        string idProducto;
        public Productos()
        {
            InitializeComponent();
            dgvProductos.DataSource = objetoCN.mostrar();
            ajustar();
        }

        private void btnInsertarDatos_Click(object sender, EventArgs e)
        {
            objetoCN.insertar(txtNombre.Text, txtDescripcion.Text, txtPrecio.Text, txtId.Text);
            CN_Productos objetoCN1 = new CN_Productos();
            dgvProductos.DataSource = objetoCN1.mostrar();
            ajustar();
        }
        private void txtBuscarDatos_Click(object sender, EventArgs e)
        {
            CN_Productos objetoCN1 = new CN_Productos();
            dgvProductos.DataSource = objetoCN1.buscar(txtNombre.Text);
            ajustar();
        }
        private void btnModificarD_Click(object sender, EventArgs e)
        {
            objetoCN.modificar(idProducto,txtNombre.Text, txtDescripcion.Text, txtPrecio.Text, txtId.Text);
            CN_Productos objetoCN1 = new CN_Productos();
            dgvProductos.DataSource = objetoCN1.mostrar();
            ajustar();
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idProducto = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            txtId.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            objetoCN.borrar(idProducto);
            CN_Productos objetoCN1 = new CN_Productos();
            dgvProductos.DataSource = objetoCN1.mostrar();
            ajustar();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.Show();
            this.Hide();
        }
        public void ajustar()
        {
            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                column.Width = (dgvProductos.Width - 43) / dgvProductos.Columns.Count;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = objetoCN.mostrar();
            ajustar();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide();
        }
    }
}
