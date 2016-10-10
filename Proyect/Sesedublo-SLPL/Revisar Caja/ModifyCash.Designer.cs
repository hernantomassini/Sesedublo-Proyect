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
            this.descripcion = new MetroFramework.Controls.MetroTextBox();
            this.Cantidad = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // AceptarTIle
            // 
            this.AceptarTIle.ActiveControl = null;
            this.AceptarTIle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AceptarTIle.Location = new System.Drawing.Point(211, 246);
            this.AceptarTIle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AceptarTIle.Name = "AceptarTIle";
            this.AceptarTIle.Size = new System.Drawing.Size(125, 54);
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
            this.AtrasTile.Location = new System.Drawing.Point(56, 246);
            this.AtrasTile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(124, 54);
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
            this.Sumar.Location = new System.Drawing.Point(104, 92);
            this.Sumar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(61, 17);
            this.Sumar.TabIndex = 5;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseSelectable = true;
            // 
            // Restar
            // 
            this.Restar.AutoSize = true;
            this.Restar.Location = new System.Drawing.Point(211, 92);
            this.Restar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(61, 17);
            this.Restar.TabIndex = 6;
            this.Restar.Text = "Restar";
            this.Restar.UseSelectable = true;
            // 
            // descripcion
            // 
            // 
            // 
            // 
            this.descripcion.CustomButton.Image = null;
            this.descripcion.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.descripcion.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.descripcion.CustomButton.Name = "";
            this.descripcion.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.descripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descripcion.CustomButton.TabIndex = 1;
            this.descripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descripcion.CustomButton.UseSelectable = true;
            this.descripcion.CustomButton.Visible = false;
            this.descripcion.Lines = new string[0];
            this.descripcion.Location = new System.Drawing.Point(104, 153);
            this.descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.descripcion.MaxLength = 60;
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.PasswordChar = '\0';
            this.descripcion.PromptText = "Ingrese el motivo";
            this.descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descripcion.SelectedText = "";
            this.descripcion.SelectionLength = 0;
            this.descripcion.SelectionStart = 0;
            this.descripcion.ShortcutsEnabled = true;
            this.descripcion.Size = new System.Drawing.Size(180, 87);
            this.descripcion.TabIndex = 2;
            this.descripcion.UseSelectable = true;
            this.descripcion.WaterMark = "Ingrese el motivo";
            this.descripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripcion_KeyPress);
            // 
            // Cantidad
            // 
            // 
            // 
            // 
            this.Cantidad.CustomButton.Image = null;
            this.Cantidad.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.Cantidad.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.Cantidad.CustomButton.Name = "";
            this.Cantidad.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Cantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Cantidad.CustomButton.TabIndex = 1;
            this.Cantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Cantidad.CustomButton.UseSelectable = true;
            this.Cantidad.CustomButton.Visible = false;
            this.Cantidad.Lines = new string[0];
            this.Cantidad.Location = new System.Drawing.Point(104, 117);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.Cantidad.MaxLength = 20;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.PasswordChar = '\0';
            this.Cantidad.PromptText = "Ingrese el monto";
            this.Cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Cantidad.SelectedText = "";
            this.Cantidad.SelectionLength = 0;
            this.Cantidad.SelectionStart = 0;
            this.Cantidad.ShortcutsEnabled = true;
            this.Cantidad.Size = new System.Drawing.Size(180, 28);
            this.Cantidad.TabIndex = 1;
            this.Cantidad.UseSelectable = true;
            this.Cantidad.WaterMark = "Ingrese el monto";
            this.Cantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Cantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_KeyPress);
            // 
            // ModifyCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 350);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.Restar);
            this.Controls.Add(this.Sumar);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.AceptarTIle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModifyCash";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
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
        private MetroFramework.Controls.MetroTextBox descripcion;
        private MetroFramework.Controls.MetroTextBox Cantidad;
    }
}