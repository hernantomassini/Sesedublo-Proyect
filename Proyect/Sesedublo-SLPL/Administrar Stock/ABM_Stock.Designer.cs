using MetroFramework.Controls;

namespace Sesedublo_SLPL.Administrar_Productos
{
    partial class ABM_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Stock));
            this.StockDGV = new MetroFramework.Controls.MetroGrid();
            this.id_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVBulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleAtras = new MetroFramework.Controls.MetroTile();
            this.titleEliminarCliente = new MetroFramework.Controls.MetroTile();
            this.titleAgregarCliente = new MetroFramework.Controls.MetroTile();
            this.titleModificarCliente = new MetroFramework.Controls.MetroTile();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.NombreLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // StockDGV
            // 
            this.StockDGV.AllowUserToAddRows = false;
            this.StockDGV.AllowUserToDeleteRows = false;
            this.StockDGV.AllowUserToResizeRows = false;
            this.StockDGV.BackgroundColor = System.Drawing.Color.Gray;
            this.StockDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.StockDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StockDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_stock,
            this.Cantidad,
            this.Producto,
            this.Costo,
            this.PVUnitario,
            this.PVBulto});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.StockDGV.EnableHeadersVisualStyles = false;
            this.StockDGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StockDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StockDGV.Location = new System.Drawing.Point(22, 113);
            this.StockDGV.MultiSelect = false;
            this.StockDGV.Name = "StockDGV";
            this.StockDGV.ReadOnly = true;
            this.StockDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.StockDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.StockDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockDGV.Size = new System.Drawing.Size(562, 248);
            this.StockDGV.TabIndex = 4;
            this.StockDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDGV_CellContentClick);
            // 
            // id_stock
            // 
            this.id_stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id_stock.HeaderText = "ID Stock";
            this.id_stock.Name = "id_stock";
            this.id_stock.ReadOnly = true;
            this.id_stock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_stock.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad.Width = 77;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Producto.Width = 77;
            // 
            // Costo
            // 
            this.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Costo.Width = 60;
            // 
            // PVUnitario
            // 
            this.PVUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PVUnitario.HeaderText = "Precio de venta unitario";
            this.PVUnitario.Name = "PVUnitario";
            this.PVUnitario.ReadOnly = true;
            this.PVUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PVUnitario.Width = 102;
            // 
            // PVBulto
            // 
            this.PVBulto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PVBulto.HeaderText = "Precio de venta por Bulto";
            this.PVBulto.Name = "PVBulto";
            this.PVBulto.ReadOnly = true;
            this.PVBulto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PVBulto.Width = 121;
            // 
            // titleAtras
            // 
            this.titleAtras.ActiveControl = null;
            this.titleAtras.BackColor = System.Drawing.Color.CadetBlue;
            this.titleAtras.Location = new System.Drawing.Point(23, 367);
            this.titleAtras.Name = "titleAtras";
            this.titleAtras.Size = new System.Drawing.Size(75, 44);
            this.titleAtras.TabIndex = 8;
            this.titleAtras.Text = "Atrás";
            this.titleAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleAtras.TileImage = ((System.Drawing.Image)(resources.GetObject("titleAtras.TileImage")));
            this.titleAtras.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleAtras.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleAtras.UseCustomBackColor = true;
            this.titleAtras.UseSelectable = true;
            this.titleAtras.UseTileImage = true;
            this.titleAtras.Click += new System.EventHandler(this.AtrasButton_Click);
            // 
            // titleEliminarCliente
            // 
            this.titleEliminarCliente.ActiveControl = null;
            this.titleEliminarCliente.BackColor = System.Drawing.Color.IndianRed;
            this.titleEliminarCliente.Location = new System.Drawing.Point(144, 367);
            this.titleEliminarCliente.Name = "titleEliminarCliente";
            this.titleEliminarCliente.Size = new System.Drawing.Size(138, 44);
            this.titleEliminarCliente.TabIndex = 7;
            this.titleEliminarCliente.Text = "Eliminar Stock";
            this.titleEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleEliminarCliente.TileImage = ((System.Drawing.Image)(resources.GetObject("titleEliminarCliente.TileImage")));
            this.titleEliminarCliente.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleEliminarCliente.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleEliminarCliente.UseCustomBackColor = true;
            this.titleEliminarCliente.UseSelectable = true;
            this.titleEliminarCliente.UseTileImage = true;
            this.titleEliminarCliente.Click += new System.EventHandler(this.EliminarProductoStockBtn_Click);
            // 
            // titleAgregarCliente
            // 
            this.titleAgregarCliente.ActiveControl = null;
            this.titleAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.titleAgregarCliente.Location = new System.Drawing.Point(446, 367);
            this.titleAgregarCliente.Name = "titleAgregarCliente";
            this.titleAgregarCliente.Size = new System.Drawing.Size(138, 44);
            this.titleAgregarCliente.TabIndex = 6;
            this.titleAgregarCliente.Text = "Agregar Stock";
            this.titleAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleAgregarCliente.TileImage = ((System.Drawing.Image)(resources.GetObject("titleAgregarCliente.TileImage")));
            this.titleAgregarCliente.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleAgregarCliente.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleAgregarCliente.UseCustomBackColor = true;
            this.titleAgregarCliente.UseSelectable = true;
            this.titleAgregarCliente.UseTileImage = true;
            this.titleAgregarCliente.Click += new System.EventHandler(this.AgregarProductoStockBtn_Click);
            // 
            // titleModificarCliente
            // 
            this.titleModificarCliente.ActiveControl = null;
            this.titleModificarCliente.Location = new System.Drawing.Point(288, 367);
            this.titleModificarCliente.Name = "titleModificarCliente";
            this.titleModificarCliente.Size = new System.Drawing.Size(152, 44);
            this.titleModificarCliente.TabIndex = 5;
            this.titleModificarCliente.Text = "Modificar Stock";
            this.titleModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleModificarCliente.TileImage = ((System.Drawing.Image)(resources.GetObject("titleModificarCliente.TileImage")));
            this.titleModificarCliente.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleModificarCliente.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleModificarCliente.UseSelectable = true;
            this.titleModificarCliente.UseTileImage = true;
            this.titleModificarCliente.Click += new System.EventHandler(this.modificarProductoStockBtn_Click);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(90, 77);
            this.Nombre.MaxLength = 100;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 9;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(23, 78);
            this.NombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(62, 19);
            this.NombreLabel.TabIndex = 10;
            this.NombreLabel.Text = "Nombre:";
            // 
            // ABM_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 434);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.titleAtras);
            this.Controls.Add(this.titleEliminarCliente);
            this.Controls.Add(this.titleAgregarCliente);
            this.Controls.Add(this.titleModificarCliente);
            this.Controls.Add(this.StockDGV);
            this.Name = "ABM_Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.ABM_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroGrid StockDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVBulto;
        private MetroTile titleAtras;
        private MetroTile titleEliminarCliente;
        private MetroTile titleAgregarCliente;
        private MetroTile titleModificarCliente;
        private System.Windows.Forms.TextBox Nombre;
        private MetroLabel NombreLabel;
    }
}