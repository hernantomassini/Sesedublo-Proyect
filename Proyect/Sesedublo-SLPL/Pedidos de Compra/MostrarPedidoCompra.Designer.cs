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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // costoSumatoriaLabel
            // 
            this.costoSumatoriaLabel.AutoSize = true;
            this.costoSumatoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.costoSumatoriaLabel.Location = new System.Drawing.Point(413, 74);
            this.costoSumatoriaLabel.Name = "costoSumatoriaLabel";
            this.costoSumatoriaLabel.Size = new System.Drawing.Size(180, 29);
            this.costoSumatoriaLabel.TabIndex = 48;
            this.costoSumatoriaLabel.Text = "costoSumatoria";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 145);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 20);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedido.EnableHeadersVisualStyles = false;
            this.dgvPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPedido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPedido.Location = new System.Drawing.Point(24, 172);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(989, 324);
            this.dgvPedido.TabIndex = 46;
            this.dgvPedido.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPedido_CellFormatting);
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
            this.CerrarTile.Location = new System.Drawing.Point(32, 505);
            this.CerrarTile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CerrarTile.Name = "CerrarTile";
            this.CerrarTile.Size = new System.Drawing.Size(136, 50);
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
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.Silver;
            this.metroTile1.Location = new System.Drawing.Point(844, 111);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(169, 54);
            this.metroTile1.TabIndex = 50;
            this.metroTile1.Text = "PDF";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // MostrarPedidoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 577);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.CerrarTile);
            this.Controls.Add(this.costoSumatoriaLabel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dgvPedido);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MostrarPedidoCompra";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
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
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}