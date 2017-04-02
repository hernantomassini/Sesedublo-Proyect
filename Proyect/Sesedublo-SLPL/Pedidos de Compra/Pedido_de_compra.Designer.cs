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
            this.pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockCargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.CargarStockTile = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.nombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.titleCancelar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // modificarPedidoTile
            // 
            this.modificarPedidoTile.ActiveControl = null;
            this.modificarPedidoTile.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.modificarPedidoTile.Location = new System.Drawing.Point(639, 315);
            this.modificarPedidoTile.Margin = new System.Windows.Forms.Padding(2);
            this.modificarPedidoTile.Name = "modificarPedidoTile";
            this.modificarPedidoTile.Size = new System.Drawing.Size(153, 43);
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
            this.AgregarPedidoTile.Location = new System.Drawing.Point(798, 315);
            this.AgregarPedidoTile.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarPedidoTile.Name = "AgregarPedidoTile";
            this.AgregarPedidoTile.Size = new System.Drawing.Size(153, 43);
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
            this.AtrasTile.Location = new System.Drawing.Point(22, 315);
            this.AtrasTile.Margin = new System.Windows.Forms.Padding(2);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(93, 41);
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
            this.PedidosDGV.BackgroundColor = System.Drawing.Color.DarkGray;
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
            this.Costo,
            this.pagado,
            this.StockCargado});
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
            this.PedidosDGV.Location = new System.Drawing.Point(22, 62);
            this.PedidosDGV.Margin = new System.Windows.Forms.Padding(2);
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
            this.PedidosDGV.Size = new System.Drawing.Size(928, 249);
            this.PedidosDGV.TabIndex = 6;
            this.PedidosDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PedidosDGV_CellDoubleClick);
            this.PedidosDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.PedidosDGV_CellFormatting);
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
            this.Proveedor.Width = 82;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 60;
            // 
            // Productos
            // 
            this.Productos.HeaderText = "Productos comprados";
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            this.Productos.Width = 130;
            // 
            // Costo
            // 
            this.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 60;
            // 
            // pagado
            // 
            this.pagado.HeaderText = "Pagado";
            this.pagado.Name = "pagado";
            this.pagado.ReadOnly = true;
            this.pagado.Width = 69;
            // 
            // StockCargado
            // 
            this.StockCargado.HeaderText = "Stock cargado";
            this.StockCargado.Name = "StockCargado";
            this.StockCargado.ReadOnly = true;
            this.StockCargado.Width = 94;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.metroTile1.Location = new System.Drawing.Point(482, 315);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(153, 43);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Pagar pedido";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // CargarStockTile
            // 
            this.CargarStockTile.ActiveControl = null;
            this.CargarStockTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CargarStockTile.Location = new System.Drawing.Point(345, 315);
            this.CargarStockTile.Name = "CargarStockTile";
            this.CargarStockTile.Size = new System.Drawing.Size(132, 43);
            this.CargarStockTile.TabIndex = 8;
            this.CargarStockTile.Text = "Cargar stock";
            this.CargarStockTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CargarStockTile.TileImage = ((System.Drawing.Image)(resources.GetObject("CargarStockTile.TileImage")));
            this.CargarStockTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CargarStockTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.CargarStockTile.UseCustomBackColor = true;
            this.CargarStockTile.UseSelectable = true;
            this.CargarStockTile.UseTileImage = true;
            this.CargarStockTile.Click += new System.EventHandler(this.CargarStockTile_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(824, 13);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(127, 44);
            this.metroTile2.TabIndex = 18;
            this.metroTile2.Text = "PDF";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // nombre
            // 
            // 
            // 
            // 
            this.nombre.CustomButton.Image = null;
            this.nombre.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.nombre.CustomButton.Name = "";
            this.nombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nombre.CustomButton.TabIndex = 1;
            this.nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nombre.CustomButton.UseSelectable = true;
            this.nombre.CustomButton.Visible = false;
            this.nombre.DisplayIcon = true;
            this.nombre.Icon = ((System.Drawing.Image)(resources.GetObject("nombre.Icon")));
            this.nombre.Lines = new string[0];
            this.nombre.Location = new System.Drawing.Point(326, 30);
            this.nombre.MaxLength = 32767;
            this.nombre.Name = "nombre";
            this.nombre.PasswordChar = '\0';
            this.nombre.PromptText = "Buscar";
            this.nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombre.SelectedText = "";
            this.nombre.SelectionLength = 0;
            this.nombre.SelectionStart = 0;
            this.nombre.ShortcutsEnabled = true;
            this.nombre.Size = new System.Drawing.Size(101, 23);
            this.nombre.TabIndex = 19;
            this.nombre.UseSelectable = true;
            this.nombre.WaterMark = "Buscar";
            this.nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(247, 31);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Proveedor:";
            // 
            // titleCancelar
            // 
            this.titleCancelar.ActiveControl = null;
            this.titleCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.titleCancelar.Location = new System.Drawing.Point(182, 314);
            this.titleCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.titleCancelar.Name = "titleCancelar";
            this.titleCancelar.Size = new System.Drawing.Size(156, 44);
            this.titleCancelar.TabIndex = 22;
            this.titleCancelar.Text = "Eliminar Pedido";
            this.titleCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleCancelar.TileImage = ((System.Drawing.Image)(resources.GetObject("titleCancelar.TileImage")));
            this.titleCancelar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleCancelar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleCancelar.UseCustomBackColor = true;
            this.titleCancelar.UseSelectable = true;
            this.titleCancelar.UseTileImage = true;
            this.titleCancelar.Click += new System.EventHandler(this.titleCancelar_Click);
            // 
            // Pedido_de_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 378);
            this.Controls.Add(this.titleCancelar);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.CargarStockTile);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.modificarPedidoTile);
            this.Controls.Add(this.AgregarPedidoTile);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.PedidosDGV);
            this.MaximizeBox = false;
            this.Name = "Pedido_de_compra";
            this.Text = "Pedido de Compra";
            this.Load += new System.EventHandler(this.Pedido_de_compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile modificarPedidoTile;
        private MetroFramework.Controls.MetroTile AgregarPedidoTile;
        private MetroFramework.Controls.MetroTile AtrasTile;
        private MetroFramework.Controls.MetroGrid PedidosDGV;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile CargarStockTile;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTextBox nombre;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedidoLea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCargado;
        private MetroFramework.Controls.MetroTile titleCancelar;
    }
}