namespace Sesedublo_SLPL.Administrar_Pedidos
{
    partial class ActualizarPago
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
            this.cantidadAPagar = new MetroFramework.Controls.MetroTextBox();
            this.cantidadPagada = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.CancelarTile = new MetroFramework.Controls.MetroTile();
            this.AceptarTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // cantidadAPagar
            // 
            // 
            // 
            // 
            this.cantidadAPagar.CustomButton.Image = null;
            this.cantidadAPagar.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.cantidadAPagar.CustomButton.Name = "";
            this.cantidadAPagar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cantidadAPagar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cantidadAPagar.CustomButton.TabIndex = 1;
            this.cantidadAPagar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cantidadAPagar.CustomButton.UseSelectable = true;
            this.cantidadAPagar.CustomButton.Visible = false;
            this.cantidadAPagar.Lines = new string[0];
            this.cantidadAPagar.Location = new System.Drawing.Point(176, 114);
            this.cantidadAPagar.MaxLength = 32767;
            this.cantidadAPagar.Name = "cantidadAPagar";
            this.cantidadAPagar.PasswordChar = '\0';
            this.cantidadAPagar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cantidadAPagar.SelectedText = "";
            this.cantidadAPagar.SelectionLength = 0;
            this.cantidadAPagar.SelectionStart = 0;
            this.cantidadAPagar.ShortcutsEnabled = true;
            this.cantidadAPagar.Size = new System.Drawing.Size(107, 23);
            this.cantidadAPagar.TabIndex = 0;
            this.cantidadAPagar.UseSelectable = true;
            this.cantidadAPagar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cantidadAPagar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cantidadPagada
            // 
            // 
            // 
            // 
            this.cantidadPagada.CustomButton.Image = null;
            this.cantidadPagada.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.cantidadPagada.CustomButton.Name = "";
            this.cantidadPagada.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cantidadPagada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cantidadPagada.CustomButton.TabIndex = 1;
            this.cantidadPagada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cantidadPagada.CustomButton.UseSelectable = true;
            this.cantidadPagada.CustomButton.Visible = false;
            this.cantidadPagada.Lines = new string[0];
            this.cantidadPagada.Location = new System.Drawing.Point(176, 160);
            this.cantidadPagada.MaxLength = 32767;
            this.cantidadPagada.Name = "cantidadPagada";
            this.cantidadPagada.PasswordChar = '\0';
            this.cantidadPagada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cantidadPagada.SelectedText = "";
            this.cantidadPagada.SelectionLength = 0;
            this.cantidadPagada.SelectionStart = 0;
            this.cantidadPagada.ShortcutsEnabled = true;
            this.cantidadPagada.Size = new System.Drawing.Size(107, 23);
            this.cantidadPagada.TabIndex = 1;
            this.cantidadPagada.UseSelectable = true;
            this.cantidadPagada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cantidadPagada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Cantidad a pagar:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(55, 160);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Cantidad pagada:";
            // 
            // CancelarTile
            // 
            this.CancelarTile.ActiveControl = null;
            this.CancelarTile.Location = new System.Drawing.Point(24, 253);
            this.CancelarTile.Name = "CancelarTile";
            this.CancelarTile.Size = new System.Drawing.Size(98, 40);
            this.CancelarTile.TabIndex = 4;
            this.CancelarTile.Text = "Cancelar";
            this.CancelarTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarTile.UseSelectable = true;
            this.CancelarTile.Click += new System.EventHandler(this.CancelarTile_Click);
            // 
            // AceptarTile
            // 
            this.AceptarTile.ActiveControl = null;
            this.AceptarTile.Location = new System.Drawing.Point(283, 253);
            this.AceptarTile.Name = "AceptarTile";
            this.AceptarTile.Size = new System.Drawing.Size(98, 40);
            this.AceptarTile.TabIndex = 5;
            this.AceptarTile.Text = "Aceptar";
            this.AceptarTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarTile.UseSelectable = true;
            this.AceptarTile.Click += new System.EventHandler(this.AceptarTile_Click);
            // 
            // ActualizarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 316);
            this.Controls.Add(this.AceptarTile);
            this.Controls.Add(this.CancelarTile);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cantidadPagada);
            this.Controls.Add(this.cantidadAPagar);
            this.Name = "ActualizarPago";
            this.Text = "ActualizarPago";
            this.Load += new System.EventHandler(this.ActualizarPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox cantidadAPagar;
        private MetroFramework.Controls.MetroTextBox cantidadPagada;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile CancelarTile;
        private MetroFramework.Controls.MetroTile AceptarTile;
    }
}