﻿using MetroFramework.Controls;

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
            this.StockDGV = new MetroFramework.Controls.MetroGrid();
            this.titleAtras = new MetroFramework.Controls.MetroTile();
            this.titleEliminarCliente = new MetroFramework.Controls.MetroTile();
            this.titleAgregarCliente = new MetroFramework.Controls.MetroTile();
            this.titleModificarCliente = new MetroFramework.Controls.MetroTile();
            this.nombre = new MetroFramework.Controls.MetroTextBox();
            this.nombreLabel = new MetroFramework.Controls.MetroLabel();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Costo,
            this.Precio});
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
            this.StockDGV.Location = new System.Drawing.Point(22, 113);
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
            this.StockDGV.Size = new System.Drawing.Size(562, 248);
            this.StockDGV.TabIndex = 4;
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
            // nombre
            // 
            // 
            // 
            // 
            this.nombre.CustomButton.Image = null;
            this.nombre.CustomButton.Location = new System.Drawing.Point(92, 1);
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
            this.nombre.Location = new System.Drawing.Point(90, 81);
            this.nombre.MaxLength = 70;
            this.nombre.Name = "nombre";
            this.nombre.PasswordChar = '\0';
            this.nombre.PromptText = "Buscar";
            this.nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombre.SelectedText = "";
            this.nombre.SelectionLength = 0;
            this.nombre.SelectionStart = 0;
            this.nombre.ShortcutsEnabled = true;
            this.nombre.Size = new System.Drawing.Size(114, 23);
            this.nombre.TabIndex = 12;
            this.nombre.UseSelectable = true;
            this.nombre.WaterMark = "Buscar";
            this.nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(22, 81);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(62, 19);
            this.nombreLabel.TabIndex = 11;
            this.nombreLabel.Text = "Nombre:";
            // 
            // id_producto
            // 
            this.id_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id_producto.HeaderText = "ID Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_producto.Visible = false;
            this.id_producto.Width = 91;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cantidad.Width = 77;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Producto.Width = 77;
            // 
            // Costo
            // 
            this.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Costo.Width = 60;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Precio.Width = 61;
            // 
            // ABM_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 434);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.nombreLabel);
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
        private MetroTile titleAtras;
        private MetroTile titleEliminarCliente;
        private MetroTile titleAgregarCliente;
        private MetroTile titleModificarCliente;
        private MetroTextBox nombre;
        private MetroLabel nombreLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}