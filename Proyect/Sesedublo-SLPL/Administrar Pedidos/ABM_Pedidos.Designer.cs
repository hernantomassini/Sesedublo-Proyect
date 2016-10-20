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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Pedidos));
            this.PedidosDGV = new MetroFramework.Controls.MetroGrid();
            this.IDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facturada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtrasTile = new MetroFramework.Controls.MetroTile();
            this.AgregarPedidoTile = new MetroFramework.Controls.MetroTile();
            this.modificarPedidoTile = new MetroFramework.Controls.MetroTile();
            this.EliminarPedidoTile = new MetroFramework.Controls.MetroTile();
            this.FacturarPedidoTile = new MetroFramework.Controls.MetroTile();
            this.ActualizarPagoTile = new MetroFramework.Controls.MetroTile();
            this.nombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PedidosDGV
            // 
            this.PedidosDGV.AllowUserToAddRows = false;
            this.PedidosDGV.AllowUserToDeleteRows = false;
            this.PedidosDGV.AllowUserToResizeRows = false;
            this.PedidosDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.PedidosDGV.BackgroundColor = System.Drawing.Color.DarkGray;
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
            this.Productos,
            this.Facturada});
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
            this.PedidosDGV.Location = new System.Drawing.Point(18, 88);
            this.PedidosDGV.Margin = new System.Windows.Forms.Padding(2);
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
            this.PedidosDGV.Size = new System.Drawing.Size(904, 249);
            this.PedidosDGV.TabIndex = 0;
            this.PedidosDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PedidosDGV_CellDoubleClick);
            // 
            // IDPedido
            // 
            this.IDPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDPedido.HeaderText = "IDPedido";
            this.IDPedido.Name = "IDPedido";
            this.IDPedido.ReadOnly = true;
            this.IDPedido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDPedido.Visible = false;
            // 
            // Comprador
            // 
            this.Comprador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Comprador.HeaderText = "Comprador";
            this.Comprador.Name = "Comprador";
            this.Comprador.ReadOnly = true;
            this.Comprador.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Comprador.Width = 88;
            // 
            // Pagado
            // 
            this.Pagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pagado.HeaderText = "Pagado";
            this.Pagado.Name = "Pagado";
            this.Pagado.ReadOnly = true;
            this.Pagado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pagado.Width = 69;
            // 
            // Debe
            // 
            this.Debe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Debe.HeaderText = "Debe";
            this.Debe.Name = "Debe";
            this.Debe.ReadOnly = true;
            this.Debe.Width = 57;
            // 
            // Productos
            // 
            this.Productos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Productos.HeaderText = "Productos";
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            this.Productos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Productos.Width = 82;
            // 
            // Facturada
            // 
            this.Facturada.HeaderText = "facturada";
            this.Facturada.Name = "Facturada";
            this.Facturada.ReadOnly = true;
            this.Facturada.Width = 79;
            // 
            // AtrasTile
            // 
            this.AtrasTile.ActiveControl = null;
            this.AtrasTile.BackColor = System.Drawing.Color.Teal;
            this.AtrasTile.Location = new System.Drawing.Point(18, 343);
            this.AtrasTile.Margin = new System.Windows.Forms.Padding(2);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(82, 41);
            this.AtrasTile.TabIndex = 1;
            this.AtrasTile.Text = "Atras";
            this.AtrasTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AtrasTile.TileImage = ((System.Drawing.Image)(resources.GetObject("AtrasTile.TileImage")));
            this.AtrasTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtrasTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AtrasTile.UseCustomBackColor = true;
            this.AtrasTile.UseSelectable = true;
            this.AtrasTile.UseStyleColors = true;
            this.AtrasTile.UseTileImage = true;
            this.AtrasTile.Click += new System.EventHandler(this.AtrasTile_Click);
            // 
            // AgregarPedidoTile
            // 
            this.AgregarPedidoTile.ActiveControl = null;
            this.AgregarPedidoTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AgregarPedidoTile.BackColor = System.Drawing.Color.Purple;
            this.AgregarPedidoTile.Location = new System.Drawing.Point(766, 342);
            this.AgregarPedidoTile.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarPedidoTile.Name = "AgregarPedidoTile";
            this.AgregarPedidoTile.Size = new System.Drawing.Size(156, 43);
            this.AgregarPedidoTile.TabIndex = 2;
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
            // modificarPedidoTile
            // 
            this.modificarPedidoTile.ActiveControl = null;
            this.modificarPedidoTile.BackColor = System.Drawing.Color.Green;
            this.modificarPedidoTile.Location = new System.Drawing.Point(604, 342);
            this.modificarPedidoTile.Margin = new System.Windows.Forms.Padding(2);
            this.modificarPedidoTile.Name = "modificarPedidoTile";
            this.modificarPedidoTile.Size = new System.Drawing.Size(155, 43);
            this.modificarPedidoTile.TabIndex = 3;
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
            // EliminarPedidoTile
            // 
            this.EliminarPedidoTile.ActiveControl = null;
            this.EliminarPedidoTile.BackColor = System.Drawing.Color.DodgerBlue;
            this.EliminarPedidoTile.Location = new System.Drawing.Point(442, 342);
            this.EliminarPedidoTile.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarPedidoTile.Name = "EliminarPedidoTile";
            this.EliminarPedidoTile.Size = new System.Drawing.Size(158, 43);
            this.EliminarPedidoTile.TabIndex = 4;
            this.EliminarPedidoTile.Text = "Eliminar pedido";
            this.EliminarPedidoTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarPedidoTile.TileImage = ((System.Drawing.Image)(resources.GetObject("EliminarPedidoTile.TileImage")));
            this.EliminarPedidoTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarPedidoTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.EliminarPedidoTile.UseCustomBackColor = true;
            this.EliminarPedidoTile.UseSelectable = true;
            this.EliminarPedidoTile.UseTileImage = true;
            this.EliminarPedidoTile.Click += new System.EventHandler(this.EliminarPedidoTile_Click);
            // 
            // FacturarPedidoTile
            // 
            this.FacturarPedidoTile.ActiveControl = null;
            this.FacturarPedidoTile.BackColor = System.Drawing.Color.RoyalBlue;
            this.FacturarPedidoTile.Location = new System.Drawing.Point(127, 341);
            this.FacturarPedidoTile.Margin = new System.Windows.Forms.Padding(2);
            this.FacturarPedidoTile.Name = "FacturarPedidoTile";
            this.FacturarPedidoTile.Size = new System.Drawing.Size(153, 44);
            this.FacturarPedidoTile.TabIndex = 5;
            this.FacturarPedidoTile.Text = "Facturar pedido";
            this.FacturarPedidoTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FacturarPedidoTile.TileImage = ((System.Drawing.Image)(resources.GetObject("FacturarPedidoTile.TileImage")));
            this.FacturarPedidoTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FacturarPedidoTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.FacturarPedidoTile.UseCustomBackColor = true;
            this.FacturarPedidoTile.UseSelectable = true;
            this.FacturarPedidoTile.UseTileImage = true;
            this.FacturarPedidoTile.Click += new System.EventHandler(this.FacturarPedidoTile_Click);
            // 
            // ActualizarPagoTile
            // 
            this.ActualizarPagoTile.ActiveControl = null;
            this.ActualizarPagoTile.BackColor = System.Drawing.Color.Crimson;
            this.ActualizarPagoTile.Location = new System.Drawing.Point(285, 342);
            this.ActualizarPagoTile.Name = "ActualizarPagoTile";
            this.ActualizarPagoTile.Size = new System.Drawing.Size(151, 43);
            this.ActualizarPagoTile.TabIndex = 6;
            this.ActualizarPagoTile.Text = "Actualizar pago";
            this.ActualizarPagoTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActualizarPagoTile.TileImage = ((System.Drawing.Image)(resources.GetObject("ActualizarPagoTile.TileImage")));
            this.ActualizarPagoTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualizarPagoTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ActualizarPagoTile.UseCustomBackColor = true;
            this.ActualizarPagoTile.UseSelectable = true;
            this.ActualizarPagoTile.UseTileImage = true;
            this.ActualizarPagoTile.Click += new System.EventHandler(this.ActualizarPagoTile_Click);
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
            this.nombre.Location = new System.Drawing.Point(121, 60);
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
            this.nombre.TabIndex = 12;
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
            this.metroLabel6.Location = new System.Drawing.Point(23, 60);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(82, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Comprador:";
            // 
            // ABM_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(954, 416);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.ActualizarPagoTile);
            this.Controls.Add(this.FacturarPedidoTile);
            this.Controls.Add(this.EliminarPedidoTile);
            this.Controls.Add(this.modificarPedidoTile);
            this.Controls.Add(this.AgregarPedidoTile);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.PedidosDGV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ABM_Pedidos";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.ABM_Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid PedidosDGV;
        private MetroFramework.Controls.MetroTile AtrasTile;
        private MetroFramework.Controls.MetroTile AgregarPedidoTile;
        private MetroFramework.Controls.MetroTile modificarPedidoTile;
        private MetroFramework.Controls.MetroTile EliminarPedidoTile;
        private MetroFramework.Controls.MetroTile FacturarPedidoTile;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facturada;
        private MetroFramework.Controls.MetroTile ActualizarPagoTile;
        private MetroFramework.Controls.MetroTextBox nombre;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}