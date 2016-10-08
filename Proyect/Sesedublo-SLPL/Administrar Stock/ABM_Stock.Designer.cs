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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AtrasButton = new System.Windows.Forms.Button();
            this.AgregarProductoStockBtn = new System.Windows.Forms.Button();
            this.modificarProductoStockBtn = new System.Windows.Forms.Button();
            this.EliminarProductoStockBtn = new System.Windows.Forms.Button();
            this.StockDGV = new MetroFramework.Controls.MetroGrid();
            this.id_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cindividual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantXBulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVBulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AtrasButton
            // 
            this.AtrasButton.Location = new System.Drawing.Point(31, 398);
            this.AtrasButton.Margin = new System.Windows.Forms.Padding(4);
            this.AtrasButton.Name = "AtrasButton";
            this.AtrasButton.Size = new System.Drawing.Size(100, 43);
            this.AtrasButton.TabIndex = 0;
            this.AtrasButton.Text = "Atras";
            this.AtrasButton.UseVisualStyleBackColor = true;
            this.AtrasButton.Click += new System.EventHandler(this.AtrasButton_Click);
            // 
            // AgregarProductoStockBtn
            // 
            this.AgregarProductoStockBtn.Location = new System.Drawing.Point(599, 398);
            this.AgregarProductoStockBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarProductoStockBtn.Name = "AgregarProductoStockBtn";
            this.AgregarProductoStockBtn.Size = new System.Drawing.Size(137, 43);
            this.AgregarProductoStockBtn.TabIndex = 1;
            this.AgregarProductoStockBtn.Text = "Agregar producto";
            this.AgregarProductoStockBtn.UseVisualStyleBackColor = true;
            this.AgregarProductoStockBtn.Click += new System.EventHandler(this.AgregarProductoStockBtn_Click);
            // 
            // modificarProductoStockBtn
            // 
            this.modificarProductoStockBtn.Location = new System.Drawing.Point(495, 398);
            this.modificarProductoStockBtn.Margin = new System.Windows.Forms.Padding(4);
            this.modificarProductoStockBtn.Name = "modificarProductoStockBtn";
            this.modificarProductoStockBtn.Size = new System.Drawing.Size(96, 43);
            this.modificarProductoStockBtn.TabIndex = 2;
            this.modificarProductoStockBtn.Text = "Modificar producto";
            this.modificarProductoStockBtn.UseVisualStyleBackColor = true;
            this.modificarProductoStockBtn.Click += new System.EventHandler(this.modificarProductoStockBtn_Click);
            // 
            // EliminarProductoStockBtn
            // 
            this.EliminarProductoStockBtn.Location = new System.Drawing.Point(356, 398);
            this.EliminarProductoStockBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarProductoStockBtn.Name = "EliminarProductoStockBtn";
            this.EliminarProductoStockBtn.Size = new System.Drawing.Size(131, 43);
            this.EliminarProductoStockBtn.TabIndex = 3;
            this.EliminarProductoStockBtn.Text = "Eliminar producto";
            this.EliminarProductoStockBtn.UseVisualStyleBackColor = true;
            this.EliminarProductoStockBtn.Click += new System.EventHandler(this.EliminarProductoStockBtn_Click);
            // 
            // StockDGV
            // 
            this.StockDGV.AllowUserToAddRows = false;
            this.StockDGV.AllowUserToDeleteRows = false;
            this.StockDGV.AllowUserToResizeRows = false;
            this.StockDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.Cindividual,
            this.CBulto,
            this.CantXBulto,
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
            this.StockDGV.Location = new System.Drawing.Point(31, 67);
            this.StockDGV.Margin = new System.Windows.Forms.Padding(4);
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
            this.StockDGV.Size = new System.Drawing.Size(705, 324);
            this.StockDGV.TabIndex = 4;
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
            // Cindividual
            // 
            this.Cindividual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cindividual.HeaderText = "Cant. individual";
            this.Cindividual.Name = "Cindividual";
            this.Cindividual.ReadOnly = true;
            this.Cindividual.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cindividual.Width = 107;
            // 
            // CBulto
            // 
            this.CBulto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CBulto.HeaderText = "Cant. Bultos";
            this.CBulto.Name = "CBulto";
            this.CBulto.ReadOnly = true;
            this.CBulto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CBulto.Width = 90;
            // 
            // CantXBulto
            // 
            this.CantXBulto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CantXBulto.HeaderText = "Cant. Por Bulto";
            this.CantXBulto.Name = "CantXBulto";
            this.CantXBulto.ReadOnly = true;
            this.CantXBulto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CantXBulto.Width = 105;
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
            // Costo
            // 
            this.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Costo.Width = 65;
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
            // ABM_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 455);
            this.Controls.Add(this.StockDGV);
            this.Controls.Add(this.EliminarProductoStockBtn);
            this.Controls.Add(this.modificarProductoStockBtn);
            this.Controls.Add(this.AgregarProductoStockBtn);
            this.Controls.Add(this.AtrasButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ABM_Stock";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.ABM_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AtrasButton;
        private System.Windows.Forms.Button AgregarProductoStockBtn;
        private System.Windows.Forms.Button modificarProductoStockBtn;
        private System.Windows.Forms.Button EliminarProductoStockBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cindividual;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantXBulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVBulto;
        private MetroGrid StockDGV;
    }
}