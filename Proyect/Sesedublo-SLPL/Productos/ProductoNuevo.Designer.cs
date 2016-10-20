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
            this.UnidadesXBulto = new System.Windows.Forms.ComboBox();
            this.UnidadesXBultoLbl = new System.Windows.Forms.Label();
            this.Costo = new System.Windows.Forms.TextBox();
            this.CostoLabel = new System.Windows.Forms.Label();
            this.UtilidadLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Utilidad = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.costoIndividual = new System.Windows.Forms.TextBox();
            this.CostoIndividualLabel = new System.Windows.Forms.Label();
            this.unidadesObligatorio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bultoCuadradoRadio = new MetroFramework.Controls.MetroRadioButton();
            this.bultoxBotellaRadio = new MetroFramework.Controls.MetroRadioButton();
            this.individualRadio = new MetroFramework.Controls.MetroRadioButton();
            this.costoIndividualObligatory = new System.Windows.Forms.Label();
            this.costoSegunRadioObligatory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Location = new System.Drawing.Point(33, 249);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(40, 13);
            this.PrecioLabel.TabIndex = 52;
            this.PrecioLabel.Text = "Precio:";
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(191, 246);
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
            this.titleCancelar.Location = new System.Drawing.Point(50, 341);
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
            this.titleAceptar.Location = new System.Drawing.Point(207, 341);
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
            // UnidadesXBulto
            // 
            this.UnidadesXBulto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnidadesXBulto.FormattingEnabled = true;
            this.UnidadesXBulto.Items.AddRange(new object[] {
            "6",
            "12",
            "24"});
            this.UnidadesXBulto.Location = new System.Drawing.Point(191, 272);
            this.UnidadesXBulto.Margin = new System.Windows.Forms.Padding(4);
            this.UnidadesXBulto.Name = "UnidadesXBulto";
            this.UnidadesXBulto.Size = new System.Drawing.Size(100, 21);
            this.UnidadesXBulto.TabIndex = 43;
            this.UnidadesXBulto.SelectedIndexChanged += new System.EventHandler(this.UnidadesXBulto_SelectedIndexChanged);
            // 
            // UnidadesXBultoLbl
            // 
            this.UnidadesXBultoLbl.AutoSize = true;
            this.UnidadesXBultoLbl.Location = new System.Drawing.Point(33, 275);
            this.UnidadesXBultoLbl.Name = "UnidadesXBultoLbl";
            this.UnidadesXBultoLbl.Size = new System.Drawing.Size(98, 13);
            this.UnidadesXBultoLbl.TabIndex = 48;
            this.UnidadesXBultoLbl.Text = "Unidades del bulto:";
            // 
            // Costo
            // 
            this.Costo.Location = new System.Drawing.Point(191, 195);
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
            this.CostoLabel.Location = new System.Drawing.Point(33, 198);
            this.CostoLabel.Name = "CostoLabel";
            this.CostoLabel.Size = new System.Drawing.Size(37, 13);
            this.CostoLabel.TabIndex = 45;
            this.CostoLabel.Text = "Costo:";
            // 
            // UtilidadLabel
            // 
            this.UtilidadLabel.AutoSize = true;
            this.UtilidadLabel.Location = new System.Drawing.Point(33, 224);
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
            this.Utilidad.Location = new System.Drawing.Point(191, 221);
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
            // costoIndividual
            // 
            this.costoIndividual.Location = new System.Drawing.Point(191, 167);
            this.costoIndividual.Margin = new System.Windows.Forms.Padding(4);
            this.costoIndividual.MaxLength = 12;
            this.costoIndividual.Name = "costoIndividual";
            this.costoIndividual.Size = new System.Drawing.Size(100, 20);
            this.costoIndividual.TabIndex = 54;
            this.costoIndividual.Visible = false;
            this.costoIndividual.TextChanged += new System.EventHandler(this.costoIndividual_TextChanged);
            this.costoIndividual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Costo_KeyPress);
            // 
            // CostoIndividualLabel
            // 
            this.CostoIndividualLabel.AutoSize = true;
            this.CostoIndividualLabel.Location = new System.Drawing.Point(34, 167);
            this.CostoIndividualLabel.Name = "CostoIndividualLabel";
            this.CostoIndividualLabel.Size = new System.Drawing.Size(84, 13);
            this.CostoIndividualLabel.TabIndex = 55;
            this.CostoIndividualLabel.Text = "Costo individual:";
            this.CostoIndividualLabel.Visible = false;
            // 
            // unidadesObligatorio
            // 
            this.unidadesObligatorio.AutoSize = true;
            this.unidadesObligatorio.Location = new System.Drawing.Point(295, 275);
            this.unidadesObligatorio.Name = "unidadesObligatorio";
            this.unidadesObligatorio.Size = new System.Drawing.Size(11, 13);
            this.unidadesObligatorio.TabIndex = 59;
            this.unidadesObligatorio.Text = "*";
            this.unidadesObligatorio.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "*";
            // 
            // bultoCuadradoRadio
            // 
            this.bultoCuadradoRadio.AutoSize = true;
            this.bultoCuadradoRadio.Location = new System.Drawing.Point(234, 123);
            this.bultoCuadradoRadio.Name = "bultoCuadradoRadio";
            this.bultoCuadradoRadio.Size = new System.Drawing.Size(115, 15);
            this.bultoCuadradoRadio.TabIndex = 62;
            this.bultoCuadradoRadio.Text = "Ganancia al bulto";
            this.bultoCuadradoRadio.UseSelectable = true;
            this.bultoCuadradoRadio.CheckedChanged += new System.EventHandler(this.bultoCuadradoRadio_CheckedChanged);
            // 
            // bultoxBotellaRadio
            // 
            this.bultoxBotellaRadio.AutoSize = true;
            this.bultoxBotellaRadio.Location = new System.Drawing.Point(101, 123);
            this.bultoxBotellaRadio.Margin = new System.Windows.Forms.Padding(2);
            this.bultoxBotellaRadio.Name = "bultoxBotellaRadio";
            this.bultoxBotellaRadio.Size = new System.Drawing.Size(132, 15);
            this.bultoxBotellaRadio.TabIndex = 61;
            this.bultoxBotellaRadio.Text = "Ganancia a la botella";
            this.bultoxBotellaRadio.UseSelectable = true;
            this.bultoxBotellaRadio.CheckedChanged += new System.EventHandler(this.bultoRadio_CheckedChanged);
            // 
            // individualRadio
            // 
            this.individualRadio.AutoSize = true;
            this.individualRadio.Location = new System.Drawing.Point(22, 123);
            this.individualRadio.Margin = new System.Windows.Forms.Padding(2);
            this.individualRadio.Name = "individualRadio";
            this.individualRadio.Size = new System.Drawing.Size(75, 15);
            this.individualRadio.TabIndex = 60;
            this.individualRadio.Text = "Individual";
            this.individualRadio.UseSelectable = true;
            this.individualRadio.CheckedChanged += new System.EventHandler(this.individualRadio_CheckedChanged);
            // 
            // costoIndividualObligatory
            // 
            this.costoIndividualObligatory.AutoSize = true;
            this.costoIndividualObligatory.Location = new System.Drawing.Point(295, 170);
            this.costoIndividualObligatory.Name = "costoIndividualObligatory";
            this.costoIndividualObligatory.Size = new System.Drawing.Size(11, 13);
            this.costoIndividualObligatory.TabIndex = 64;
            this.costoIndividualObligatory.Text = "*";
            // 
            // costoSegunRadioObligatory
            // 
            this.costoSegunRadioObligatory.AutoSize = true;
            this.costoSegunRadioObligatory.Location = new System.Drawing.Point(295, 198);
            this.costoSegunRadioObligatory.Name = "costoSegunRadioObligatory";
            this.costoSegunRadioObligatory.Size = new System.Drawing.Size(11, 13);
            this.costoSegunRadioObligatory.TabIndex = 63;
            this.costoSegunRadioObligatory.Text = "*";
            // 
            // Producto_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 406);
            this.Controls.Add(this.costoIndividualObligatory);
            this.Controls.Add(this.costoSegunRadioObligatory);
            this.Controls.Add(this.bultoCuadradoRadio);
            this.Controls.Add(this.bultoxBotellaRadio);
            this.Controls.Add(this.individualRadio);
            this.Controls.Add(this.unidadesObligatorio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.costoIndividual);
            this.Controls.Add(this.CostoIndividualLabel);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.titleCancelar);
            this.Controls.Add(this.titleAceptar);
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
            this.Load += new System.EventHandler(this.Producto_Nuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.TextBox Precio;
        private MetroFramework.Controls.MetroTile titleCancelar;
        private MetroFramework.Controls.MetroTile titleAceptar;
        private System.Windows.Forms.ComboBox UnidadesXBulto;
        private System.Windows.Forms.Label UnidadesXBultoLbl;
        private System.Windows.Forms.TextBox Costo;
        private System.Windows.Forms.Label CostoLabel;
        private System.Windows.Forms.Label UtilidadLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Utilidad;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox costoIndividual;
        private System.Windows.Forms.Label CostoIndividualLabel;
        private System.Windows.Forms.Label unidadesObligatorio;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroRadioButton bultoCuadradoRadio;
        private MetroFramework.Controls.MetroRadioButton bultoxBotellaRadio;
        private MetroFramework.Controls.MetroRadioButton individualRadio;
        private System.Windows.Forms.Label costoIndividualObligatory;
        private System.Windows.Forms.Label costoSegunRadioObligatory;
    }
}