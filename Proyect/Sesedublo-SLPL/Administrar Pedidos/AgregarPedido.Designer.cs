namespace Sesedublo_SLPL.Administrar_Pedidos
{
    partial class AgregarPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClienteDGV = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ItemsDGV = new MetroFramework.Controls.MetroGrid();
            this.AtrasTile = new MetroFramework.Controls.MetroTile();
            this.AceptarTile = new MetroFramework.Controls.MetroTile();
            this.direccion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.apellido = new MetroFramework.Controls.MetroTextBox();
            this.nombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.AgregarProductoTile = new MetroFramework.Controls.MetroTile();
            this.BorrarProductoTile = new MetroFramework.Controls.MetroTile();
            this.IDStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ClienteDGV
            // 
            this.ClienteDGV.AllowUserToAddRows = false;
            this.ClienteDGV.AllowUserToDeleteRows = false;
            this.ClienteDGV.AllowUserToResizeColumns = false;
            this.ClienteDGV.AllowUserToResizeRows = false;
            this.ClienteDGV.BackgroundColor = System.Drawing.Color.Black;
            this.ClienteDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClienteDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClienteDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClienteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClienteDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClienteDGV.EnableHeadersVisualStyles = false;
            this.ClienteDGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ClienteDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClienteDGV.Location = new System.Drawing.Point(23, 110);
            this.ClienteDGV.MultiSelect = false;
            this.ClienteDGV.Name = "ClienteDGV";
            this.ClienteDGV.ReadOnly = true;
            this.ClienteDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ClienteDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ClienteDGV.RowTemplate.Height = 24;
            this.ClienteDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClienteDGV.Size = new System.Drawing.Size(983, 168);
            this.ClienteDGV.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Seleccione el cliente:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 284);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(165, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Productos que comprará:";
            // 
            // ItemsDGV
            // 
            this.ItemsDGV.AllowUserToAddRows = false;
            this.ItemsDGV.AllowUserToDeleteRows = false;
            this.ItemsDGV.AllowUserToResizeColumns = false;
            this.ItemsDGV.AllowUserToResizeRows = false;
            this.ItemsDGV.BackgroundColor = System.Drawing.Color.Black;
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
            this.IDStock,
            this.CantidadProducto,
            this.NombreProducto,
            this.PrecioProducto});
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
            this.ItemsDGV.Location = new System.Drawing.Point(23, 313);
            this.ItemsDGV.MultiSelect = false;
            this.ItemsDGV.Name = "ItemsDGV";
            this.ItemsDGV.ReadOnly = true;
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
            this.ItemsDGV.Size = new System.Drawing.Size(983, 168);
            this.ItemsDGV.TabIndex = 4;
            // 
            // AtrasTile
            // 
            this.AtrasTile.ActiveControl = null;
            this.AtrasTile.Location = new System.Drawing.Point(23, 506);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(96, 43);
            this.AtrasTile.TabIndex = 5;
            this.AtrasTile.Text = "Atras";
            this.AtrasTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AtrasTile.UseSelectable = true;
            this.AtrasTile.Click += new System.EventHandler(this.AtrasTile_Click);
            // 
            // AceptarTile
            // 
            this.AceptarTile.ActiveControl = null;
            this.AceptarTile.Location = new System.Drawing.Point(918, 506);
            this.AceptarTile.Name = "AceptarTile";
            this.AceptarTile.Size = new System.Drawing.Size(88, 43);
            this.AceptarTile.TabIndex = 6;
            this.AceptarTile.Text = "Siguiente";
            this.AceptarTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarTile.UseSelectable = true;
            this.AceptarTile.Click += new System.EventHandler(this.AceptarTile_Click);
            // 
            // direccion
            // 
            // 
            // 
            // 
            this.direccion.CustomButton.Image = null;
            this.direccion.CustomButton.Location = new System.Drawing.Point(117, 2);
            this.direccion.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.direccion.CustomButton.Name = "";
            this.direccion.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.direccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.direccion.CustomButton.TabIndex = 1;
            this.direccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.direccion.CustomButton.UseSelectable = true;
            this.direccion.CustomButton.Visible = false;
            this.direccion.Lines = new string[0];
            this.direccion.Location = new System.Drawing.Point(853, 64);
            this.direccion.Margin = new System.Windows.Forms.Padding(4);
            this.direccion.MaxLength = 32767;
            this.direccion.Name = "direccion";
            this.direccion.PasswordChar = '\0';
            this.direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.direccion.SelectedText = "";
            this.direccion.SelectionLength = 0;
            this.direccion.SelectionStart = 0;
            this.direccion.ShortcutsEnabled = true;
            this.direccion.Size = new System.Drawing.Size(143, 28);
            this.direccion.TabIndex = 16;
            this.direccion.UseSelectable = true;
            this.direccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.direccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.direccion.TextChanged += new System.EventHandler(this.direccion_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(761, 64);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 20);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Dirección:";
            // 
            // apellido
            // 
            // 
            // 
            // 
            this.apellido.CustomButton.Image = null;
            this.apellido.CustomButton.Location = new System.Drawing.Point(117, 2);
            this.apellido.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.apellido.CustomButton.Name = "";
            this.apellido.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.apellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.apellido.CustomButton.TabIndex = 1;
            this.apellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.apellido.CustomButton.UseSelectable = true;
            this.apellido.CustomButton.Visible = false;
            this.apellido.Lines = new string[0];
            this.apellido.Location = new System.Drawing.Point(595, 64);
            this.apellido.Margin = new System.Windows.Forms.Padding(4);
            this.apellido.MaxLength = 32767;
            this.apellido.Name = "apellido";
            this.apellido.PasswordChar = '\0';
            this.apellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apellido.SelectedText = "";
            this.apellido.SelectionLength = 0;
            this.apellido.SelectionStart = 0;
            this.apellido.ShortcutsEnabled = true;
            this.apellido.Size = new System.Drawing.Size(143, 28);
            this.apellido.TabIndex = 14;
            this.apellido.UseSelectable = true;
            this.apellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.apellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.apellido.TextChanged += new System.EventHandler(this.apellido_TextChanged);
            // 
            // nombre
            // 
            // 
            // 
            // 
            this.nombre.CustomButton.Image = null;
            this.nombre.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.nombre.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.CustomButton.Name = "";
            this.nombre.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nombre.CustomButton.TabIndex = 1;
            this.nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nombre.CustomButton.UseSelectable = true;
            this.nombre.CustomButton.Visible = false;
            this.nombre.Lines = new string[0];
            this.nombre.Location = new System.Drawing.Point(353, 64);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.MaxLength = 32767;
            this.nombre.Name = "nombre";
            this.nombre.PasswordChar = '\0';
            this.nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombre.SelectedText = "";
            this.nombre.SelectionLength = 0;
            this.nombre.SelectionStart = 0;
            this.nombre.ShortcutsEnabled = true;
            this.nombre.Size = new System.Drawing.Size(135, 28);
            this.nombre.TabIndex = 13;
            this.nombre.UseSelectable = true;
            this.nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(510, 64);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 20);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Apellido:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(266, 64);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 20);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Nombre:";
            // 
            // AgregarProductoTile
            // 
            this.AgregarProductoTile.ActiveControl = null;
            this.AgregarProductoTile.Location = new System.Drawing.Point(779, 506);
            this.AgregarProductoTile.Name = "AgregarProductoTile";
            this.AgregarProductoTile.Size = new System.Drawing.Size(133, 43);
            this.AgregarProductoTile.TabIndex = 17;
            this.AgregarProductoTile.Text = "Agregar producto";
            this.AgregarProductoTile.UseSelectable = true;
            this.AgregarProductoTile.Click += new System.EventHandler(this.AgregarProductoTile_Click);
            // 
            // BorrarProductoTile
            // 
            this.BorrarProductoTile.ActiveControl = null;
            this.BorrarProductoTile.Location = new System.Drawing.Point(649, 506);
            this.BorrarProductoTile.Name = "BorrarProductoTile";
            this.BorrarProductoTile.Size = new System.Drawing.Size(124, 43);
            this.BorrarProductoTile.TabIndex = 18;
            this.BorrarProductoTile.Text = "Borrar producto";
            this.BorrarProductoTile.UseSelectable = true;
            this.BorrarProductoTile.Click += new System.EventHandler(this.BorrarProductoTile_Click);
            // 
            // IDStock
            // 
            this.IDStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IDStock.HeaderText = "IDStock";
            this.IDStock.Name = "IDStock";
            this.IDStock.ReadOnly = true;
            this.IDStock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDStock.Visible = false;
            this.IDStock.Width = 74;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CantidadProducto.HeaderText = "Cantidad";
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.ReadOnly = true;
            this.CantidadProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CantidadProducto.Width = 82;
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
            // AgregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 572);
            this.Controls.Add(this.BorrarProductoTile);
            this.Controls.Add(this.AgregarProductoTile);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.AceptarTile);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.ItemsDGV);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ClienteDGV);
            this.Name = "AgregarPedido";
            this.Text = "AgregarPedido";
            this.Load += new System.EventHandler(this.AgregarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid ClienteDGV;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid ItemsDGV;
        private MetroFramework.Controls.MetroTile AtrasTile;
        private MetroFramework.Controls.MetroTile AceptarTile;
        private MetroFramework.Controls.MetroTextBox direccion;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox apellido;
        private MetroFramework.Controls.MetroTextBox nombre;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTile AgregarProductoTile;
        private MetroFramework.Controls.MetroTile BorrarProductoTile;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
    }
}