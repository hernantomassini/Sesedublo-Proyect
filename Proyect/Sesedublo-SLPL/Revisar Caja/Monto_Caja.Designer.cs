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
            this.ModificarEfectivo = new MetroFramework.Controls.MetroTile();
            this.EfectivoLabel = new MetroFramework.Controls.MetroLabel();
            this.MercaderiaLabel = new MetroFramework.Controls.MetroLabel();
            this.AtrasTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ModificarEfectivo
            // 
            this.ModificarEfectivo.ActiveControl = null;
            this.ModificarEfectivo.Location = new System.Drawing.Point(330, 211);
            this.ModificarEfectivo.Name = "ModificarEfectivo";
            this.ModificarEfectivo.Size = new System.Drawing.Size(138, 43);
            this.ModificarEfectivo.TabIndex = 1;
            this.ModificarEfectivo.Text = "Modificar efectivo";
            this.ModificarEfectivo.UseSelectable = true;
            this.ModificarEfectivo.Click += new System.EventHandler(this.ModificarEfectivo_Click);
            // 
            // EfectivoLabel
            // 
            this.EfectivoLabel.AutoSize = true;
            this.EfectivoLabel.Location = new System.Drawing.Point(30, 74);
            this.EfectivoLabel.Name = "EfectivoLabel";
            this.EfectivoLabel.Size = new System.Drawing.Size(91, 20);
            this.EfectivoLabel.TabIndex = 2;
            this.EfectivoLabel.Text = "EfectivoLabel";
            // 
            // MercaderiaLabel
            // 
            this.MercaderiaLabel.AutoSize = true;
            this.MercaderiaLabel.Location = new System.Drawing.Point(30, 111);
            this.MercaderiaLabel.Name = "MercaderiaLabel";
            this.MercaderiaLabel.Size = new System.Drawing.Size(169, 20);
            this.MercaderiaLabel.TabIndex = 4;
            this.MercaderiaLabel.Text = "CapitalEnMercaderíaLabel";
            // 
            // AtrasTile
            // 
            this.AtrasTile.ActiveControl = null;
            this.AtrasTile.Location = new System.Drawing.Point(30, 211);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(101, 43);
            this.AtrasTile.TabIndex = 5;
            this.AtrasTile.Text = "Atras";
            this.AtrasTile.UseSelectable = true;
            this.AtrasTile.Click += new System.EventHandler(this.AtrasTile_Click);
            // 
            // Monto_Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 281);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.MercaderiaLabel);
            this.Controls.Add(this.EfectivoLabel);
            this.Controls.Add(this.ModificarEfectivo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Monto_Caja";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
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