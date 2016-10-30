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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Stock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StockDGV = new MetroFramework.Controls.MetroGrid();
            this.titleAtras = new MetroFramework.Controls.MetroTile();
            this.titleAgregarCliente = new MetroFramework.Controls.MetroTile();
            this.nombre = new MetroFramework.Controls.MetroTextBox();
            this.nombreLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnitary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVBulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StockDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.Cantidad,
            this.Producto,
            this.CostoUnitary,
            this.CostoTotal,
            this.PVUnitario,
            this.PVBulto,
            this.stockOPedido});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.StockDGV.EnableHeadersVisualStyles = false;
            this.StockDGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StockDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StockDGV.Location = new System.Drawing.Point(29, 139);
            this.StockDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StockDGV.MultiSelect = false;
            this.StockDGV.Name = "StockDGV";
            this.StockDGV.ReadOnly = true;
            this.StockDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StockDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.StockDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockDGV.Size = new System.Drawing.Size(868, 305);
            this.StockDGV.TabIndex = 4;
            this.StockDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDGV_CellContentClick);
            // 
            // titleAtras
            // 
            this.titleAtras.ActiveControl = null;
            this.titleAtras.BackColor = System.Drawing.Color.CadetBlue;
            this.titleAtras.Location = new System.Drawing.Point(31, 452);
            this.titleAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleAtras.Name = "titleAtras";
            this.titleAtras.Size = new System.Drawing.Size(100, 54);
            this.titleAtras.TabIndex = 3;
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
            // titleAgregarCliente
            // 
            this.titleAgregarCliente.ActiveControl = null;
            this.titleAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.titleAgregarCliente.Location = new System.Drawing.Point(713, 452);
            this.titleAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleAgregarCliente.Name = "titleAgregarCliente";
            this.titleAgregarCliente.Size = new System.Drawing.Size(184, 54);
            this.titleAgregarCliente.TabIndex = 2;
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
            // nombre
            // 
            // 
            // 
            // 
            this.nombre.CustomButton.Image = null;
            this.nombre.CustomButton.Location = new System.Drawing.Point(126, 2);
            this.nombre.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombre.CustomButton.Name = "";
            this.nombre.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nombre.CustomButton.TabIndex = 1;
            this.nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nombre.CustomButton.UseSelectable = true;
            this.nombre.CustomButton.Visible = false;
            this.nombre.DisplayIcon = true;
            this.nombre.Icon = ((System.Drawing.Image)(resources.GetObject("nombre.Icon")));
            this.nombre.Lines = new string[0];
            this.nombre.Location = new System.Drawing.Point(120, 100);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombre.MaxLength = 70;
            this.nombre.Name = "nombre";
            this.nombre.PasswordChar = '\0';
            this.nombre.PromptText = "Buscar";
            this.nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombre.SelectedText = "";
            this.nombre.SelectionLength = 0;
            this.nombre.SelectionStart = 0;
            this.nombre.ShortcutsEnabled = true;
            this.nombre.Size = new System.Drawing.Size(152, 28);
            this.nombre.TabIndex = 1;
            this.nombre.UseSelectable = true;
            this.nombre.WaterMark = "Buscar";
            this.nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(29, 100);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(64, 20);
            this.nombreLabel.TabIndex = 11;
            this.nombreLabel.Text = "Nombre:";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.Gray;
            this.metroTile1.Location = new System.Drawing.Point(536, 452);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(169, 54);
            this.metroTile1.TabIndex = 18;
            this.metroTile1.Text = "PDF";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.Gray;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(29, 139);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(868, 305);
            this.metroGrid1.TabIndex = 19;
            this.metroGrid1.Visible = false;
            // 
            // id_producto
            // 
            this.id_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id_producto.HeaderText = "ID Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_producto.Visible = false;
            this.id_producto.Width = 77;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad.Width = 82;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Producto.Width = 83;
            // 
            // CostoUnitary
            // 
            this.CostoUnitary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CostoUnitary.HeaderText = "Costo unitario";
            this.CostoUnitary.Name = "CostoUnitary";
            this.CostoUnitary.ReadOnly = true;
            this.CostoUnitary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CostoUnitary.Width = 109;
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "Costo total";
            this.CostoTotal.Name = "CostoTotal";
            this.CostoTotal.ReadOnly = true;
            this.CostoTotal.Width = 150;
            // 
            // PVUnitario
            // 
            this.PVUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PVUnitario.HeaderText = "Precio de venta unitario";
            this.PVUnitario.Name = "PVUnitario";
            this.PVUnitario.ReadOnly = true;
            this.PVUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PVUnitario.Width = 108;
            // 
            // PVBulto
            // 
            this.PVBulto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PVBulto.HeaderText = "Precio de venta por Bulto";
            this.PVBulto.Name = "PVBulto";
            this.PVBulto.ReadOnly = true;
            this.PVBulto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PVBulto.Width = 127;
            // 
            // stockOPedido
            // 
            this.stockOPedido.HeaderText = "Tipo";
            this.stockOPedido.Name = "stockOPedido";
            this.stockOPedido.ReadOnly = true;
            this.stockOPedido.Visible = false;
            // 
            // ABM_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 534);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.titleAtras);
            this.Controls.Add(this.titleAgregarCliente);
            this.Controls.Add(this.StockDGV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ABM_Stock";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.ABM_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroGrid StockDGV;
        private MetroTile titleAtras;
        private MetroTile titleAgregarCliente;
        private MetroTextBox nombre;
        private MetroLabel nombreLabel;
        private MetroTile metroTile1;
        private MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUnitary;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVBulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOPedido;
    }
}