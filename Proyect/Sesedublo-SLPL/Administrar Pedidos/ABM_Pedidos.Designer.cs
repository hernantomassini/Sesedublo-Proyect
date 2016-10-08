namespace Sesedublo_SLPL.Administrar_Pedidos
{
    partial class ABM_Pedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PedidosDGV = new MetroFramework.Controls.MetroGrid();
            this.IDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtrasTile = new MetroFramework.Controls.MetroTile();
            this.AgregarPedidoTile = new MetroFramework.Controls.MetroTile();
            this.modificarPedidoTile = new MetroFramework.Controls.MetroTile();
            this.EliminarPedidoTile = new MetroFramework.Controls.MetroTile();
            this.FacturarPedidoTile = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PedidosDGV
            // 
            this.PedidosDGV.AllowUserToAddRows = false;
            this.PedidosDGV.AllowUserToDeleteRows = false;
            this.PedidosDGV.AllowUserToResizeRows = false;
            this.PedidosDGV.BackgroundColor = System.Drawing.Color.Black;
            this.PedidosDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PedidosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PedidosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PedidosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PedidosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPedido,
            this.Comprador,
            this.Pagado,
            this.Debe,
            this.Productos});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PedidosDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.PedidosDGV.EnableHeadersVisualStyles = false;
            this.PedidosDGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PedidosDGV.GridColor = System.Drawing.Color.White;
            this.PedidosDGV.Location = new System.Drawing.Point(23, 63);
            this.PedidosDGV.MultiSelect = false;
            this.PedidosDGV.Name = "PedidosDGV";
            this.PedidosDGV.ReadOnly = true;
            this.PedidosDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PedidosDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.PedidosDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PedidosDGV.RowTemplate.Height = 24;
            this.PedidosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PedidosDGV.Size = new System.Drawing.Size(906, 307);
            this.PedidosDGV.TabIndex = 0;
            // 
            // IDPedido
            // 
            this.IDPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IDPedido.HeaderText = "IDPedido";
            this.IDPedido.Name = "IDPedido";
            this.IDPedido.ReadOnly = true;
            this.IDPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDPedido.Visible = false;
            // 
            // Comprador
            // 
            this.Comprador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Comprador.HeaderText = "Comprador";
            this.Comprador.Name = "Comprador";
            this.Comprador.ReadOnly = true;
            this.Comprador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Comprador.Width = 95;
            // 
            // Pagado
            // 
            this.Pagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Pagado.HeaderText = "Pagado";
            this.Pagado.Name = "Pagado";
            this.Pagado.ReadOnly = true;
            this.Pagado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Pagado.Width = 74;
            // 
            // Debe
            // 
            this.Debe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Debe.HeaderText = "Debe";
            this.Debe.Name = "Debe";
            this.Debe.ReadOnly = true;
            this.Debe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Debe.Width = 61;
            // 
            // Productos
            // 
            this.Productos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Productos.HeaderText = "Productos";
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            this.Productos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Productos.Width = 88;
            // 
            // AtrasTile
            // 
            this.AtrasTile.ActiveControl = null;
            this.AtrasTile.Location = new System.Drawing.Point(23, 376);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(92, 43);
            this.AtrasTile.TabIndex = 1;
            this.AtrasTile.Text = "Atras";
            this.AtrasTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AtrasTile.UseSelectable = true;
            this.AtrasTile.Click += new System.EventHandler(this.AtrasTile_Click);
            // 
            // AgregarPedidoTile
            // 
            this.AgregarPedidoTile.ActiveControl = null;
            this.AgregarPedidoTile.Location = new System.Drawing.Point(811, 376);
            this.AgregarPedidoTile.Name = "AgregarPedidoTile";
            this.AgregarPedidoTile.Size = new System.Drawing.Size(118, 43);
            this.AgregarPedidoTile.TabIndex = 2;
            this.AgregarPedidoTile.Text = "Agregar pedido";
            this.AgregarPedidoTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarPedidoTile.UseSelectable = true;
            this.AgregarPedidoTile.Click += new System.EventHandler(this.AgregarPedidoTile_Click);
            // 
            // modificarPedidoTile
            // 
            this.modificarPedidoTile.ActiveControl = null;
            this.modificarPedidoTile.Location = new System.Drawing.Point(678, 376);
            this.modificarPedidoTile.Name = "modificarPedidoTile";
            this.modificarPedidoTile.Size = new System.Drawing.Size(127, 43);
            this.modificarPedidoTile.TabIndex = 3;
            this.modificarPedidoTile.Text = "Modificar pedido";
            this.modificarPedidoTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificarPedidoTile.UseSelectable = true;
            this.modificarPedidoTile.Click += new System.EventHandler(this.modificarPedidoTile_Click);
            // 
            // EliminarPedidoTile
            // 
            this.EliminarPedidoTile.ActiveControl = null;
            this.EliminarPedidoTile.Location = new System.Drawing.Point(547, 376);
            this.EliminarPedidoTile.Name = "EliminarPedidoTile";
            this.EliminarPedidoTile.Size = new System.Drawing.Size(125, 43);
            this.EliminarPedidoTile.TabIndex = 4;
            this.EliminarPedidoTile.Text = "Eliminar pedido";
            this.EliminarPedidoTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarPedidoTile.UseSelectable = true;
            this.EliminarPedidoTile.Click += new System.EventHandler(this.EliminarPedidoTile_Click);
            // 
            // FacturarPedidoTile
            // 
            this.FacturarPedidoTile.ActiveControl = null;
            this.FacturarPedidoTile.Location = new System.Drawing.Point(416, 376);
            this.FacturarPedidoTile.Name = "FacturarPedidoTile";
            this.FacturarPedidoTile.Size = new System.Drawing.Size(125, 43);
            this.FacturarPedidoTile.TabIndex = 5;
            this.FacturarPedidoTile.Text = "Facturar pedido";
            this.FacturarPedidoTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FacturarPedidoTile.UseSelectable = true;
            this.FacturarPedidoTile.Click += new System.EventHandler(this.FacturarPedidoTile_Click);
            // 
            // ABM_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 436);
            this.Controls.Add(this.FacturarPedidoTile);
            this.Controls.Add(this.EliminarPedidoTile);
            this.Controls.Add(this.modificarPedidoTile);
            this.Controls.Add(this.AgregarPedidoTile);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.PedidosDGV);
            this.Name = "ABM_Pedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid PedidosDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private MetroFramework.Controls.MetroTile AtrasTile;
        private MetroFramework.Controls.MetroTile AgregarPedidoTile;
        private MetroFramework.Controls.MetroTile modificarPedidoTile;
        private MetroFramework.Controls.MetroTile EliminarPedidoTile;
        private MetroFramework.Controls.MetroTile FacturarPedidoTile;
    }
}