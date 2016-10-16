namespace Sesedublo_SLPL.Revisar_Caja
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
            this.AceptarTIle = new MetroFramework.Controls.MetroTile();
            this.AtrasTile = new MetroFramework.Controls.MetroTile();
            this.Sumar = new MetroFramework.Controls.MetroRadioButton();
            this.Restar = new MetroFramework.Controls.MetroRadioButton();
            this.Motivo = new MetroFramework.Controls.MetroTextBox();
            this.Monto = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // AceptarTIle
            // 
            this.AceptarTIle.ActiveControl = null;
            this.AceptarTIle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AceptarTIle.Location = new System.Drawing.Point(158, 200);
            this.AceptarTIle.Margin = new System.Windows.Forms.Padding(2);
            this.AceptarTIle.Name = "AceptarTIle";
            this.AceptarTIle.Size = new System.Drawing.Size(94, 44);
            this.AceptarTIle.TabIndex = 5;
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
            this.AtrasTile.Location = new System.Drawing.Point(42, 200);
            this.AtrasTile.Margin = new System.Windows.Forms.Padding(2);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(93, 44);
            this.AtrasTile.TabIndex = 6;
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
            this.Sumar.Location = new System.Drawing.Point(78, 75);
            this.Sumar.Margin = new System.Windows.Forms.Padding(2);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(57, 15);
            this.Sumar.TabIndex = 1;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseSelectable = true;
            // 
            // Restar
            // 
            this.Restar.AutoSize = true;
            this.Restar.Location = new System.Drawing.Point(158, 75);
            this.Restar.Margin = new System.Windows.Forms.Padding(2);
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(55, 15);
            this.Restar.TabIndex = 2;
            this.Restar.Text = "Restar";
            this.Restar.UseSelectable = true;
            // 
            // Motivo
            // 
            // 
            // 
            // 
            this.Motivo.CustomButton.Image = null;
            this.Motivo.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.Motivo.CustomButton.Name = "";
            this.Motivo.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.Motivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Motivo.CustomButton.TabIndex = 1;
            this.Motivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Motivo.CustomButton.UseSelectable = true;
            this.Motivo.CustomButton.Visible = false;
            this.Motivo.Lines = new string[0];
            this.Motivo.Location = new System.Drawing.Point(78, 124);
            this.Motivo.MaxLength = 60;
            this.Motivo.Multiline = true;
            this.Motivo.Name = "Motivo";
            this.Motivo.PasswordChar = '\0';
            this.Motivo.PromptText = "Ingrese el motivo";
            this.Motivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Motivo.SelectedText = "";
            this.Motivo.SelectionLength = 0;
            this.Motivo.SelectionStart = 0;
            this.Motivo.ShortcutsEnabled = true;
            this.Motivo.Size = new System.Drawing.Size(135, 71);
            this.Motivo.TabIndex = 4;
            this.Motivo.UseSelectable = true;
            this.Motivo.WaterMark = "Ingrese el motivo";
            this.Motivo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Motivo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Motivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripcion_KeyPress);
            // 
            // Monto
            // 
            // 
            // 
            // 
            this.Monto.CustomButton.Image = null;
            this.Monto.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.Monto.CustomButton.Name = "";
            this.Monto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Monto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Monto.CustomButton.TabIndex = 1;
            this.Monto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Monto.CustomButton.UseSelectable = true;
            this.Monto.CustomButton.Visible = false;
            this.Monto.Lines = new string[0];
            this.Monto.Location = new System.Drawing.Point(78, 95);
            this.Monto.MaxLength = 20;
            this.Monto.Name = "Monto";
            this.Monto.PasswordChar = '\0';
            this.Monto.PromptText = "Ingrese el monto";
            this.Monto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Monto.SelectedText = "";
            this.Monto.SelectionLength = 0;
            this.Monto.SelectionStart = 0;
            this.Monto.ShortcutsEnabled = true;
            this.Monto.Size = new System.Drawing.Size(135, 23);
            this.Monto.TabIndex = 3;
            this.Monto.UseSelectable = true;
            this.Monto.WaterMark = "Ingrese el monto";
            this.Monto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Monto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_KeyPress);
            // 
            // ModifyCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 284);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.Motivo);
            this.Controls.Add(this.Restar);
            this.Controls.Add(this.Sumar);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.AceptarTIle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ModifyCash";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Modificar Caja";
            this.Load += new System.EventHandler(this.ModifyCash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile AceptarTIle;
        private MetroFramework.Controls.MetroTile AtrasTile;
        private MetroFramework.Controls.MetroRadioButton Sumar;
        private MetroFramework.Controls.MetroRadioButton Restar;
        private MetroFramework.Controls.MetroTextBox Motivo;
        private MetroFramework.Controls.MetroTextBox Monto;
    }
}