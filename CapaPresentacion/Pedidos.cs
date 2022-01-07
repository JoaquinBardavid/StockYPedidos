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
    public partial class Pedidos : Form
    {
        CN_Pedidos objetoCN_pedido = new CN_Pedidos();
        CN_Productos objetoCN_producto = new CN_Productos();
        List<Tuple<Guid,int>> lista = new List<Tuple<Guid, int>>();
        public Pedidos()
        {
            InitializeComponent();
            dgvPedidos.DataSource = objetoCN_pedido.mostrar();
            txtIdProducto.Text = dgvPedidos.Rows[0].Cells[1].Value.ToString();
            txtIdPedidos.Text = dgvPedidos.Rows[0].Cells[0].Value.ToString();
            ajustar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProducto.Text = dgvPedidos.CurrentRow.Cells[1].Value.ToString();
            txtIdPedidos.Text = dgvPedidos.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnVerPedido_Click(object sender, EventArgs e)
        {

            if (txtIdPedidos.Text == "")
            {
                MessageBox.Show("Ingrese un valor valido");
            }
            else
            {
                btnVerPedido.Hide();
                btnVolverAPedido.Show();
                btnBorrarPedido.Enabled = false;
                dgvPedidos.DataSource = objetoCN_pedido.verPedido(txtIdPedidos.Text);
                ajustar();
                blanquear();
            }

        }
        private void btnVolverAPedido_Click(object sender, EventArgs e)
        {
            btnVerPedido.Show();
            btnVolverAPedido.Hide();
            btnBorrarPedido.Enabled = true;
            btnAniadirP.Enabled = false;
            btnTerminarAgPedido.Enabled = false;
            dgvPedidos.DataSource = objetoCN_pedido.mostrar();
            ajustar();

        }
        private void btnAgPedido_Click(object sender, EventArgs e)
        {
            btnVolverAPedido.Show();
            btnAniadirP.Enabled = true;
            btnTerminarAgPedido.Enabled = true;
            txtCantidad.ReadOnly = false;
            dgvPedidos.DataSource = objetoCN_producto.mostrar();
            ajustar();
            blanquear();
        }

        private void btnAniadirP_Click(object sender, EventArgs e)
        {

            if (txtCantidad.Text == "" || dgvPedidos.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Ingrese un valor valido");
            }
            else
            {
                btnBorrarProducto.Enabled = true;
                var detalle = new Tuple<Guid, int>(Guid.Parse(dgvPedidos.CurrentRow.Cells[0].Value.ToString()), int.Parse(txtCantidad.Text));
                lista.Add(detalle);
                MessageBox.Show("agregaste con exito los elementos a tu pedido");
                dgvLista.DataSource = lista.Select(t => new {
                    id = t.Item1,
                    cantidad = t.Item2
                }).ToList();
                foreach (DataGridViewColumn column in dgvLista.Columns)
                {
                    column.Width = (dgvLista.Width - 43) / dgvLista.Columns.Count;
                }
                blanquear();
            }

        }

        private void btnTerminarAgPedido_Click(object sender, EventArgs e)
        {
            btnVolverAPedido.Hide();
            btnVerPedido.Show();
            btnAniadirP.Enabled = false;
            btnTerminarAgPedido.Enabled = false;
            btnBorrarProducto.Enabled = false;
            txtCantidad.ReadOnly = true;
            lista = new List<Tuple<Guid, int>>();
            dgvLista.DataSource = lista.Select(t => new {
                id = t.Item1,
                cantidad = t.Item2
            }).ToList();
            objetoCN_pedido.agregarPedido(lista);
            dgvPedidos.DataSource = objetoCN_pedido.mostrar();
            ajustar();
            blanquear();

        }
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos pedidos = new Productos();
            pedidos.Show();
            this.Hide();
        }
        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.Show();
            this.Hide();
        }

        private void btnBorrarPedido_Click(object sender, EventArgs e)
        {
            if (txtIdPedidos.Text == "" )
            {
                MessageBox.Show("Ingrese un valor valido");
            }
            else
            {
                objetoCN_pedido.borrarPedido(txtIdPedidos.Text);
                CN_Pedidos objetoCN1 = new CN_Pedidos();
                dgvPedidos.DataSource = objetoCN1.mostrar();
                ajustar();
                blanquear();
            }
        }
        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            if (txtIdPedidos.Text == "")
            {
                MessageBox.Show("Ingrese un valor valido");
            }
            else
            {
                var item = lista.First(i => i.Item1 == Guid.Parse(txtIdPedidos.Text));
                lista.Remove(item);
                dgvLista.DataSource = lista.Select(t => new {
                    id = t.Item1,
                    cantidad = t.Item2
                }).ToList();
                blanquear();
            }
        }

        public void ajustar()
        {
            foreach (DataGridViewColumn column in dgvPedidos.Columns)
            {
                column.Width = (dgvPedidos.Width - 43) / dgvPedidos.Columns.Count;
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProducto.Text = dgvLista.CurrentRow.Cells[1].Value.ToString();
            txtIdPedidos.Text = dgvLista.CurrentRow.Cells[0].Value.ToString();
        }
        public void blanquear()
        {
            txtCantidad.Text = "";
            txtIdPedidos.Text = "";
            txtIdProducto.Text = "";
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide();
        }
    }
}
