namespace Sesedublo_SLPL.Administrar_Stock
{
    partial class AddProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Utilidad = new System.Windows.Forms.TextBox();
            this.CantidadLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UtilidadLabel = new System.Windows.Forms.Label();
            this.CostoLabel = new System.Windows.Forms.Label();
            this.Costo = new System.Windows.Forms.TextBox();
            this.UnidadesXBultoLbl = new System.Windows.Forms.Label();
            this.UnidadesXBulto = new System.Windows.Forms.ComboBox();
            this.individualRadio = new MetroFramework.Controls.MetroRadioButton();
            this.bultoRadio = new MetroFramework.Controls.MetroRadioButton();
            this.titleCancelar = new MetroFramework.Controls.MetroTile();
            this.titleAceptar = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.buscarProducto = new MetroFramework.Controls.MetroTextBox();
            this.nombreLabel = new MetroFramework.Controls.MetroLabel();
            this.dgvProductos = new MetroFramework.Controls.MetroGrid();
            this.nuevoProducto = new MetroFramework.Controls.MetroTile();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(181, 180);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.Cantidad.MaxLength = 5;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(100, 20);
            this.Cantidad.TabIndex = 5;
            this.Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_KeyPress);
            // 
            // Nombre
            // 
            this.Nombre.Enabled = false;
            this.Nombre.Location = new System.Drawing.Point(137, 81);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre.MaxLength = 100;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(192, 20);
            this.Nombre.TabIndex = 1;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // Utilidad
            // 
            this.Utilidad.Location = new System.Drawing.Point(181, 206);
            this.Utilidad.Margin = new System.Windows.Forms.Padding(4);
            this.Utilidad.MaxLength = 10;
            this.Utilidad.Name = "Utilidad";
            this.Utilidad.Size = new System.Drawing.Size(100, 20);
            this.Utilidad.TabIndex = 6;
            this.Utilidad.TextChanged += new System.EventHandler(this.Utilidad_TextChanged);
            this.Utilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_KeyPress);
            // 
            // CantidadLbl
            // 
            this.CantidadLbl.AutoSize = true;
            this.CantidadLbl.Location = new System.Drawing.Point(23, 183);
            this.CantidadLbl.Name = "CantidadLbl";
            this.CantidadLbl.Size = new System.Drawing.Size(52, 13);
            this.CantidadLbl.TabIndex = 6;
            this.CantidadLbl.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del producto:";
            // 
            // UtilidadLabel
            // 
            this.UtilidadLabel.AutoSize = true;
            this.UtilidadLabel.Location = new System.Drawing.Point(23, 209);
            this.UtilidadLabel.Name = "UtilidadLabel";
            this.UtilidadLabel.Size = new System.Drawing.Size(98, 13);
            this.UtilidadLabel.TabIndex = 8;
            this.UtilidadLabel.Text = "Utilidad por unidad:";
            // 
            // CostoLabel
            // 
            this.CostoLabel.AutoSize = true;
            this.CostoLabel.Location = new System.Drawing.Point(23, 157);
            this.CostoLabel.Name = "CostoLabel";
            this.CostoLabel.Size = new System.Drawing.Size(37, 13);
            this.CostoLabel.TabIndex = 10;
            this.CostoLabel.Text = "Costo:";
            // 
            // Costo
            // 
            this.Costo.Location = new System.Drawing.Point(181, 154);
            this.Costo.Margin = new System.Windows.Forms.Padding(4);
            this.Costo.MaxLength = 12;
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(100, 20);
            this.Costo.TabIndex = 2;
            this.Costo.TextChanged += new System.EventHandler(this.Costo_TextChanged);
            this.Costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Costo_KeyPress);
            // 
            // UnidadesXBultoLbl
            // 
            this.UnidadesXBultoLbl.AutoSize = true;
            this.UnidadesXBultoLbl.Location = new System.Drawing.Point(23, 260);
            this.UnidadesXBultoLbl.Name = "UnidadesXBultoLbl";
            this.UnidadesXBultoLbl.Size = new System.Drawing.Size(98, 13);
            this.UnidadesXBultoLbl.TabIndex = 14;
            this.UnidadesXBultoLbl.Text = "Unidades del bulto:";
            // 
            // UnidadesXBulto
            // 
            this.UnidadesXBulto.FormattingEnabled = true;
            this.UnidadesXBulto.Items.AddRange(new object[] {
            "6",
            "12",
            "24"});
            this.UnidadesXBulto.Location = new System.Drawing.Point(181, 257);
            this.UnidadesXBulto.Margin = new System.Windows.Forms.Padding(4);
            this.UnidadesXBulto.Name = "UnidadesXBulto";
            this.UnidadesXBulto.Size = new System.Drawing.Size(100, 21);
            this.UnidadesXBulto.TabIndex = 7;
            this.UnidadesXBulto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_KeyPress);
            // 
            // individualRadio
            // 
            this.individualRadio.AutoSize = true;
            this.individualRadio.Location = new System.Drawing.Point(77, 116);
            this.individualRadio.Margin = new System.Windows.Forms.Padding(2);
            this.individualRadio.Name = "individualRadio";
            this.individualRadio.Size = new System.Drawing.Size(75, 15);
            this.individualRadio.TabIndex = 3;
            this.individualRadio.Text = "Individual";
            this.individualRadio.UseSelectable = true;
            this.individualRadio.CheckedChanged += new System.EventHandler(this.individualRadio_CheckedChanged);
            // 
            // bultoRadio
            // 
            this.bultoRadio.AutoSize = true;
            this.bultoRadio.Location = new System.Drawing.Point(166, 116);
            this.bultoRadio.Margin = new System.Windows.Forms.Padding(2);
            this.bultoRadio.Name = "bultoRadio";
            this.bultoRadio.Size = new System.Drawing.Size(51, 15);
            this.bultoRadio.TabIndex = 4;
            this.bultoRadio.Text = "Bulto";
            this.bultoRadio.UseSelectable = true;
            // 
            // titleCancelar
            // 
            this.titleCancelar.ActiveControl = null;
            this.titleCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.titleCancelar.Location = new System.Drawing.Point(26, 336);
            this.titleCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.titleCancelar.Name = "titleCancelar";
            this.titleCancelar.Size = new System.Drawing.Size(102, 41);
            this.titleCancelar.TabIndex = 9;
            this.titleCancelar.Text = "Cancelar";
            this.titleCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleCancelar.TileImage = ((System.Drawing.Image)(resources.GetObject("titleCancelar.TileImage")));
            this.titleCancelar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleCancelar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleCancelar.UseCustomBackColor = true;
            this.titleCancelar.UseSelectable = true;
            this.titleCancelar.UseTileImage = true;
            this.titleCancelar.Click += new System.EventHandler(this.AtrasBtn_Click);
            // 
            // titleAceptar
            // 
            this.titleAceptar.ActiveControl = null;
            this.titleAceptar.BackColor = System.Drawing.Color.Green;
            this.titleAceptar.Location = new System.Drawing.Point(184, 336);
            this.titleAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.titleAceptar.Name = "titleAceptar";
            this.titleAceptar.Size = new System.Drawing.Size(99, 41);
            this.titleAceptar.TabIndex = 8;
            this.titleAceptar.Text = "Aceptar";
            this.titleAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleAceptar.TileImage = ((System.Drawing.Image)(resources.GetObject("titleAceptar.TileImage")));
            this.titleAceptar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleAceptar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleAceptar.UseCustomBackColor = true;
            this.titleAceptar.UseSelectable = true;
            this.titleAceptar.UseTileImage = true;
            this.titleAceptar.Click += new System.EventHandler(this.AgregarProductoBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(336, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Lista de Productos";
            // 
            // buscarProducto
            // 
            // 
            // 
            // 
            this.buscarProducto.CustomButton.Image = null;
            this.buscarProducto.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.buscarProducto.CustomButton.Name = "";
            this.buscarProducto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.buscarProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.buscarProducto.CustomButton.TabIndex = 1;
            this.buscarProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buscarProducto.CustomButton.UseSelectable = true;
            this.buscarProducto.CustomButton.Visible = false;
            this.buscarProducto.DisplayIcon = true;
            this.buscarProducto.Icon = ((System.Drawing.Image)(resources.GetObject("buscarProducto.Icon")));
            this.buscarProducto.Lines = new string[0];
            this.buscarProducto.Location = new System.Drawing.Point(545, 27);
            this.buscarProducto.MaxLength = 70;
            this.buscarProducto.Name = "buscarProducto";
            this.buscarProducto.PasswordChar = '\0';
            this.buscarProducto.PromptText = "Buscar";
            this.buscarProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.buscarProducto.SelectedText = "";
            this.buscarProducto.SelectionLength = 0;
            this.buscarProducto.SelectionStart = 0;
            this.buscarProducto.ShortcutsEnabled = true;
            this.buscarProducto.Size = new System.Drawing.Size(114, 23);
            this.buscarProducto.TabIndex = 18;
            this.buscarProducto.UseSelectable = true;
            this.buscarProducto.WaterMark = "Buscar";
            this.buscarProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.buscarProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.buscarProducto.TextChanged += new System.EventHandler(this.buscadorProducto_TextChanged);
            this.buscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(477, 27);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(62, 19);
            this.nombreLabel.TabIndex = 17;
            this.nombreLabel.Text = "Nombre:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProductos.Location = new System.Drawing.Point(336, 64);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(363, 266);
            this.dgvProductos.TabIndex = 19;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // nuevoProducto
            // 
            this.nuevoProducto.ActiveControl = null;
            this.nuevoProducto.BackColor = System.Drawing.Color.MediumBlue;
            this.nuevoProducto.Location = new System.Drawing.Point(550, 336);
            this.nuevoProducto.Name = "nuevoProducto";
            this.nuevoProducto.Size = new System.Drawing.Size(149, 43);
            this.nuevoProducto.TabIndex = 20;
            this.nuevoProducto.Text = "Nuevo Producto";
            this.nuevoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevoProducto.TileImage = ((System.Drawing.Image)(resources.GetObject("nuevoProducto.TileImage")));
            this.nuevoProducto.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoProducto.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.nuevoProducto.UseCustomBackColor = true;
            this.nuevoProducto.UseSelectable = true;
            this.nuevoProducto.UseTileImage = true;
            this.nuevoProducto.Click += new System.EventHandler(this.nuevoProducto_Click);
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Location = new System.Drawing.Point(23, 234);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(40, 13);
            this.PrecioLabel.TabIndex = 31;
            this.PrecioLabel.Text = "Precio:";
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(181, 231);
            this.Precio.Margin = new System.Windows.Forms.Padding(4);
            this.Precio.MaxLength = 10;
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(100, 20);
            this.Precio.TabIndex = 30;
            // 
            // AddProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 396);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.nuevoProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.buscarProducto);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.titleCancelar);
            this.Controls.Add(this.titleAceptar);
            this.Controls.Add(this.bultoRadio);
            this.Controls.Add(this.individualRadio);
            this.Controls.Add(this.UnidadesXBulto);
            this.Controls.Add(this.UnidadesXBultoLbl);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.CostoLabel);
            this.Controls.Add(this.UtilidadLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CantidadLbl);
            this.Controls.Add(this.Utilidad);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Cantidad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProducto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.AddProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Utilidad;
        private System.Windows.Forms.Label CantidadLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UtilidadLabel;
        private System.Windows.Forms.Label CostoLabel;
        private System.Windows.Forms.TextBox Costo;
        private System.Windows.Forms.Label UnidadesXBultoLbl;
        private System.Windows.Forms.ComboBox UnidadesXBulto;
        private MetroFramework.Controls.MetroRadioButton individualRadio;
        private MetroFramework.Controls.MetroRadioButton bultoRadio;
        private MetroFramework.Controls.MetroTile titleCancelar;
        private MetroFramework.Controls.MetroTile titleAceptar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox buscarProducto;
        private MetroFramework.Controls.MetroLabel nombreLabel;
        private MetroFramework.Controls.MetroGrid dgvProductos;
        private MetroFramework.Controls.MetroTile nuevoProducto;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.TextBox Precio;
    }
}