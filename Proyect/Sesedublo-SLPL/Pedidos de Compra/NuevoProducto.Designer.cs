namespace Sesedublo_SLPL.Pedidos_de_Compra
{
    partial class NuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoProducto));
            this.titleCancelar = new MetroFramework.Controls.MetroTile();
            this.titleAceptar = new MetroFramework.Controls.MetroTile();
            this.buscarProducto = new MetroFramework.Controls.MetroTextBox();
            this.nombreLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // titleCancelar
            // 
            this.titleCancelar.ActiveControl = null;
            this.titleCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.titleCancelar.Location = new System.Drawing.Point(91, 93);
            this.titleCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.titleCancelar.Name = "titleCancelar";
            this.titleCancelar.Size = new System.Drawing.Size(102, 41);
            this.titleCancelar.TabIndex = 33;
            this.titleCancelar.Text = "Cancelar";
            this.titleCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleCancelar.TileImage = ((System.Drawing.Image)(resources.GetObject("titleCancelar.TileImage")));
            this.titleCancelar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleCancelar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleCancelar.UseCustomBackColor = true;
            this.titleCancelar.UseSelectable = true;
            this.titleCancelar.UseTileImage = true;
            this.titleCancelar.Click += new System.EventHandler(this.titleCancelar_Click);
            // 
            // titleAceptar
            // 
            this.titleAceptar.ActiveControl = null;
            this.titleAceptar.BackColor = System.Drawing.Color.Green;
            this.titleAceptar.Location = new System.Drawing.Point(201, 93);
            this.titleAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.titleAceptar.Name = "titleAceptar";
            this.titleAceptar.Size = new System.Drawing.Size(99, 41);
            this.titleAceptar.TabIndex = 32;
            this.titleAceptar.Text = "Aceptar";
            this.titleAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleAceptar.TileImage = ((System.Drawing.Image)(resources.GetObject("titleAceptar.TileImage")));
            this.titleAceptar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleAceptar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleAceptar.UseCustomBackColor = true;
            this.titleAceptar.UseSelectable = true;
            this.titleAceptar.UseTileImage = true;
            this.titleAceptar.Click += new System.EventHandler(this.titleAceptar_Click);
            // 
            // buscarProducto
            // 
            // 
            // 
            // 
            this.buscarProducto.CustomButton.Image = null;
            this.buscarProducto.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.buscarProducto.CustomButton.Name = "";
            this.buscarProducto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.buscarProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.buscarProducto.CustomButton.TabIndex = 1;
            this.buscarProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buscarProducto.CustomButton.UseSelectable = true;
            this.buscarProducto.CustomButton.Visible = false;
            this.buscarProducto.Icon = ((System.Drawing.Image)(resources.GetObject("buscarProducto.Icon")));
            this.buscarProducto.Lines = new string[0];
            this.buscarProducto.Location = new System.Drawing.Point(91, 60);
            this.buscarProducto.MaxLength = 70;
            this.buscarProducto.Name = "buscarProducto";
            this.buscarProducto.PasswordChar = '\0';
            this.buscarProducto.PromptText = "Ingrese el nombre";
            this.buscarProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.buscarProducto.SelectedText = "";
            this.buscarProducto.SelectionLength = 0;
            this.buscarProducto.SelectionStart = 0;
            this.buscarProducto.ShortcutsEnabled = true;
            this.buscarProducto.Size = new System.Drawing.Size(209, 23);
            this.buscarProducto.TabIndex = 38;
            this.buscarProducto.UseSelectable = true;
            this.buscarProducto.WaterMark = "Ingrese el nombre";
            this.buscarProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.buscarProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(23, 60);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(62, 19);
            this.nombreLabel.TabIndex = 37;
            this.nombreLabel.Text = "Nombre:";
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 158);
            this.Controls.Add(this.buscarProducto);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.titleCancelar);
            this.Controls.Add(this.titleAceptar);
            this.Name = "NuevoProducto";
            this.Text = "Nuevo Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile titleCancelar;
        private MetroFramework.Controls.MetroTile titleAceptar;
        private MetroFramework.Controls.MetroTextBox buscarProducto;
        private MetroFramework.Controls.MetroLabel nombreLabel;
    }
}