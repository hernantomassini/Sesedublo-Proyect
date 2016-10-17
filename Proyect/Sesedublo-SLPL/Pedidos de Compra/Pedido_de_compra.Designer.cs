namespace Sesedublo_SLPL.Pedidos_de_Compra
{
    partial class Pedido_de_compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido_de_compra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modificarPedidoTile = new MetroFramework.Controls.MetroTile();
            this.AgregarPedidoTile = new MetroFramework.Controls.MetroTile();
            this.AtrasTile = new MetroFramework.Controls.MetroTile();
            this.PedidosDGV = new MetroFramework.Controls.MetroGrid();
            this.IDPedidoLea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // modificarPedidoTile
            // 
            this.modificarPedidoTile.ActiveControl = null;
            this.modificarPedidoTile.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.modificarPedidoTile.Location = new System.Drawing.Point(587, 388);
            this.modificarPedidoTile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificarPedidoTile.Name = "modificarPedidoTile";
            this.modificarPedidoTile.Size = new System.Drawing.Size(204, 53);
            this.modificarPedidoTile.TabIndex = 2;
            this.modificarPedidoTile.Text = "Modificar pedido";
            this.modificarPedidoTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificarPedidoTile.TileImage = ((System.Drawing.Image)(resources.GetObject("modificarPedidoTile.TileImage")));
            this.modificarPedidoTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarPedidoTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.modificarPedidoTile.UseCustomBackColor = true;
            this.modificarPedidoTile.UseSelectable = true;
            this.modificarPedidoTile.UseTileImage = true;
            this.modificarPedidoTile.Click += new System.EventHandler(this.modificarPedidoTile_Click);
            // 
            // AgregarPedidoTile
            // 
            this.AgregarPedidoTile.ActiveControl = null;
            this.AgregarPedidoTile.BackColor = System.Drawing.Color.SteelBlue;
            this.AgregarPedidoTile.Location = new System.Drawing.Point(799, 388);
            this.AgregarPedidoTile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgregarPedidoTile.Name = "AgregarPedidoTile";
            this.AgregarPedidoTile.Size = new System.Drawing.Size(204, 53);
            this.AgregarPedidoTile.TabIndex = 1;
            this.AgregarPedidoTile.Text = "Agregar pedido";
            this.AgregarPedidoTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarPedidoTile.TileImage = ((System.Drawing.Image)(resources.GetObject("AgregarPedidoTile.TileImage")));
            this.AgregarPedidoTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarPedidoTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AgregarPedidoTile.UseCustomBackColor = true;
            this.AgregarPedidoTile.UseSelectable = true;
            this.AgregarPedidoTile.UseTileImage = true;
            this.AgregarPedidoTile.Click += new System.EventHandler(this.AgregarPedidoTile_Click);
            // 
            // AtrasTile
            // 
            this.AtrasTile.ActiveControl = null;
            this.AtrasTile.BackColor = System.Drawing.Color.SlateGray;
            this.AtrasTile.Location = new System.Drawing.Point(29, 388);
            this.AtrasTile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(124, 50);
            this.AtrasTile.TabIndex = 3;
            this.AtrasTile.Text = "Atras";
            this.AtrasTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AtrasTile.TileImage = ((System.Drawing.Image)(resources.GetObject("AtrasTile.TileImage")));
            this.AtrasTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtrasTile.UseCustomBackColor = true;
            this.AtrasTile.UseSelectable = true;
            this.AtrasTile.UseTileImage = true;
            this.AtrasTile.Click += new System.EventHandler(this.AtrasTile_Click);
            // 
            // PedidosDGV
            // 
            this.PedidosDGV.AllowUserToAddRows = false;
            this.PedidosDGV.AllowUserToDeleteRows = false;
            this.PedidosDGV.AllowUserToResizeRows = false;
            this.PedidosDGV.BackgroundColor = System.Drawing.Color.Gray;
            this.PedidosDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PedidosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PedidosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PedidosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PedidosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPedidoLea,
            this.Proveedor,
            this.Fecha,
            this.Productos,
            this.Costo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PedidosDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.PedidosDGV.EnableHeadersVisualStyles = false;
            this.PedidosDGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PedidosDGV.GridColor = System.Drawing.Color.White;
            this.PedidosDGV.Location = new System.Drawing.Point(29, 76);
            this.PedidosDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PedidosDGV.MultiSelect = false;
            this.PedidosDGV.Name = "PedidosDGV";
            this.PedidosDGV.ReadOnly = true;
            this.PedidosDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PedidosDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PedidosDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PedidosDGV.RowTemplate.Height = 24;
            this.PedidosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PedidosDGV.Size = new System.Drawing.Size(973, 306);
            this.PedidosDGV.TabIndex = 6;
            this.PedidosDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PedidosDGV_CellDoubleClick);
            // 
            // IDPedidoLea
            // 
            this.IDPedidoLea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDPedidoLea.HeaderText = "IDPedidoLea";
            this.IDPedidoLea.Name = "IDPedidoLea";
            this.IDPedidoLea.ReadOnly = true;
            this.IDPedidoLea.Visible = false;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 65;
            // 
            // Productos
            // 
            this.Productos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Productos.HeaderText = "Productos comprados";
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            this.Productos.Width = 138;
            // 
            // Costo
            // 
            this.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 65;
            // 
            // Pedido_de_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 465);
            this.Controls.Add(this.modificarPedidoTile);
            this.Controls.Add(this.AgregarPedidoTile);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.PedidosDGV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Pedido_de_compra";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Pedido de Compra";
            this.Load += new System.EventHandler(this.Pedido_de_compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile modificarPedidoTile;
        private MetroFramework.Controls.MetroTile AgregarPedidoTile;
        private MetroFramework.Controls.MetroTile AtrasTile;
        private MetroFramework.Controls.MetroGrid PedidosDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedidoLea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
    }
}