﻿namespace Sesedublo_SLPL.Revisar_Caja
{
    partial class ModifyCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyCash));
            this.Cantidad = new MetroFramework.Controls.MetroTextBox();
            this.AceptarTIle = new MetroFramework.Controls.MetroTile();
            this.AtrasTile = new MetroFramework.Controls.MetroTile();
            this.Sumar = new MetroFramework.Controls.MetroRadioButton();
            this.Restar = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // Cantidad
            // 
            // 
            // 
            // 
            this.Cantidad.CustomButton.Image = null;
            this.Cantidad.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.Cantidad.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cantidad.CustomButton.Name = "";
            this.Cantidad.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Cantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Cantidad.CustomButton.TabIndex = 1;
            this.Cantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Cantidad.CustomButton.UseSelectable = true;
            this.Cantidad.CustomButton.Visible = false;
            this.Cantidad.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.Cantidad.Lines = new string[0];
            this.Cantidad.Location = new System.Drawing.Point(73, 97);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cantidad.MaxLength = 20;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.PasswordChar = '\0';
            this.Cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Cantidad.SelectedText = "";
            this.Cantidad.SelectionLength = 0;
            this.Cantidad.SelectionStart = 0;
            this.Cantidad.ShortcutsEnabled = true;
            this.Cantidad.Size = new System.Drawing.Size(135, 19);
            this.Cantidad.TabIndex = 0;
            this.Cantidad.UseSelectable = true;
            this.Cantidad.WaterMark = "Ingrese su monto";
            this.Cantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Cantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AceptarTIle
            // 
            this.AceptarTIle.ActiveControl = null;
            this.AceptarTIle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AceptarTIle.Location = new System.Drawing.Point(153, 171);
            this.AceptarTIle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AceptarTIle.Name = "AceptarTIle";
            this.AceptarTIle.Size = new System.Drawing.Size(94, 44);
            this.AceptarTIle.TabIndex = 3;
            this.AceptarTIle.Text = "Aceptar";
            this.AceptarTIle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarTIle.TileImage = ((System.Drawing.Image)(resources.GetObject("AceptarTIle.TileImage")));
            this.AceptarTIle.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarTIle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AceptarTIle.UseCustomBackColor = true;
            this.AceptarTIle.UseSelectable = true;
            this.AceptarTIle.UseTileImage = true;
            this.AceptarTIle.Click += new System.EventHandler(this.AceptarTIle_Click);
            // 
            // AtrasTile
            // 
            this.AtrasTile.ActiveControl = null;
            this.AtrasTile.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AtrasTile.Location = new System.Drawing.Point(26, 171);
            this.AtrasTile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(93, 44);
            this.AtrasTile.TabIndex = 4;
            this.AtrasTile.Text = "Atras";
            this.AtrasTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AtrasTile.TileImage = ((System.Drawing.Image)(resources.GetObject("AtrasTile.TileImage")));
            this.AtrasTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtrasTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AtrasTile.UseCustomBackColor = true;
            this.AtrasTile.UseSelectable = true;
            this.AtrasTile.UseStyleColors = true;
            this.AtrasTile.UseTileImage = true;
            this.AtrasTile.Click += new System.EventHandler(this.AtrasTile_Click);
            // 
            // Sumar
            // 
            this.Sumar.AutoSize = true;
            this.Sumar.Location = new System.Drawing.Point(73, 132);
            this.Sumar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(57, 15);
            this.Sumar.TabIndex = 5;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseSelectable = true;
            // 
            // Restar
            // 
            this.Restar.AutoSize = true;
            this.Restar.Location = new System.Drawing.Point(153, 132);
            this.Restar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(55, 15);
            this.Restar.TabIndex = 6;
            this.Restar.Text = "Restar";
            this.Restar.UseSelectable = true;
            // 
            // ModifyCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 232);
            this.Controls.Add(this.Restar);
            this.Controls.Add(this.Sumar);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.AceptarTIle);
            this.Controls.Add(this.Cantidad);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifyCash";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Modificar Caja";
            this.Load += new System.EventHandler(this.ModifyCash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox Cantidad;
        private MetroFramework.Controls.MetroTile AceptarTIle;
        private MetroFramework.Controls.MetroTile AtrasTile;
        private MetroFramework.Controls.MetroRadioButton Sumar;
        private MetroFramework.Controls.MetroRadioButton Restar;
    }
}