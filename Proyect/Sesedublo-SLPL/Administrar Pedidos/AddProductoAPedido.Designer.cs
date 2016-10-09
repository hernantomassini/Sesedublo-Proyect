namespace Sesedublo_SLPL.Administrar_Pedidos
{
    partial class AddProductoAPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductosDGV = new MetroFramework.Controls.MetroGrid();
            this.IDStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtrasTile = new MetroFramework.Controls.MetroTile();
            this.AceptarTile = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductosDGV
            // 
            this.ProductosDGV.AllowUserToAddRows = false;
            this.ProductosDGV.AllowUserToDeleteRows = false;
            this.ProductosDGV.AllowUserToResizeRows = false;
            this.ProductosDGV.BackgroundColor = System.Drawing.Color.Black;
            this.ProductosDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDStock,
            this.CantidadProductos,
            this.NombreProducto,
            this.PrecioProducto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductosDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductosDGV.EnableHeadersVisualStyles = false;
            this.ProductosDGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductosDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductosDGV.Location = new System.Drawing.Point(23, 73);
            this.ProductosDGV.MultiSelect = false;
            this.ProductosDGV.Name = "ProductosDGV";
            this.ProductosDGV.ReadOnly = true;
            this.ProductosDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductosDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductosDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductosDGV.RowTemplate.Height = 24;
            this.ProductosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductosDGV.Size = new System.Drawing.Size(788, 210);
            this.ProductosDGV.TabIndex = 0;
            // 
            // IDStock
            // 
            this.IDStock.HeaderText = "IDStock";
            this.IDStock.Name = "IDStock";
            this.IDStock.ReadOnly = true;
            this.IDStock.Visible = false;
            // 
            // CantidadProductos
            // 
            this.CantidadProductos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CantidadProductos.HeaderText = "Cantidad";
            this.CantidadProductos.Name = "CantidadProductos";
            this.CantidadProductos.ReadOnly = true;
            this.CantidadProductos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CantidadProductos.Width = 82;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreProducto.Width = 78;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PrecioProducto.HeaderText = "Precio";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            this.PrecioProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecioProducto.Width = 67;
            // 
            // AtrasTile
            // 
            this.AtrasTile.ActiveControl = null;
            this.AtrasTile.Location = new System.Drawing.Point(23, 289);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(91, 40);
            this.AtrasTile.TabIndex = 1;
            this.AtrasTile.Text = "Atras";
            this.AtrasTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AtrasTile.UseSelectable = true;
            this.AtrasTile.Click += new System.EventHandler(this.AtrasTile_Click);
            // 
            // AceptarTile
            // 
            this.AceptarTile.ActiveControl = null;
            this.AceptarTile.Location = new System.Drawing.Point(712, 289);
            this.AceptarTile.Name = "AceptarTile";
            this.AceptarTile.Size = new System.Drawing.Size(99, 40);
            this.AceptarTile.TabIndex = 2;
            this.AceptarTile.Text = "Aceptar";
            this.AceptarTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarTile.UseSelectable = true;
            this.AceptarTile.Click += new System.EventHandler(this.AceptarTile_Click);
            // 
            // AddProductoAPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 347);
            this.Controls.Add(this.AceptarTile);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.ProductosDGV);
            this.Name = "AddProductoAPedido";
            this.Text = "AddProductoAPedido";
            this.Load += new System.EventHandler(this.AddProductoAPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid ProductosDGV;
        private MetroFramework.Controls.MetroTile AtrasTile;
        private MetroFramework.Controls.MetroTile AceptarTile;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
    }
}