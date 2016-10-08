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
            this.Cantidad.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.Cantidad.CustomButton.Name = "";
            this.Cantidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Cantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Cantidad.CustomButton.TabIndex = 1;
            this.Cantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Cantidad.CustomButton.UseSelectable = true;
            this.Cantidad.CustomButton.Visible = false;
            this.Cantidad.Lines = new string[0];
            this.Cantidad.Location = new System.Drawing.Point(97, 119);
            this.Cantidad.MaxLength = 20;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.PasswordChar = '\0';
            this.Cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Cantidad.SelectedText = "";
            this.Cantidad.SelectionLength = 0;
            this.Cantidad.SelectionStart = 0;
            this.Cantidad.ShortcutsEnabled = true;
            this.Cantidad.Size = new System.Drawing.Size(121, 23);
            this.Cantidad.TabIndex = 0;
            this.Cantidad.UseSelectable = true;
            this.Cantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Cantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AceptarTIle
            // 
            this.AceptarTIle.ActiveControl = null;
            this.AceptarTIle.Location = new System.Drawing.Point(210, 211);
            this.AceptarTIle.Name = "AceptarTIle";
            this.AceptarTIle.Size = new System.Drawing.Size(90, 40);
            this.AceptarTIle.TabIndex = 3;
            this.AceptarTIle.Text = "Aceptar";
            this.AceptarTIle.UseSelectable = true;
            this.AceptarTIle.Click += new System.EventHandler(this.AceptarTIle_Click);
            // 
            // AtrasTile
            // 
            this.AtrasTile.ActiveControl = null;
            this.AtrasTile.Location = new System.Drawing.Point(23, 211);
            this.AtrasTile.Name = "AtrasTile";
            this.AtrasTile.Size = new System.Drawing.Size(63, 40);
            this.AtrasTile.TabIndex = 4;
            this.AtrasTile.Text = "Atras";
            this.AtrasTile.UseSelectable = true;
            this.AtrasTile.Click += new System.EventHandler(this.AtrasTile_Click);
            // 
            // Sumar
            // 
            this.Sumar.AutoSize = true;
            this.Sumar.Location = new System.Drawing.Point(97, 148);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(61, 17);
            this.Sumar.TabIndex = 5;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseSelectable = true;
            // 
            // Restar
            // 
            this.Restar.AutoSize = true;
            this.Restar.Location = new System.Drawing.Point(164, 148);
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(61, 17);
            this.Restar.TabIndex = 6;
            this.Restar.Text = "Restar";
            this.Restar.UseSelectable = true;
            // 
            // ModifyCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 278);
            this.Controls.Add(this.Restar);
            this.Controls.Add(this.Sumar);
            this.Controls.Add(this.AtrasTile);
            this.Controls.Add(this.AceptarTIle);
            this.Controls.Add(this.Cantidad);
            this.Name = "ModifyCash";
            this.Text = "ModifyCash";
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