
namespace CapaPresentacion
{
    partial class Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.txtIdPedidos = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnVerPedido = new System.Windows.Forms.Button();
            this.btnAgPedido = new System.Windows.Forms.Button();
            this.btnAniadirP = new System.Windows.Forms.Button();
            this.btnTerminarAgPedido = new System.Windows.Forms.Button();
            this.msOpciones = new System.Windows.Forms.MenuStrip();
            this.cambiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVolverAPedido = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnBorrarPedido = new System.Windows.Forms.Button();
            this.btnBorrarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.msOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeColumns = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 43);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(560, 435);
            this.dgvPedidos.TabIndex = 0;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtIdPedidos
            // 
            this.txtIdPedidos.Location = new System.Drawing.Point(676, 48);
            this.txtIdPedidos.Name = "txtIdPedidos";
            this.txtIdPedidos.ReadOnly = true;
            this.txtIdPedidos.Size = new System.Drawing.Size(140, 20);
            this.txtIdPedidos.TabIndex = 1;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(676, 86);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(140, 20);
            this.txtIdProducto.TabIndex = 2;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(652, 51);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(18, 13);
            this.lblIdPedido.TabIndex = 3;
            this.lblIdPedido.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detalles";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(676, 126);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(140, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(621, 129);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnVerPedido
            // 
            this.btnVerPedido.Location = new System.Drawing.Point(591, 152);
            this.btnVerPedido.Name = "btnVerPedido";
            this.btnVerPedido.Size = new System.Drawing.Size(100, 23);
            this.btnVerPedido.TabIndex = 7;
            this.btnVerPedido.Text = "Ver Pedido";
            this.btnVerPedido.UseVisualStyleBackColor = true;
            this.btnVerPedido.Click += new System.EventHandler(this.btnVerPedido_Click);
            // 
            // btnAgPedido
            // 
            this.btnAgPedido.Location = new System.Drawing.Point(715, 152);
            this.btnAgPedido.Name = "btnAgPedido";
            this.btnAgPedido.Size = new System.Drawing.Size(101, 23);
            this.btnAgPedido.TabIndex = 8;
            this.btnAgPedido.Text = "Nuevo Pedido";
            this.btnAgPedido.UseVisualStyleBackColor = true;
            this.btnAgPedido.Click += new System.EventHandler(this.btnAgPedido_Click);
            // 
            // btnAniadirP
            // 
            this.btnAniadirP.Enabled = false;
            this.btnAniadirP.Location = new System.Drawing.Point(591, 181);
            this.btnAniadirP.Name = "btnAniadirP";
            this.btnAniadirP.Size = new System.Drawing.Size(100, 23);
            this.btnAniadirP.TabIndex = 9;
            this.btnAniadirP.Text = "Agregar al Pedido";
            this.btnAniadirP.UseVisualStyleBackColor = true;
            this.btnAniadirP.Click += new System.EventHandler(this.btnAniadirP_Click);
            // 
            // btnTerminarAgPedido
            // 
            this.btnTerminarAgPedido.Enabled = false;
            this.btnTerminarAgPedido.Location = new System.Drawing.Point(715, 181);
            this.btnTerminarAgPedido.Name = "btnTerminarAgPedido";
            this.btnTerminarAgPedido.Size = new System.Drawing.Size(101, 23);
            this.btnTerminarAgPedido.TabIndex = 10;
            this.btnTerminarAgPedido.Text = "Terminar";
            this.btnTerminarAgPedido.UseVisualStyleBackColor = true;
            this.btnTerminarAgPedido.Click += new System.EventHandler(this.btnTerminarAgPedido_Click);
            // 
            // msOpciones
            // 
            this.msOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarToolStripMenuItem,
            this.creditosToolStripMenuItem});
            this.msOpciones.Location = new System.Drawing.Point(0, 0);
            this.msOpciones.Name = "msOpciones";
            this.msOpciones.Size = new System.Drawing.Size(828, 28);
            this.msOpciones.TabIndex = 11;
            this.msOpciones.Text = "Opciones";
            // 
            // cambiarToolStripMenuItem
            // 
            this.cambiarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.cambiarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarToolStripMenuItem.Name = "cambiarToolStripMenuItem";
            this.cambiarToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.cambiarToolStripMenuItem.Text = "Opciones";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.creditosToolStripMenuItem.Text = "Creditos";
            this.creditosToolStripMenuItem.Click += new System.EventHandler(this.creditosToolStripMenuItem_Click);
            // 
            // btnVolverAPedido
            // 
            this.btnVolverAPedido.Location = new System.Drawing.Point(591, 152);
            this.btnVolverAPedido.Name = "btnVolverAPedido";
            this.btnVolverAPedido.Size = new System.Drawing.Size(100, 23);
            this.btnVolverAPedido.TabIndex = 12;
            this.btnVolverAPedido.Text = "Volver";
            this.btnVolverAPedido.UseVisualStyleBackColor = true;
            this.btnVolverAPedido.Visible = false;
            this.btnVolverAPedido.Click += new System.EventHandler(this.btnVolverAPedido_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToResizeColumns = false;
            this.dgvLista.AllowUserToResizeRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(578, 251);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(238, 227);
            this.dgvLista.TabIndex = 13;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // btnBorrarPedido
            // 
            this.btnBorrarPedido.Location = new System.Drawing.Point(591, 210);
            this.btnBorrarPedido.Name = "btnBorrarPedido";
            this.btnBorrarPedido.Size = new System.Drawing.Size(101, 23);
            this.btnBorrarPedido.TabIndex = 14;
            this.btnBorrarPedido.Text = "Borrar Pedido";
            this.btnBorrarPedido.UseVisualStyleBackColor = true;
            this.btnBorrarPedido.Click += new System.EventHandler(this.btnBorrarPedido_Click);
            // 
            // btnBorrarProducto
            // 
            this.btnBorrarProducto.Enabled = false;
            this.btnBorrarProducto.Location = new System.Drawing.Point(715, 210);
            this.btnBorrarProducto.Name = "btnBorrarProducto";
            this.btnBorrarProducto.Size = new System.Drawing.Size(101, 23);
            this.btnBorrarProducto.TabIndex = 15;
            this.btnBorrarProducto.Text = "Borrar Producto";
            this.btnBorrarProducto.UseVisualStyleBackColor = true;
            this.btnBorrarProducto.Click += new System.EventHandler(this.btnBorrarProducto_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 490);
            this.Controls.Add(this.btnBorrarProducto);
            this.Controls.Add(this.btnBorrarPedido);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnVolverAPedido);
            this.Controls.Add(this.btnTerminarAgPedido);
            this.Controls.Add(this.btnAniadirP);
            this.Controls.Add(this.btnAgPedido);
            this.Controls.Add(this.btnVerPedido);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIdPedido);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtIdPedidos);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.msOpciones);
            this.MainMenuStrip = this.msOpciones;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.msOpciones.ResumeLayout(false);
            this.msOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.TextBox txtIdPedidos;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnVerPedido;
        private System.Windows.Forms.Button btnAgPedido;
        private System.Windows.Forms.Button btnAniadirP;
        private System.Windows.Forms.Button btnTerminarAgPedido;
        private System.Windows.Forms.MenuStrip msOpciones;
        private System.Windows.Forms.ToolStripMenuItem cambiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.Button btnVolverAPedido;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnBorrarPedido;
        private System.Windows.Forms.Button btnBorrarProducto;
    }
}