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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarPago));
            this.cantidadAPagar = new MetroFramework.Controls.MetroTextBox();
            this.cantidadPagada = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.titleCancelar = new MetroFramework.Controls.MetroTile();
            this.titleAceptar = new MetroFramework.Controls.MetroTile();
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
            this.cantidadAPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadAPagar_KeyPress);
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
            this.cantidadPagada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadPagada_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 19);
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
            // titleCancelar
            // 
            this.titleCancelar.ActiveControl = null;
            this.titleCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.titleCancelar.Location = new System.Drawing.Point(55, 208);
            this.titleCancelar.Name = "titleCancelar";
            this.titleCancelar.Size = new System.Drawing.Size(102, 41);
            this.titleCancelar.TabIndex = 12;
            this.titleCancelar.Text = "Cancelar";
            this.titleCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleCancelar.TileImage = ((System.Drawing.Image)(resources.GetObject("titleCancelar.TileImage")));
            this.titleCancelar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleCancelar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleCancelar.UseCustomBackColor = true;
            this.titleCancelar.UseSelectable = true;
            this.titleCancelar.UseTileImage = true;
            this.titleCancelar.Click += new System.EventHandler(this.CancelarTile_Click);
            // 
            // titleAceptar
            // 
            this.titleAceptar.ActiveControl = null;
            this.titleAceptar.BackColor = System.Drawing.Color.Green;
            this.titleAceptar.Location = new System.Drawing.Point(173, 208);
            this.titleAceptar.Name = "titleAceptar";
            this.titleAceptar.Size = new System.Drawing.Size(99, 41);
            this.titleAceptar.TabIndex = 11;
            this.titleAceptar.Text = "Aceptar";
            this.titleAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleAceptar.TileImage = ((System.Drawing.Image)(resources.GetObject("titleAceptar.TileImage")));
            this.titleAceptar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleAceptar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleAceptar.UseCustomBackColor = true;
            this.titleAceptar.UseSelectable = true;
            this.titleAceptar.UseTileImage = true;
            this.titleAceptar.Click += new System.EventHandler(this.AceptarTile_Click);
            // 
            // ActualizarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 282);
            this.Controls.Add(this.titleCancelar);
            this.Controls.Add(this.titleAceptar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cantidadPagada);
            this.Controls.Add(this.cantidadAPagar);
            this.Name = "ActualizarPago";
            this.Text = "Actualizar Pago";
            this.Load += new System.EventHandler(this.ActualizarPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox cantidadAPagar;
        private MetroFramework.Controls.MetroTextBox cantidadPagada;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile titleCancelar;
        private MetroFramework.Controls.MetroTile titleAceptar;
    }
}