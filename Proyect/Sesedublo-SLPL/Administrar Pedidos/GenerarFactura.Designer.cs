﻿namespace Sesedublo_SLPL.Administrar_Pedidos
{
    partial class GenerarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarFactura));
            this.AceptarTile = new MetroFramework.Controls.MetroTile();
            this.AtrasTile = new MetroFramework.Controls.MetroTile();
            this.tipoDeFactura = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // AceptarTile
            // 
            this.AceptarTile.ActiveControl = null;
            this.AceptarTile.BackColor = System.Drawing.Color.Violet;
            this.AceptarTile.Location = new System.Drawing.Point(120, 123);
            this.AceptarTile.Margin = new System.Windows.Forms.Padding(2);
            this.AceptarTile.Name = "AceptarTile";
            this.AceptarTile.Size = new System.Drawing.Size(99, 43);
            this.AceptarTile.TabIndex = 2;
            this.AceptarTile.Text = "Aceptar";
            this.AceptarTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarTile.TileImage = ((System.Drawing.Image)(resources.GetObject("AceptarTile.TileImage")));
            this.AceptarTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AceptarTile.UseCustomBackColor = true;
            this.AceptarTile.UseSelectable = true;
            this.AceptarTile.UseTileImage = true;
            this.AceptarTile.Click += new System.EventHandler(this.AceptarTile_Click);
            // 
            // AtrasTile
            // 
            this.AtrasTile.ActiveControl = null;
            this.AtrasTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AtrasTile.Location = new System.Drawing.Point(23, 123);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(92, 42);
            this.AtrasTile.TabIndex = 3;
            this.AtrasTile.Text = "Atras";
            this.AtrasTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AtrasTile.TileImage = ((System.Drawing.Image)(resources.GetObject("AtrasTile.TileImage")));
            this.AtrasTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtrasTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AtrasTile.UseCustomBackColor = true;
            this.AtrasTile.UseSelectable = true;
            this.AtrasTile.UseTileImage = true;
            this.AtrasTile.Click += new System.EventHandler(this.AtrasTile_Click);
            // 
            // tipoDeFactura
            // 
            this.tipoDeFactura.FormattingEnabled = true;
            this.tipoDeFactura.ItemHeight = 23;
            this.tipoDeFactura.Items.AddRange(new object[] {
            "A"});
            this.tipoDeFactura.Location = new System.Drawing.Point(53, 75);
            this.tipoDeFactura.Name = "tipoDeFactura";
            this.tipoDeFactura.Size = new System.Drawing.Size(121, 29);
            this.tipoDeFactura.TabIndex = 1;
            this.tipoDeFactura.UseSelectable = true;
            // 
            // GenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 194);
            this.Controls.Add(this.tipoDeFactura);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.AceptarTile);
            this.MaximizeBox = false;
            this.Name = "GenerarFactura";
            this.Text = "Generar Factura";
            this.Load += new System.EventHandler(this.GenerarFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile AceptarTile;
        private MetroFramework.Controls.MetroTile AtrasTile;
        private MetroFramework.Controls.MetroComboBox tipoDeFactura;
    }
}