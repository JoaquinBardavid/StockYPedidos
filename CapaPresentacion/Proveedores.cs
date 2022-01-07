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
    public partial class Proveedores : Form
    {
        CN_Proveedor objetoCN = new CN_Proveedor();
        public Proveedores()
        {
            InitializeComponent();
            dgvProveedores.DataSource = objetoCN.mostrar();
            ajustar();
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
        }
        public void ajustar()
        {
            foreach (DataGridViewColumn column in dgvProveedores.Columns)
            {
                column.Width = (dgvProveedores.Width - 43) / dgvProveedores.Columns.Count;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = objetoCN.mostrar();
            ajustar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CN_Proveedor objetoCN1 = new CN_Proveedor();
            dgvProveedores.DataSource = objetoCN1.buscar(txtNombre.Text);
            ajustar();
        }

        private void btnModDatos_Click(object sender, EventArgs e)
        {
            objetoCN.modificar(txtId.Text, txtNombre.Text);
            CN_Proveedor objetoCN1 = new CN_Proveedor();
            dgvProveedores.DataSource = objetoCN1.mostrar();
            ajustar();
        }

        private void btnAggProveedor_Click(object sender, EventArgs e)
        {
            objetoCN.insertar(txtId.Text, txtNombre.Text );
            CN_Proveedor objetoCN1 = new CN_Proveedor();
            dgvProveedores.DataSource = objetoCN1.mostrar();
            ajustar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            objetoCN.borrar(txtId.Text);
            CN_Proveedor objetoCN1 = new CN_Proveedor();
            dgvProveedores.DataSource = objetoCN1.mostrar();
            ajustar();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Hide();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
