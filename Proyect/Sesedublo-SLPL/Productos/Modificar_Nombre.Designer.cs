namespace Sesedublo_SLPL.Productos
{
    partial class Modificar_Nombre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar_Nombre));
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.titleCancelar = new MetroFramework.Controls.MetroTile();
            this.titleAceptar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre del producto:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(168, 88);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre.MaxLength = 100;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(192, 20);
            this.Nombre.TabIndex = 40;
            // 
            // titleCancelar
            // 
            this.titleCancelar.ActiveControl = null;
            this.titleCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.titleCancelar.Location = new System.Drawing.Point(54, 132);
            this.titleCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.titleCancelar.Name = "titleCancelar";
            this.titleCancelar.Size = new System.Drawing.Size(102, 41);
            this.titleCancelar.TabIndex = 43;
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
            this.titleAceptar.Location = new System.Drawing.Point(211, 132);
            this.titleAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.titleAceptar.Name = "titleAceptar";
            this.titleAceptar.Size = new System.Drawing.Size(99, 41);
            this.titleAceptar.TabIndex = 42;
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
            // Modificar_Nombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 209);
            this.Controls.Add(this.titleCancelar);
            this.Controls.Add(this.titleAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Name = "Modificar_Nombre";
            this.Text = "Modificar Nombre de Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre;
        private MetroFramework.Controls.MetroTile titleCancelar;
        private MetroFramework.Controls.MetroTile titleAceptar;
    }
}