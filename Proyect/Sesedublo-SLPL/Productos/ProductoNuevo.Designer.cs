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
            this.PrecioLabel.Location = new System.Drawing.Point(49, 258);
            this.PrecioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(52, 17);
            this.PrecioLabel.TabIndex = 52;
            this.PrecioLabel.Text = "Precio:";
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(260, 255);
            this.Precio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Precio.MaxLength = 10;
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(132, 22);
            this.Precio.TabIndex = 42;
            this.Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precio_KeyPress);
            // 
            // titleCancelar
            // 
            this.titleCancelar.ActiveControl = null;
            this.titleCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.titleCancelar.Location = new System.Drawing.Point(49, 341);
            this.titleCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.titleCancelar.Name = "titleCancelar";
            this.titleCancelar.Size = new System.Drawing.Size(136, 50);
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
            this.titleAceptar.Location = new System.Drawing.Point(260, 341);
            this.titleAceptar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.titleAceptar.Name = "titleAceptar";
            this.titleAceptar.Size = new System.Drawing.Size(132, 50);
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
            this.bultoRadio.Location = new System.Drawing.Point(240, 145);
            this.bultoRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bultoRadio.Name = "bultoRadio";
            this.bultoRadio.Size = new System.Drawing.Size(53, 17);
            this.bultoRadio.TabIndex = 35;
            this.bultoRadio.Text = "Bulto";
            this.bultoRadio.UseSelectable = true;
            // 
            // individualRadio
            // 
            this.individualRadio.AutoSize = true;
            this.individualRadio.Location = new System.Drawing.Point(121, 145);
            this.individualRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.individualRadio.Name = "individualRadio";
            this.individualRadio.Size = new System.Drawing.Size(79, 17);
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
            this.UnidadesXBulto.Location = new System.Drawing.Point(260, 287);
            this.UnidadesXBulto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UnidadesXBulto.Name = "UnidadesXBulto";
            this.UnidadesXBulto.Size = new System.Drawing.Size(132, 24);
            this.UnidadesXBulto.TabIndex = 43;
            this.UnidadesXBulto.SelectedIndexChanged += new System.EventHandler(this.UnidadesXBulto_SelectedIndexChanged);
            // 
            // UnidadesXBultoLbl
            // 
            this.UnidadesXBultoLbl.AutoSize = true;
            this.UnidadesXBultoLbl.Location = new System.Drawing.Point(49, 290);
            this.UnidadesXBultoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnidadesXBultoLbl.Name = "UnidadesXBultoLbl";
            this.UnidadesXBultoLbl.Size = new System.Drawing.Size(130, 17);
            this.UnidadesXBultoLbl.TabIndex = 48;
            this.UnidadesXBultoLbl.Text = "Unidades del bulto:";
            // 
            // Costo
            // 
            this.Costo.Location = new System.Drawing.Point(260, 192);
            this.Costo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Costo.MaxLength = 12;
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(132, 22);
            this.Costo.TabIndex = 36;
            this.Costo.TextChanged += new System.EventHandler(this.Costo_TextChanged);
            this.Costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Costo_KeyPress);
            // 
            // CostoLabel
            // 
            this.CostoLabel.AutoSize = true;
            this.CostoLabel.Location = new System.Drawing.Point(49, 196);
            this.CostoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostoLabel.Name = "CostoLabel";
            this.CostoLabel.Size = new System.Drawing.Size(48, 17);
            this.CostoLabel.TabIndex = 45;
            this.CostoLabel.Text = "Costo:";
            // 
            // UtilidadLabel
            // 
            this.UtilidadLabel.AutoSize = true;
            this.UtilidadLabel.Location = new System.Drawing.Point(49, 228);
            this.UtilidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UtilidadLabel.Name = "UtilidadLabel";
            this.UtilidadLabel.Size = new System.Drawing.Size(131, 17);
            this.UtilidadLabel.TabIndex = 41;
            this.UtilidadLabel.Text = "Utilidad por unidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre del producto:";
            // 
            // Utilidad
            // 
            this.Utilidad.Location = new System.Drawing.Point(260, 224);
            this.Utilidad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Utilidad.MaxLength = 10;
            this.Utilidad.Name = "Utilidad";
            this.Utilidad.Size = new System.Drawing.Size(132, 22);
            this.Utilidad.TabIndex = 40;
            this.Utilidad.TextChanged += new System.EventHandler(this.Utilidad_TextChanged);
            this.Utilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Utilidad_KeyPress);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(201, 102);
            this.Nombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Nombre.MaxLength = 100;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(255, 22);
            this.Nombre.TabIndex = 33;
            // 
            // Producto_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 434);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Producto_Nuevo";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Producto Nuevo";
            this.Load += new System.EventHandler(this.Producto_Nuevo_Load);
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