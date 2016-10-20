namespace Sesedublo_SLPL.Pedidos_de_Compra
{
    partial class MostrarPedidoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarPedidoCompra));
            this.costoSumatoriaLabel = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvPedido = new MetroFramework.Controls.MetroGrid();
            this.CantidadXBulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostBulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceUnitary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioBulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UtilidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedRadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarTile = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // costoSumatoriaLabel
            // 
            this.costoSumatoriaLabel.AutoSize = true;
            this.costoSumatoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.costoSumatoriaLabel.Location = new System.Drawing.Point(310, 60);
            this.costoSumatoriaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costoSumatoriaLabel.Name = "costoSumatoriaLabel";
            this.costoSumatoriaLabel.Size = new System.Drawing.Size(139, 24);
            this.costoSumatoriaLabel.TabIndex = 48;
            this.costoSumatoriaLabel.Text = "costoSumatoria";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(18, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 47;
            this.metroLabel2.Text = "Lista del Pedido";
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.AllowUserToResizeRows = false;
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
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
            this.CantidadXBulto,
            this.NombreDGV,
            this.CostBulto,
            this.PriceUnitary,
            this.PrecioBulto,
            this.Cant,
            this.UtilidadProducto,
            this.selectedRadio});
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
            this.dgvPedido.Location = new System.Drawing.Point(18, 140);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
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
            this.dgvPedido.Size = new System.Drawing.Size(742, 263);
            this.dgvPedido.TabIndex = 46;
            // 
            // CantidadXBulto
            // 
            this.CantidadXBulto.HeaderText = "CantidadXBulto";
            this.CantidadXBulto.Name = "CantidadXBulto";
            this.CantidadXBulto.ReadOnly = true;
            this.CantidadXBulto.Visible = false;
            // 
            // NombreDGV
            // 
            this.NombreDGV.HeaderText = "Nombre";
            this.NombreDGV.Name = "NombreDGV";
            this.NombreDGV.ReadOnly = true;
            // 
            // CostBulto
            // 
            this.CostBulto.HeaderText = "Costo por bulto";
            this.CostBulto.Name = "CostBulto";
            this.CostBulto.ReadOnly = true;
            // 
            // PriceUnitary
            // 
            this.PriceUnitary.HeaderText = "Precio Unitario";
            this.PriceUnitary.Name = "PriceUnitary";
            this.PriceUnitary.ReadOnly = true;
            // 
            // PrecioBulto
            // 
            this.PrecioBulto.HeaderText = "Precio bulto";
            this.PrecioBulto.Name = "PrecioBulto";
            this.PrecioBulto.ReadOnly = true;
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            // 
            // UtilidadProducto
            // 
            this.UtilidadProducto.HeaderText = "Utilidad";
            this.UtilidadProducto.Name = "UtilidadProducto";
            this.UtilidadProducto.ReadOnly = true;
            // 
            // selectedRadio
            // 
            this.selectedRadio.HeaderText = "selectedRadio";
            this.selectedRadio.Name = "selectedRadio";
            this.selectedRadio.ReadOnly = true;
            this.selectedRadio.Visible = false;
            // 
            // CerrarTile
            // 
            this.CerrarTile.ActiveControl = null;
            this.CerrarTile.BackColor = System.Drawing.Color.DarkRed;
            this.CerrarTile.Location = new System.Drawing.Point(24, 410);
            this.CerrarTile.Margin = new System.Windows.Forms.Padding(4);
            this.CerrarTile.Name = "CerrarTile";
            this.CerrarTile.Size = new System.Drawing.Size(102, 41);
            this.CerrarTile.TabIndex = 49;
            this.CerrarTile.Text = "Cerrar";
            this.CerrarTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CerrarTile.TileImage = ((System.Drawing.Image)(resources.GetObject("CerrarTile.TileImage")));
            this.CerrarTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CerrarTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.CerrarTile.UseCustomBackColor = true;
            this.CerrarTile.UseSelectable = true;
            this.CerrarTile.UseTileImage = true;
            this.CerrarTile.Click += new System.EventHandler(this.CerrarTile_Click);
            // 
            // MostrarPedidoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 469);
            this.Controls.Add(this.CerrarTile);
            this.Controls.Add(this.costoSumatoriaLabel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dgvPedido);
            this.Name = "MostrarPedidoCompra";
            this.Text = "Ver pedido de compra";
            this.Load += new System.EventHandler(this.MostrarPedidoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label costoSumatoriaLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid dgvPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadXBulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostBulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceUnitary;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioBulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn UtilidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedRadio;
        private MetroFramework.Controls.MetroTile CerrarTile;
    }
}