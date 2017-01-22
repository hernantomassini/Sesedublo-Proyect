namespace Sesedublo_SLPL.Historial_de_Facturasns
{
    partial class VerRegistroFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerRegistroFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CerrarTile = new MetroFramework.Controls.MetroTile();
            this.registrosDGV = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.registrosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarTile
            // 
            this.CerrarTile.ActiveControl = null;
            this.CerrarTile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CerrarTile.Location = new System.Drawing.Point(31, 364);
            this.CerrarTile.Margin = new System.Windows.Forms.Padding(4);
            this.CerrarTile.Name = "CerrarTile";
            this.CerrarTile.Size = new System.Drawing.Size(119, 54);
            this.CerrarTile.TabIndex = 1;
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
            // registrosDGV
            // 
            this.registrosDGV.AllowUserToAddRows = false;
            this.registrosDGV.AllowUserToDeleteRows = false;
            this.registrosDGV.AllowUserToResizeRows = false;
            this.registrosDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.registrosDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.registrosDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.registrosDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registrosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.registrosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registrosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.registrosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.registrosDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.registrosDGV.EnableHeadersVisualStyles = false;
            this.registrosDGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registrosDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registrosDGV.Location = new System.Drawing.Point(31, 78);
            this.registrosDGV.Margin = new System.Windows.Forms.Padding(4);
            this.registrosDGV.MultiSelect = false;
            this.registrosDGV.Name = "registrosDGV";
            this.registrosDGV.ReadOnly = true;
            this.registrosDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registrosDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.registrosDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.registrosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registrosDGV.Size = new System.Drawing.Size(555, 279);
            this.registrosDGV.TabIndex = 0;
            this.registrosDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.registrosDGV_CellFormatting);
            // 
            // VerRegistroFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 447);
            this.Controls.Add(this.registrosDGV);
            this.Controls.Add(this.CerrarTile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "VerRegistroFactura";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Notas de Credito";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.VerRegistroFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile CerrarTile;
        private MetroFramework.Controls.MetroGrid registrosDGV;
    }
}