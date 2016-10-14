namespace Sesedublo_SLPL.Revisar_Cajans
{
    partial class Monto_Caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monto_Caja));
            this.ModificarEfectivo = new MetroFramework.Controls.MetroTile();
            this.EfectivoLabel = new MetroFramework.Controls.MetroLabel();
            this.MercaderiaLabel = new MetroFramework.Controls.MetroLabel();
            this.AtrasTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ModificarEfectivo
            // 
            this.ModificarEfectivo.ActiveControl = null;
            this.ModificarEfectivo.Location = new System.Drawing.Point(177, 170);
            this.ModificarEfectivo.Margin = new System.Windows.Forms.Padding(2);
            this.ModificarEfectivo.Name = "ModificarEfectivo";
            this.ModificarEfectivo.Size = new System.Drawing.Size(156, 36);
            this.ModificarEfectivo.TabIndex = 1;
            this.ModificarEfectivo.Text = "Modificar efectivo";
            this.ModificarEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModificarEfectivo.TileImage = ((System.Drawing.Image)(resources.GetObject("ModificarEfectivo.TileImage")));
            this.ModificarEfectivo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ModificarEfectivo.UseSelectable = true;
            this.ModificarEfectivo.UseTileImage = true;
            this.ModificarEfectivo.Click += new System.EventHandler(this.ModificarEfectivo_Click);
            // 
            // EfectivoLabel
            // 
            this.EfectivoLabel.AutoSize = true;
            this.EfectivoLabel.Location = new System.Drawing.Point(22, 60);
            this.EfectivoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EfectivoLabel.Name = "EfectivoLabel";
            this.EfectivoLabel.Size = new System.Drawing.Size(85, 19);
            this.EfectivoLabel.TabIndex = 0;
            this.EfectivoLabel.Text = "EfectivoLabel";
            // 
            // MercaderiaLabel
            // 
            this.MercaderiaLabel.AutoSize = true;
            this.MercaderiaLabel.Location = new System.Drawing.Point(22, 90);
            this.MercaderiaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MercaderiaLabel.Name = "MercaderiaLabel";
            this.MercaderiaLabel.Size = new System.Drawing.Size(162, 19);
            this.MercaderiaLabel.TabIndex = 4;
            this.MercaderiaLabel.Text = "CapitalEnMercaderíaLabel";
            // 
            // AtrasTile
            // 
            this.AtrasTile.ActiveControl = null;
            this.AtrasTile.Location = new System.Drawing.Point(22, 170);
            this.AtrasTile.Margin = new System.Windows.Forms.Padding(2);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(85, 36);
            this.AtrasTile.TabIndex = 2;
            this.AtrasTile.Text = "Atras";
            this.AtrasTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AtrasTile.TileImage = ((System.Drawing.Image)(resources.GetObject("AtrasTile.TileImage")));
            this.AtrasTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtrasTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AtrasTile.UseSelectable = true;
            this.AtrasTile.UseTileImage = true;
            this.AtrasTile.Click += new System.EventHandler(this.AtrasTile_Click);
            // 
            // Monto_Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 228);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.MercaderiaLabel);
            this.Controls.Add(this.EfectivoLabel);
            this.Controls.Add(this.ModificarEfectivo);
            this.Name = "Monto_Caja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.Monto_Caja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile ModificarEfectivo;
        private MetroFramework.Controls.MetroLabel EfectivoLabel;
        private MetroFramework.Controls.MetroLabel MercaderiaLabel;
        private MetroFramework.Controls.MetroTile AtrasTile;
    }
}