﻿namespace Sesedublo_SLPL.Pedidos_de_Compra
{
    partial class AddPedidoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPedidoCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductos = new MetroFramework.Controls.MetroGrid();
            this.buscarProducto = new MetroFramework.Controls.MetroTextBox();
            this.nombreLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.titleCancelar = new MetroFramework.Controls.MetroTile();
            this.titleAceptar = new MetroFramework.Controls.MetroTile();
            this.bultoRadio = new MetroFramework.Controls.MetroRadioButton();
            this.individualRadio = new MetroFramework.Controls.MetroRadioButton();
            this.UnidadesXBulto = new System.Windows.Forms.ComboBox();
            this.UnidadesXBultoLbl = new System.Windows.Forms.Label();
            this.Costo = new System.Windows.Forms.TextBox();
            this.CostoLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CantidadLbl = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.dgvPedido = new MetroFramework.Controls.MetroGrid();
            this.agregarBtn = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.eliminarBtn = new MetroFramework.Controls.MetroTile();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProductos.Location = new System.Drawing.Point(27, 260);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(438, 327);
            this.dgvProductos.TabIndex = 37;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // buscarProducto
            // 
            // 
            // 
            // 
            this.buscarProducto.CustomButton.Image = null;
            this.buscarProducto.CustomButton.Location = new System.Drawing.Point(95, 2);
            this.buscarProducto.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.buscarProducto.CustomButton.Name = "";
            this.buscarProducto.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.buscarProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.buscarProducto.CustomButton.TabIndex = 1;
            this.buscarProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buscarProducto.CustomButton.UseSelectable = true;
            this.buscarProducto.CustomButton.Visible = false;
            this.buscarProducto.DisplayIcon = true;
            this.buscarProducto.Icon = ((System.Drawing.Image)(resources.GetObject("buscarProducto.Icon")));
            this.buscarProducto.Lines = new string[0];
            this.buscarProducto.Location = new System.Drawing.Point(247, 213);
            this.buscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.buscarProducto.MaxLength = 70;
            this.buscarProducto.Name = "buscarProducto";
            this.buscarProducto.PasswordChar = '\0';
            this.buscarProducto.PromptText = "Buscar";
            this.buscarProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.buscarProducto.SelectedText = "";
            this.buscarProducto.SelectionLength = 0;
            this.buscarProducto.SelectionStart = 0;
            this.buscarProducto.ShortcutsEnabled = true;
            this.buscarProducto.Size = new System.Drawing.Size(121, 28);
            this.buscarProducto.TabIndex = 36;
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
            this.nombreLabel.Location = new System.Drawing.Point(180, 218);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(64, 20);
            this.nombreLabel.TabIndex = 35;
            this.nombreLabel.Text = "Nombre:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 218);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 20);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Lista de Productos";
            // 
            // titleCancelar
            // 
            this.titleCancelar.ActiveControl = null;
            this.titleCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.titleCancelar.Location = new System.Drawing.Point(762, 608);
            this.titleCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.titleCancelar.Name = "titleCancelar";
            this.titleCancelar.Size = new System.Drawing.Size(136, 50);
            this.titleCancelar.TabIndex = 31;
            this.titleCancelar.Text = "Cancelar";
            this.titleCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleCancelar.TileImage = ((System.Drawing.Image)(resources.GetObject("titleCancelar.TileImage")));
            this.titleCancelar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleCancelar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleCancelar.UseCustomBackColor = true;
            this.titleCancelar.UseSelectable = true;
            this.titleCancelar.UseTileImage = true;
            // 
            // titleAceptar
            // 
            this.titleAceptar.ActiveControl = null;
            this.titleAceptar.BackColor = System.Drawing.Color.Green;
            this.titleAceptar.Location = new System.Drawing.Point(926, 608);
            this.titleAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.titleAceptar.Name = "titleAceptar";
            this.titleAceptar.Size = new System.Drawing.Size(132, 50);
            this.titleAceptar.TabIndex = 30;
            this.titleAceptar.Text = "Aceptar";
            this.titleAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleAceptar.TileImage = ((System.Drawing.Image)(resources.GetObject("titleAceptar.TileImage")));
            this.titleAceptar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleAceptar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleAceptar.UseCustomBackColor = true;
            this.titleAceptar.UseSelectable = true;
            this.titleAceptar.UseTileImage = true;
            this.titleAceptar.Click += new System.EventHandler(this.titleAceptar_Click);
            // 
            // bultoRadio
            // 
            this.bultoRadio.AutoSize = true;
            this.bultoRadio.Location = new System.Drawing.Point(218, 118);
            this.bultoRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bultoRadio.Name = "bultoRadio";
            this.bultoRadio.Size = new System.Drawing.Size(53, 17);
            this.bultoRadio.TabIndex = 23;
            this.bultoRadio.Text = "Bulto";
            this.bultoRadio.UseSelectable = true;
            // 
            // individualRadio
            // 
            this.individualRadio.AutoSize = true;
            this.individualRadio.Location = new System.Drawing.Point(100, 118);
            this.individualRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.individualRadio.Name = "individualRadio";
            this.individualRadio.Size = new System.Drawing.Size(79, 17);
            this.individualRadio.TabIndex = 22;
            this.individualRadio.Text = "Individual";
            this.individualRadio.UseSelectable = true;
            this.individualRadio.CheckedChanged += new System.EventHandler(this.individualRadio_CheckedChanged);
            // 
            // UnidadesXBulto
            // 
            this.UnidadesXBulto.FormattingEnabled = true;
            this.UnidadesXBulto.Items.AddRange(new object[] {
            "6",
            "12",
            "24"});
            this.UnidadesXBulto.Location = new System.Drawing.Point(617, 179);
            this.UnidadesXBulto.Margin = new System.Windows.Forms.Padding(5);
            this.UnidadesXBulto.Name = "UnidadesXBulto";
            this.UnidadesXBulto.Size = new System.Drawing.Size(132, 24);
            this.UnidadesXBulto.TabIndex = 28;
            // 
            // UnidadesXBultoLbl
            // 
            this.UnidadesXBultoLbl.AutoSize = true;
            this.UnidadesXBultoLbl.Location = new System.Drawing.Point(465, 182);
            this.UnidadesXBultoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnidadesXBultoLbl.Name = "UnidadesXBultoLbl";
            this.UnidadesXBultoLbl.Size = new System.Drawing.Size(130, 17);
            this.UnidadesXBultoLbl.TabIndex = 33;
            this.UnidadesXBultoLbl.Text = "Unidades del bulto:";
            // 
            // Costo
            // 
            this.Costo.Location = new System.Drawing.Point(617, 77);
            this.Costo.Margin = new System.Windows.Forms.Padding(5);
            this.Costo.MaxLength = 12;
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(132, 22);
            this.Costo.TabIndex = 21;
            this.Costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Costo_KeyPress);
            // 
            // CostoLabel
            // 
            this.CostoLabel.AutoSize = true;
            this.CostoLabel.Location = new System.Drawing.Point(465, 80);
            this.CostoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostoLabel.Name = "CostoLabel";
            this.CostoLabel.Size = new System.Drawing.Size(48, 17);
            this.CostoLabel.TabIndex = 32;
            this.CostoLabel.Text = "Costo:";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Location = new System.Drawing.Point(465, 150);
            this.PrecioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(52, 17);
            this.PrecioLabel.TabIndex = 29;
            this.PrecioLabel.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre del producto:";
            // 
            // CantidadLbl
            // 
            this.CantidadLbl.AutoSize = true;
            this.CantidadLbl.Location = new System.Drawing.Point(465, 112);
            this.CantidadLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CantidadLbl.Name = "CantidadLbl";
            this.CantidadLbl.Size = new System.Drawing.Size(68, 17);
            this.CantidadLbl.TabIndex = 26;
            this.CantidadLbl.Text = "Cantidad:";
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(617, 147);
            this.Precio.Margin = new System.Windows.Forms.Padding(5);
            this.Precio.MaxLength = 10;
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(132, 22);
            this.Precio.TabIndex = 25;
            this.Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precio_KeyPress);
            // 
            // Nombre
            // 
            this.Nombre.Enabled = false;
            this.Nombre.Location = new System.Drawing.Point(180, 75);
            this.Nombre.Margin = new System.Windows.Forms.Padding(5);
            this.Nombre.MaxLength = 100;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(255, 22);
            this.Nombre.TabIndex = 20;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(617, 109);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(5);
            this.Cantidad.MaxLength = 5;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(132, 22);
            this.Cantidad.TabIndex = 24;
            this.Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_KeyPress);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.AllowUserToResizeRows = false;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Cost,
            this.Price,
            this.Cant});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedido.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPedido.EnableHeadersVisualStyles = false;
            this.dgvPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPedido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPedido.Location = new System.Drawing.Point(524, 260);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(534, 327);
            this.dgvPedido.TabIndex = 38;
            // 
            // agregarBtn
            // 
            this.agregarBtn.ActiveControl = null;
            this.agregarBtn.Location = new System.Drawing.Point(27, 608);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(142, 50);
            this.agregarBtn.TabIndex = 39;
            this.agregarBtn.Text = "Agregar Producto";
            this.agregarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarBtn.UseSelectable = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(524, 226);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 20);
            this.metroLabel2.TabIndex = 40;
            this.metroLabel2.Text = "Lista del Pedido";
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.ActiveControl = null;
            this.eliminarBtn.Location = new System.Drawing.Point(203, 608);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(142, 50);
            this.eliminarBtn.TabIndex = 41;
            this.eliminarBtn.Text = "Eliminar Producto";
            this.eliminarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarBtn.UseSelectable = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // Name
            // 
            this.Name.HeaderText = "Nombre";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Costo";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Precio";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            // 
            // Utilidad
            // 
            this.Utilidad.Location = new System.Drawing.Point(885, 77);
            this.Utilidad.Margin = new System.Windows.Forms.Padding(5);
            this.Utilidad.MaxLength = 12;
            this.Utilidad.Name = "Utilidad";
            this.Utilidad.Size = new System.Drawing.Size(132, 22);
            this.Utilidad.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Utilidad:";
            // 
            // AddPedidoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 670);
            this.Controls.Add(this.Utilidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.dgvPedido);
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
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CantidadLbl);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Cantidad);
            this.Text = "AddPedidoCompra";


            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvProductos;
        private MetroFramework.Controls.MetroTextBox buscarProducto;
        private MetroFramework.Controls.MetroLabel nombreLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile titleCancelar;
        private MetroFramework.Controls.MetroTile titleAceptar;
        private MetroFramework.Controls.MetroRadioButton bultoRadio;
        private MetroFramework.Controls.MetroRadioButton individualRadio;
        private System.Windows.Forms.ComboBox UnidadesXBulto;
        private System.Windows.Forms.Label UnidadesXBultoLbl;
        private System.Windows.Forms.TextBox Costo;
        private System.Windows.Forms.Label CostoLabel;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CantidadLbl;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Cantidad;
        private MetroFramework.Controls.MetroGrid dgvPedido;
        private MetroFramework.Controls.MetroTile agregarBtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile eliminarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.TextBox Utilidad;
        private System.Windows.Forms.Label label1;
    }
}