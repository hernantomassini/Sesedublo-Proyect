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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductoAPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductosDGV = new MetroFramework.Controls.MetroGrid();
            this.IDStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelarTile = new MetroFramework.Controls.MetroTile();
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
            this.ProductosDGV.BackgroundColor = System.Drawing.Color.Black;
            this.ProductosDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.ProductosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDStock,
            this.CantidadProductos,
            this.NombreProducto,
            this.PrecioProducto});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductosDGV.DefaultCellStyle = dataGridViewCellStyle14;
            this.ProductosDGV.EnableHeadersVisualStyles = false;
            this.ProductosDGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductosDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductosDGV.Location = new System.Drawing.Point(17, 113);
            this.ProductosDGV.Margin = new System.Windows.Forms.Padding(2);
            this.ProductosDGV.MultiSelect = false;
            this.ProductosDGV.Name = "ProductosDGV";
            this.ProductosDGV.ReadOnly = true;
            this.ProductosDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductosDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.ProductosDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductosDGV.RowTemplate.Height = 24;
            this.ProductosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductosDGV.Size = new System.Drawing.Size(591, 168);
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
            this.CantidadProductos.Width = 77;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreProducto.Width = 71;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PrecioProducto.HeaderText = "Precio";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            this.PrecioProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecioProducto.Width = 61;
            // 
            // CancelarTile
            // 
            this.CancelarTile.ActiveControl = null;
            this.CancelarTile.Location = new System.Drawing.Point(18, 528);
            this.CancelarTile.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarTile.Name = "CancelarTile";
            this.CancelarTile.Size = new System.Drawing.Size(84, 44);
            this.CancelarTile.TabIndex = 2;
            this.CancelarTile.Text = "Cancelar";
            this.CancelarTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarTile.UseSelectable = true;
            this.CancelarTile.Click += new System.EventHandler(this.CancelarTile_Click);
            // 
            // Nombre
            // 
            // 
            // 
            // 
            this.Nombre.CustomButton.Image = null;
            this.Nombre.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.Nombre.CustomButton.Name = "";
            this.Nombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Nombre.CustomButton.TabIndex = 1;
            this.Nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Nombre.CustomButton.UseSelectable = true;
            this.Nombre.CustomButton.Visible = false;
            this.Nombre.DisplayIcon = true;
            this.Nombre.Icon = ((System.Drawing.Image)(resources.GetObject("Nombre.Icon")));
            this.Nombre.Lines = new string[0];
            this.Nombre.Location = new System.Drawing.Point(85, 85);
            this.Nombre.MaxLength = 32767;
            this.Nombre.Name = "Nombre";
            this.Nombre.PasswordChar = '\0';
            this.Nombre.PromptText = "Buscar";
            this.Nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Nombre.SelectedText = "";
            this.Nombre.SelectionLength = 0;
            this.Nombre.SelectionStart = 0;
            this.Nombre.ShortcutsEnabled = true;
            this.Nombre.Size = new System.Drawing.Size(114, 23);
            this.Nombre.TabIndex = 14;
            this.Nombre.UseSelectable = true;
            this.Nombre.WaterMark = "Buscar";
            this.Nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(17, 85);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(62, 19);
            this.nombreLabel.TabIndex = 13;
            this.nombreLabel.Text = "Nombre:";
            // 
            // AgregarTile
            // 
            this.AgregarTile.ActiveControl = null;
            this.AgregarTile.Location = new System.Drawing.Point(524, 286);
            this.AgregarTile.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarTile.Name = "AgregarTile";
            this.AgregarTile.Size = new System.Drawing.Size(84, 44);
            this.AgregarTile.TabIndex = 15;
            this.AgregarTile.Text = "Agregar";
            this.AgregarTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarTile.UseSelectable = true;
            this.AgregarTile.Click += new System.EventHandler(this.AgregarTile_Click);
            // 
            // Cantidad
            // 
            // 
            // 
            // 
            this.Cantidad.CustomButton.Image = null;
            this.Cantidad.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.Cantidad.CustomButton.Name = "";
            this.Cantidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Cantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Cantidad.CustomButton.TabIndex = 1;
            this.Cantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Cantidad.CustomButton.UseSelectable = true;
            this.Cantidad.CustomButton.Visible = false;
            this.Cantidad.DisplayIcon = true;
            this.Cantidad.Lines = new string[0];
            this.Cantidad.Location = new System.Drawing.Point(89, 286);
            this.Cantidad.MaxLength = 5;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.PasswordChar = '\0';
            this.Cantidad.PromptText = "Cantidad";
            this.Cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Cantidad.SelectedText = "";
            this.Cantidad.SelectionLength = 0;
            this.Cantidad.SelectionStart = 0;
            this.Cantidad.ShortcutsEnabled = true;
            this.Cantidad.Size = new System.Drawing.Size(114, 23);
            this.Cantidad.TabIndex = 17;
            this.Cantidad.UseSelectable = true;
            this.Cantidad.WaterMark = "Cantidad";
            this.Cantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Cantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(18, 290);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Cantidad:";
            // 
            // BorrarTile
            // 
            this.BorrarTile.ActiveControl = null;
            this.BorrarTile.Location = new System.Drawing.Point(524, 528);
            this.BorrarTile.Margin = new System.Windows.Forms.Padding(2);
            this.BorrarTile.Name = "BorrarTile";
            this.BorrarTile.Size = new System.Drawing.Size(84, 44);
            this.BorrarTile.TabIndex = 18;
            this.BorrarTile.Text = "Borrar";
            this.BorrarTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarTile.UseSelectable = true;
            this.BorrarTile.Click += new System.EventHandler(this.BorrarTile_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 339);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(135, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Carrito de productos:";
            // 
            // ItemsDGV
            // 
            this.ItemsDGV.AllowUserToAddRows = false;
            this.ItemsDGV.AllowUserToDeleteRows = false;
            this.ItemsDGV.AllowUserToResizeRows = false;
            this.ItemsDGV.BackgroundColor = System.Drawing.Color.Black;
            this.ItemsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ItemsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.ItemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsDGV.DefaultCellStyle = dataGridViewCellStyle17;
            this.ItemsDGV.EnableHeadersVisualStyles = false;
            this.ItemsDGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ItemsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ItemsDGV.Location = new System.Drawing.Point(17, 360);
            this.ItemsDGV.Margin = new System.Windows.Forms.Padding(2);
            this.ItemsDGV.MultiSelect = false;
            this.ItemsDGV.Name = "ItemsDGV";
            this.ItemsDGV.ReadOnly = true;
            this.ItemsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.ItemsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ItemsDGV.RowTemplate.Height = 24;
            this.ItemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDGV.Size = new System.Drawing.Size(591, 164);
            this.ItemsDGV.TabIndex = 19;
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
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 71;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 61;
            // 
            // FinalizarTile
            // 
            this.FinalizarTile.ActiveControl = null;
            this.FinalizarTile.Location = new System.Drawing.Point(524, 616);
            this.FinalizarTile.Margin = new System.Windows.Forms.Padding(2);
            this.FinalizarTile.Name = "FinalizarTile";
            this.FinalizarTile.Size = new System.Drawing.Size(84, 44);
            this.FinalizarTile.TabIndex = 21;
            this.FinalizarTile.Text = "Finalizar";
            this.FinalizarTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FinalizarTile.UseSelectable = true;
            this.FinalizarTile.Click += new System.EventHandler(this.FinalizarTile_Click);
            // 
            // MontoACobrarLabel
            // 
            this.MontoACobrarLabel.AutoSize = true;
            this.MontoACobrarLabel.Location = new System.Drawing.Point(18, 586);
            this.MontoACobrarLabel.Name = "MontoACobrarLabel";
            this.MontoACobrarLabel.Size = new System.Drawing.Size(130, 19);
            this.MontoACobrarLabel.TabIndex = 22;
            this.MontoACobrarLabel.Text = "MontoACobrarLabel";
            // 
            // montoAPagarDelPedido
            // 
            // 
            // 
            // 
            this.montoAPagarDelPedido.CustomButton.Image = null;
            this.montoAPagarDelPedido.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.montoAPagarDelPedido.CustomButton.Name = "";
            this.montoAPagarDelPedido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.montoAPagarDelPedido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.montoAPagarDelPedido.CustomButton.TabIndex = 1;
            this.montoAPagarDelPedido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.montoAPagarDelPedido.CustomButton.UseSelectable = true;
            this.montoAPagarDelPedido.CustomButton.Visible = false;
            this.montoAPagarDelPedido.DisplayIcon = true;
            this.montoAPagarDelPedido.Lines = new string[0];
            this.montoAPagarDelPedido.Location = new System.Drawing.Point(295, 607);
            this.montoAPagarDelPedido.MaxLength = 5;
            this.montoAPagarDelPedido.Name = "montoAPagarDelPedido";
            this.montoAPagarDelPedido.PasswordChar = '\0';
            this.montoAPagarDelPedido.PromptText = "Cantidad";
            this.montoAPagarDelPedido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.montoAPagarDelPedido.SelectedText = "";
            this.montoAPagarDelPedido.SelectionLength = 0;
            this.montoAPagarDelPedido.SelectionStart = 0;
            this.montoAPagarDelPedido.ShortcutsEnabled = true;
            this.montoAPagarDelPedido.Size = new System.Drawing.Size(114, 23);
            this.montoAPagarDelPedido.TabIndex = 25;
            this.montoAPagarDelPedido.UseSelectable = true;
            this.montoAPagarDelPedido.WaterMark = "Cantidad";
            this.montoAPagarDelPedido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.montoAPagarDelPedido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 607);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(272, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "¿Cuanto le va a costar este pedido al cliente?";
            // 
            // cantidadPagada
            // 
            // 
            // 
            // 
            this.cantidadPagada.CustomButton.Image = null;
            this.cantidadPagada.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.cantidadPagada.CustomButton.Name = "";
            this.cantidadPagada.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cantidadPagada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cantidadPagada.CustomButton.TabIndex = 1;
            this.cantidadPagada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cantidadPagada.CustomButton.UseSelectable = true;
            this.cantidadPagada.CustomButton.Visible = false;
            this.cantidadPagada.DisplayIcon = true;
            this.cantidadPagada.Lines = new string[0];
            this.cantidadPagada.Location = new System.Drawing.Point(270, 636);
            this.cantidadPagada.MaxLength = 5;
            this.cantidadPagada.Name = "cantidadPagada";
            this.cantidadPagada.PasswordChar = '\0';
            this.cantidadPagada.PromptText = "Cantidad";
            this.cantidadPagada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cantidadPagada.SelectedText = "";
            this.cantidadPagada.SelectionLength = 0;
            this.cantidadPagada.SelectionStart = 0;
            this.cantidadPagada.ShortcutsEnabled = true;
            this.cantidadPagada.Size = new System.Drawing.Size(114, 23);
            this.cantidadPagada.TabIndex = 27;
            this.cantidadPagada.UseSelectable = true;
            this.cantidadPagada.WaterMark = "Cantidad";
            this.cantidadPagada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cantidadPagada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 636);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(246, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Monto que el cliente paga/deja pagado:";
            // 
            // AddProductoAPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 678);
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
            this.Controls.Add(this.CancelarTile);
            this.Controls.Add(this.ProductosDGV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddProductoAPedido";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Agregar Productos";
            this.Load += new System.EventHandler(this.AddProductoAPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid ProductosDGV;
        private MetroFramework.Controls.MetroTile CancelarTile;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private MetroFramework.Controls.MetroTextBox Nombre;
        private MetroFramework.Controls.MetroLabel nombreLabel;
        private MetroFramework.Controls.MetroTile AgregarTile;
        private MetroFramework.Controls.MetroTextBox Cantidad;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile BorrarTile;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid ItemsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private MetroFramework.Controls.MetroTile FinalizarTile;
        private MetroFramework.Controls.MetroLabel MontoACobrarLabel;
        private MetroFramework.Controls.MetroTextBox montoAPagarDelPedido;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox cantidadPagada;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}