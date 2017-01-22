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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductoAPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductosDGV = new MetroFramework.Controls.MetroGrid();
            this.IDStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtrasTile = new MetroFramework.Controls.MetroTile();
            this.Nombre = new MetroFramework.Controls.MetroTextBox();
            this.nombreLabel = new MetroFramework.Controls.MetroLabel();
            this.AgregarTile = new MetroFramework.Controls.MetroTile();
            this.Cantidad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BorrarTile = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ItemsDGV = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalizarTile = new MetroFramework.Controls.MetroTile();
            this.MontoACobrarLabel = new MetroFramework.Controls.MetroLabel();
            this.montoAPagarDelPedido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cantidadPagada = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductosDGV
            // 
            this.ProductosDGV.AllowUserToAddRows = false;
            this.ProductosDGV.AllowUserToDeleteRows = false;
            this.ProductosDGV.AllowUserToResizeRows = false;
            this.ProductosDGV.BackgroundColor = System.Drawing.Color.DarkGray;
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
            this.ProductosDGV.Location = new System.Drawing.Point(23, 139);
            this.ProductosDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductosDGV.MultiSelect = false;
            this.ProductosDGV.Name = "ProductosDGV";
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
            this.ProductosDGV.Size = new System.Drawing.Size(788, 207);
            this.ProductosDGV.TabIndex = 0;
            this.ProductosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductosDGV_CellClick);
            this.ProductosDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductosDGV_CellFormatting);
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
            this.CantidadProductos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CantidadProductos.Width = 82;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NombreProducto.Width = 78;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PrecioProducto.HeaderText = "Precio";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrecioProducto.Width = 67;
            // 
            // AtrasTile
            // 
            this.AtrasTile.ActiveControl = null;
            this.AtrasTile.BackColor = System.Drawing.Color.Teal;
            this.AtrasTile.Location = new System.Drawing.Point(24, 650);
            this.AtrasTile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(112, 54);
            this.AtrasTile.TabIndex = 7;
            this.AtrasTile.Text = "Atras";
            this.AtrasTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AtrasTile.TileImage = ((System.Drawing.Image)(resources.GetObject("AtrasTile.TileImage")));
            this.AtrasTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtrasTile.UseCustomBackColor = true;
            this.AtrasTile.UseSelectable = true;
            this.AtrasTile.UseTileImage = true;
            this.AtrasTile.Click += new System.EventHandler(this.AtrasTile_Click);
            // 
            // Nombre
            // 
            // 
            // 
            // 
            this.Nombre.CustomButton.Image = null;
            this.Nombre.CustomButton.Location = new System.Drawing.Point(126, 2);
            this.Nombre.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nombre.CustomButton.Name = "";
            this.Nombre.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Nombre.CustomButton.TabIndex = 1;
            this.Nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Nombre.CustomButton.UseSelectable = true;
            this.Nombre.CustomButton.Visible = false;
            this.Nombre.DisplayIcon = true;
            this.Nombre.Icon = ((System.Drawing.Image)(resources.GetObject("Nombre.Icon")));
            this.Nombre.Lines = new string[0];
            this.Nombre.Location = new System.Drawing.Point(113, 105);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nombre.MaxLength = 32767;
            this.Nombre.Name = "Nombre";
            this.Nombre.PasswordChar = '\0';
            this.Nombre.PromptText = "Buscar";
            this.Nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Nombre.SelectedText = "";
            this.Nombre.SelectionLength = 0;
            this.Nombre.SelectionStart = 0;
            this.Nombre.ShortcutsEnabled = true;
            this.Nombre.Size = new System.Drawing.Size(152, 28);
            this.Nombre.TabIndex = 1;
            this.Nombre.UseSelectable = true;
            this.Nombre.WaterMark = "Buscar";
            this.Nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(23, 105);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(64, 20);
            this.nombreLabel.TabIndex = 13;
            this.nombreLabel.Text = "Nombre:";
            // 
            // AgregarTile
            // 
            this.AgregarTile.ActiveControl = null;
            this.AgregarTile.BackColor = System.Drawing.Color.DarkBlue;
            this.AgregarTile.Location = new System.Drawing.Point(679, 352);
            this.AgregarTile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgregarTile.Name = "AgregarTile";
            this.AgregarTile.Size = new System.Drawing.Size(132, 54);
            this.AgregarTile.TabIndex = 3;
            this.AgregarTile.Text = "Agregar";
            this.AgregarTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarTile.TileImage = ((System.Drawing.Image)(resources.GetObject("AgregarTile.TileImage")));
            this.AgregarTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarTile.UseCustomBackColor = true;
            this.AgregarTile.UseSelectable = true;
            this.AgregarTile.UseTileImage = true;
            this.AgregarTile.Click += new System.EventHandler(this.AgregarTile_Click);
            // 
            // Cantidad
            // 
            // 
            // 
            // 
            this.Cantidad.CustomButton.Image = null;
            this.Cantidad.CustomButton.Location = new System.Drawing.Point(168, 2);
            this.Cantidad.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cantidad.CustomButton.Name = "";
            this.Cantidad.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.Cantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Cantidad.CustomButton.TabIndex = 1;
            this.Cantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Cantidad.CustomButton.UseSelectable = true;
            this.Cantidad.CustomButton.Visible = false;
            this.Cantidad.DisplayIcon = true;
            this.Cantidad.Lines = new string[0];
            this.Cantidad.Location = new System.Drawing.Point(119, 352);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cantidad.MaxLength = 10;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.PasswordChar = '\0';
            this.Cantidad.PromptText = "Cantidad";
            this.Cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Cantidad.SelectedText = "";
            this.Cantidad.SelectionLength = 0;
            this.Cantidad.SelectionStart = 0;
            this.Cantidad.ShortcutsEnabled = true;
            this.Cantidad.Size = new System.Drawing.Size(152, 28);
            this.Cantidad.TabIndex = 2;
            this.Cantidad.UseSelectable = true;
            this.Cantidad.WaterMark = "Cantidad";
            this.Cantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Cantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 357);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 20);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Cantidad:";
            // 
            // BorrarTile
            // 
            this.BorrarTile.ActiveControl = null;
            this.BorrarTile.BackColor = System.Drawing.Color.OrangeRed;
            this.BorrarTile.Location = new System.Drawing.Point(699, 650);
            this.BorrarTile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BorrarTile.Name = "BorrarTile";
            this.BorrarTile.Size = new System.Drawing.Size(112, 54);
            this.BorrarTile.TabIndex = 8;
            this.BorrarTile.Text = "Borrar";
            this.BorrarTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarTile.TileImage = ((System.Drawing.Image)(resources.GetObject("BorrarTile.TileImage")));
            this.BorrarTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarTile.UseCustomBackColor = true;
            this.BorrarTile.UseSelectable = true;
            this.BorrarTile.UseTileImage = true;
            this.BorrarTile.Click += new System.EventHandler(this.BorrarTile_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 417);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(139, 20);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Carrito de productos:";
            // 
            // ItemsDGV
            // 
            this.ItemsDGV.AllowUserToAddRows = false;
            this.ItemsDGV.AllowUserToDeleteRows = false;
            this.ItemsDGV.AllowUserToResizeRows = false;
            this.ItemsDGV.BackgroundColor = System.Drawing.Color.DarkGray;
            this.ItemsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ItemsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ItemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.ItemsDGV.EnableHeadersVisualStyles = false;
            this.ItemsDGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ItemsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ItemsDGV.Location = new System.Drawing.Point(23, 443);
            this.ItemsDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsDGV.MultiSelect = false;
            this.ItemsDGV.Name = "ItemsDGV";
            this.ItemsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ItemsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ItemsDGV.RowTemplate.Height = 24;
            this.ItemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDGV.Size = new System.Drawing.Size(788, 202);
            this.ItemsDGV.TabIndex = 19;
            this.ItemsDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ItemsDGV_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IDStock";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 82;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 78;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 67;
            // 
            // FinalizarTile
            // 
            this.FinalizarTile.ActiveControl = null;
            this.FinalizarTile.BackColor = System.Drawing.Color.BlueViolet;
            this.FinalizarTile.Location = new System.Drawing.Point(679, 758);
            this.FinalizarTile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FinalizarTile.Name = "FinalizarTile";
            this.FinalizarTile.Size = new System.Drawing.Size(132, 54);
            this.FinalizarTile.TabIndex = 6;
            this.FinalizarTile.Text = "Finalizar";
            this.FinalizarTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FinalizarTile.TileImage = ((System.Drawing.Image)(resources.GetObject("FinalizarTile.TileImage")));
            this.FinalizarTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FinalizarTile.UseCustomBackColor = true;
            this.FinalizarTile.UseSelectable = true;
            this.FinalizarTile.UseTileImage = true;
            this.FinalizarTile.Click += new System.EventHandler(this.FinalizarTile_Click);
            // 
            // MontoACobrarLabel
            // 
            this.MontoACobrarLabel.AutoSize = true;
            this.MontoACobrarLabel.Location = new System.Drawing.Point(24, 721);
            this.MontoACobrarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MontoACobrarLabel.Name = "MontoACobrarLabel";
            this.MontoACobrarLabel.Size = new System.Drawing.Size(133, 20);
            this.MontoACobrarLabel.TabIndex = 22;
            this.MontoACobrarLabel.Text = "MontoACobrarLabel";
            // 
            // montoAPagarDelPedido
            // 
            // 
            // 
            // 
            this.montoAPagarDelPedido.CustomButton.Image = null;
            this.montoAPagarDelPedido.CustomButton.Location = new System.Drawing.Point(168, 2);
            this.montoAPagarDelPedido.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.montoAPagarDelPedido.CustomButton.Name = "";
            this.montoAPagarDelPedido.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.montoAPagarDelPedido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.montoAPagarDelPedido.CustomButton.TabIndex = 1;
            this.montoAPagarDelPedido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.montoAPagarDelPedido.CustomButton.UseSelectable = true;
            this.montoAPagarDelPedido.CustomButton.Visible = false;
            this.montoAPagarDelPedido.DisplayIcon = true;
            this.montoAPagarDelPedido.Lines = new string[0];
            this.montoAPagarDelPedido.Location = new System.Drawing.Point(393, 747);
            this.montoAPagarDelPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.montoAPagarDelPedido.MaxLength = 12;
            this.montoAPagarDelPedido.Name = "montoAPagarDelPedido";
            this.montoAPagarDelPedido.PasswordChar = '\0';
            this.montoAPagarDelPedido.PromptText = "Cantidad";
            this.montoAPagarDelPedido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.montoAPagarDelPedido.SelectedText = "";
            this.montoAPagarDelPedido.SelectionLength = 0;
            this.montoAPagarDelPedido.SelectionStart = 0;
            this.montoAPagarDelPedido.ShortcutsEnabled = true;
            this.montoAPagarDelPedido.Size = new System.Drawing.Size(152, 28);
            this.montoAPagarDelPedido.TabIndex = 4;
            this.montoAPagarDelPedido.UseSelectable = true;
            this.montoAPagarDelPedido.WaterMark = "Cantidad";
            this.montoAPagarDelPedido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.montoAPagarDelPedido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.montoAPagarDelPedido.TextChanged += new System.EventHandler(this.montoAPagarDelPedido_TextChanged);
            this.montoAPagarDelPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montoAPagarDelPedido_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 747);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(286, 20);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "¿Cuanto le va a costar este pedido al cliente?";
            // 
            // cantidadPagada
            // 
            // 
            // 
            // 
            this.cantidadPagada.CustomButton.Image = null;
            this.cantidadPagada.CustomButton.Location = new System.Drawing.Point(168, 2);
            this.cantidadPagada.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantidadPagada.CustomButton.Name = "";
            this.cantidadPagada.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.cantidadPagada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cantidadPagada.CustomButton.TabIndex = 1;
            this.cantidadPagada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cantidadPagada.CustomButton.UseSelectable = true;
            this.cantidadPagada.CustomButton.Visible = false;
            this.cantidadPagada.DisplayIcon = true;
            this.cantidadPagada.Lines = new string[0];
            this.cantidadPagada.Location = new System.Drawing.Point(360, 783);
            this.cantidadPagada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantidadPagada.MaxLength = 12;
            this.cantidadPagada.Name = "cantidadPagada";
            this.cantidadPagada.PasswordChar = '\0';
            this.cantidadPagada.PromptText = "Cantidad";
            this.cantidadPagada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cantidadPagada.SelectedText = "";
            this.cantidadPagada.SelectionLength = 0;
            this.cantidadPagada.SelectionStart = 0;
            this.cantidadPagada.ShortcutsEnabled = true;
            this.cantidadPagada.Size = new System.Drawing.Size(152, 28);
            this.cantidadPagada.TabIndex = 5;
            this.cantidadPagada.UseSelectable = true;
            this.cantidadPagada.WaterMark = "Cantidad";
            this.cantidadPagada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cantidadPagada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cantidadPagada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montoAPagarDelPedido_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 783);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(255, 20);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Monto que el cliente paga/deja pagado:";
            // 
            // AddProductoAPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 820);
            this.Controls.Add(this.cantidadPagada);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.montoAPagarDelPedido);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.MontoACobrarLabel);
            this.Controls.Add(this.FinalizarTile);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ItemsDGV);
            this.Controls.Add(this.BorrarTile);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.AgregarTile);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.ProductosDGV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AddProductoAPedido";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Agregar Productos";
            this.Load += new System.EventHandler(this.AddProductoAPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid ProductosDGV;
        private MetroFramework.Controls.MetroTile AtrasTile;
        private MetroFramework.Controls.MetroTextBox Nombre;
        private MetroFramework.Controls.MetroLabel nombreLabel;
        private MetroFramework.Controls.MetroTile AgregarTile;
        private MetroFramework.Controls.MetroTextBox Cantidad;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile BorrarTile;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid ItemsDGV;
        private MetroFramework.Controls.MetroTile FinalizarTile;
        private MetroFramework.Controls.MetroLabel MontoACobrarLabel;
        private MetroFramework.Controls.MetroTextBox montoAPagarDelPedido;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox cantidadPagada;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}