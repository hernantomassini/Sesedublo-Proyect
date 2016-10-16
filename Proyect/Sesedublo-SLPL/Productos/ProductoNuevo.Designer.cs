namespace Sesedublo_SLPL.Productos
{
    partial class Producto_Nuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto_Nuevo));
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.TextBox();
            this.titleCancelar = new MetroFramework.Controls.MetroTile();
            this.titleAceptar = new MetroFramework.Controls.MetroTile();
            this.bultoRadio = new MetroFramework.Controls.MetroRadioButton();
            this.individualRadio = new MetroFramework.Controls.MetroRadioButton();
            this.UnidadesXBulto = new System.Windows.Forms.ComboBox();
            this.UnidadesXBultoLbl = new System.Windows.Forms.Label();
            this.Costo = new System.Windows.Forms.TextBox();
            this.CostoLabel = new System.Windows.Forms.Label();
            this.UtilidadLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Utilidad = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Location = new System.Drawing.Point(37, 210);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(40, 13);
            this.PrecioLabel.TabIndex = 52;
            this.PrecioLabel.Text = "Precio:";
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(195, 207);
            this.Precio.Margin = new System.Windows.Forms.Padding(4);
            this.Precio.MaxLength = 10;
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(100, 20);
            this.Precio.TabIndex = 42;
            this.Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precio_KeyPress);
            // 
            // titleCancelar
            // 
            this.titleCancelar.ActiveControl = null;
            this.titleCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.titleCancelar.Location = new System.Drawing.Point(37, 277);
            this.titleCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.titleCancelar.Name = "titleCancelar";
            this.titleCancelar.Size = new System.Drawing.Size(102, 41);
            this.titleCancelar.TabIndex = 47;
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
            this.titleAceptar.Location = new System.Drawing.Point(195, 277);
            this.titleAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.titleAceptar.Name = "titleAceptar";
            this.titleAceptar.Size = new System.Drawing.Size(99, 41);
            this.titleAceptar.TabIndex = 44;
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
            // bultoRadio
            // 
            this.bultoRadio.AutoSize = true;
            this.bultoRadio.Location = new System.Drawing.Point(180, 118);
            this.bultoRadio.Margin = new System.Windows.Forms.Padding(2);
            this.bultoRadio.Name = "bultoRadio";
            this.bultoRadio.Size = new System.Drawing.Size(51, 15);
            this.bultoRadio.TabIndex = 35;
            this.bultoRadio.Text = "Bulto";
            this.bultoRadio.UseSelectable = true;
            // 
            // individualRadio
            // 
            this.individualRadio.AutoSize = true;
            this.individualRadio.Location = new System.Drawing.Point(91, 118);
            this.individualRadio.Margin = new System.Windows.Forms.Padding(2);
            this.individualRadio.Name = "individualRadio";
            this.individualRadio.Size = new System.Drawing.Size(75, 15);
            this.individualRadio.TabIndex = 34;
            this.individualRadio.Text = "Individual";
            this.individualRadio.UseSelectable = true;
            this.individualRadio.CheckedChanged += new System.EventHandler(this.individualRadio_CheckedChanged);
            // 
            // UnidadesXBulto
            // 
            this.UnidadesXBulto.FormattingEnabled = true;
            this.UnidadesXBulto.Items.AddRange(new object[] {
            "6",
            "12",
            "24"});
            this.UnidadesXBulto.Location = new System.Drawing.Point(195, 233);
            this.UnidadesXBulto.Margin = new System.Windows.Forms.Padding(4);
            this.UnidadesXBulto.Name = "UnidadesXBulto";
            this.UnidadesXBulto.Size = new System.Drawing.Size(100, 21);
            this.UnidadesXBulto.TabIndex = 43;
            // 
            // UnidadesXBultoLbl
            // 
            this.UnidadesXBultoLbl.AutoSize = true;
            this.UnidadesXBultoLbl.Location = new System.Drawing.Point(37, 236);
            this.UnidadesXBultoLbl.Name = "UnidadesXBultoLbl";
            this.UnidadesXBultoLbl.Size = new System.Drawing.Size(98, 13);
            this.UnidadesXBultoLbl.TabIndex = 48;
            this.UnidadesXBultoLbl.Text = "Unidades del bulto:";
            // 
            // Costo
            // 
            this.Costo.Location = new System.Drawing.Point(195, 156);
            this.Costo.Margin = new System.Windows.Forms.Padding(4);
            this.Costo.MaxLength = 12;
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(100, 20);
            this.Costo.TabIndex = 36;
            this.Costo.TextChanged += new System.EventHandler(this.Costo_TextChanged);
            this.Costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Costo_KeyPress);
            // 
            // CostoLabel
            // 
            this.CostoLabel.AutoSize = true;
            this.CostoLabel.Location = new System.Drawing.Point(37, 159);
            this.CostoLabel.Name = "CostoLabel";
            this.CostoLabel.Size = new System.Drawing.Size(37, 13);
            this.CostoLabel.TabIndex = 45;
            this.CostoLabel.Text = "Costo:";
            // 
            // UtilidadLabel
            // 
            this.UtilidadLabel.AutoSize = true;
            this.UtilidadLabel.Location = new System.Drawing.Point(37, 185);
            this.UtilidadLabel.Name = "UtilidadLabel";
            this.UtilidadLabel.Size = new System.Drawing.Size(98, 13);
            this.UtilidadLabel.TabIndex = 41;
            this.UtilidadLabel.Text = "Utilidad por unidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre del producto:";
            // 
            // Utilidad
            // 
            this.Utilidad.Location = new System.Drawing.Point(195, 182);
            this.Utilidad.Margin = new System.Windows.Forms.Padding(4);
            this.Utilidad.MaxLength = 10;
            this.Utilidad.Name = "Utilidad";
            this.Utilidad.Size = new System.Drawing.Size(100, 20);
            this.Utilidad.TabIndex = 40;
            this.Utilidad.TextChanged += new System.EventHandler(this.Utilidad_TextChanged);
            this.Utilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Utilidad_KeyPress);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(151, 83);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre.MaxLength = 100;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(192, 20);
            this.Nombre.TabIndex = 33;
            // 
            // Producto_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 353);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.titleCancelar);
            this.Controls.Add(this.titleAceptar);
            this.Controls.Add(this.bultoRadio);
            this.Controls.Add(this.individualRadio);
            this.Controls.Add(this.UnidadesXBulto);
            this.Controls.Add(this.UnidadesXBultoLbl);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.CostoLabel);
            this.Controls.Add(this.UtilidadLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Utilidad);
            this.Controls.Add(this.Nombre);
            this.MaximizeBox = false;
            this.Name = "Producto_Nuevo";
            this.Text = "Producto Nuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.TextBox Precio;
        private MetroFramework.Controls.MetroTile titleCancelar;
        private MetroFramework.Controls.MetroTile titleAceptar;
        private MetroFramework.Controls.MetroRadioButton bultoRadio;
        private MetroFramework.Controls.MetroRadioButton individualRadio;
        private System.Windows.Forms.ComboBox UnidadesXBulto;
        private System.Windows.Forms.Label UnidadesXBultoLbl;
        private System.Windows.Forms.TextBox Costo;
        private System.Windows.Forms.Label CostoLabel;
        private System.Windows.Forms.Label UtilidadLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Utilidad;
        private System.Windows.Forms.TextBox Nombre;

    }
}