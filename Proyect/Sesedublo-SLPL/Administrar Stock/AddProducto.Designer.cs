namespace Sesedublo_SLPL.Administrar_Stock
{
    partial class AddProducto
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
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.PVunitario = new System.Windows.Forms.TextBox();
            this.PVBulto = new System.Windows.Forms.TextBox();
            this.AtrasBtn = new System.Windows.Forms.Button();
            this.AgregarProductoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Costo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UnidadesXBulto = new System.Windows.Forms.ComboBox();
            this.individualRadio = new MetroFramework.Controls.MetroRadioButton();
            this.bultoRadio = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(183, 117);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.Cantidad.MaxLength = 5;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(132, 22);
            this.Cantidad.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(183, 87);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre.MaxLength = 100;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(132, 22);
            this.Nombre.TabIndex = 1;
            // 
            // PVunitario
            // 
            this.PVunitario.Location = new System.Drawing.Point(183, 264);
            this.PVunitario.Margin = new System.Windows.Forms.Padding(4);
            this.PVunitario.Name = "PVunitario";
            this.PVunitario.Size = new System.Drawing.Size(132, 22);
            this.PVunitario.TabIndex = 2;
            // 
            // PVBulto
            // 
            this.PVBulto.Location = new System.Drawing.Point(183, 294);
            this.PVBulto.Margin = new System.Windows.Forms.Padding(4);
            this.PVBulto.Name = "PVBulto";
            this.PVBulto.Size = new System.Drawing.Size(132, 22);
            this.PVBulto.TabIndex = 3;
            this.PVBulto.TextChanged += new System.EventHandler(this.PVBulto_TextChanged);
            // 
            // AtrasBtn
            // 
            this.AtrasBtn.Location = new System.Drawing.Point(34, 361);
            this.AtrasBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AtrasBtn.Name = "AtrasBtn";
            this.AtrasBtn.Size = new System.Drawing.Size(108, 34);
            this.AtrasBtn.TabIndex = 4;
            this.AtrasBtn.Text = "Atras";
            this.AtrasBtn.UseVisualStyleBackColor = true;
            this.AtrasBtn.Click += new System.EventHandler(this.AtrasBtn_Click);
            // 
            // AgregarProductoBtn
            // 
            this.AgregarProductoBtn.Location = new System.Drawing.Point(237, 361);
            this.AgregarProductoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarProductoBtn.Name = "AgregarProductoBtn";
            this.AgregarProductoBtn.Size = new System.Drawing.Size(100, 34);
            this.AgregarProductoBtn.TabIndex = 5;
            this.AgregarProductoBtn.Text = "Aceptar";
            this.AgregarProductoBtn.UseVisualStyleBackColor = true;
            this.AgregarProductoBtn.Click += new System.EventHandler(this.AgregarProductoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio por bulto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Costo:";
            // 
            // Costo
            // 
            this.Costo.Location = new System.Drawing.Point(183, 234);
            this.Costo.Margin = new System.Windows.Forms.Padding(4);
            this.Costo.MaxLength = 12;
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(132, 22);
            this.Costo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Unidades del bulto:";
            // 
            // UnidadesXBulto
            // 
            this.UnidadesXBulto.FormattingEnabled = true;
            this.UnidadesXBulto.Items.AddRange(new object[] {
            "8",
            "12",
            "24"});
            this.UnidadesXBulto.Location = new System.Drawing.Point(183, 202);
            this.UnidadesXBulto.Margin = new System.Windows.Forms.Padding(4);
            this.UnidadesXBulto.Name = "UnidadesXBulto";
            this.UnidadesXBulto.Size = new System.Drawing.Size(132, 24);
            this.UnidadesXBulto.TabIndex = 15;
            this.UnidadesXBulto.SelectedIndexChanged += new System.EventHandler(this.UnidadesXBulto_SelectedIndexChanged);
            // 
            // individualRadio
            // 
            this.individualRadio.AutoSize = true;
            this.individualRadio.Location = new System.Drawing.Point(82, 153);
            this.individualRadio.Name = "individualRadio";
            this.individualRadio.Size = new System.Drawing.Size(79, 17);
            this.individualRadio.TabIndex = 16;
            this.individualRadio.Text = "Individual";
            this.individualRadio.UseSelectable = true;
            this.individualRadio.CheckedChanged += new System.EventHandler(this.individualRadio_CheckedChanged);
            // 
            // bultoRadio
            // 
            this.bultoRadio.AutoSize = true;
            this.bultoRadio.Location = new System.Drawing.Point(183, 153);
            this.bultoRadio.Name = "bultoRadio";
            this.bultoRadio.Size = new System.Drawing.Size(53, 17);
            this.bultoRadio.TabIndex = 17;
            this.bultoRadio.Text = "Bulto";
            this.bultoRadio.UseSelectable = true;
            // 
            // AddProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 424);
            this.Controls.Add(this.bultoRadio);
            this.Controls.Add(this.individualRadio);
            this.Controls.Add(this.UnidadesXBulto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarProductoBtn);
            this.Controls.Add(this.AtrasBtn);
            this.Controls.Add(this.PVBulto);
            this.Controls.Add(this.PVunitario);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Cantidad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProducto";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.AddProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox PVunitario;
        private System.Windows.Forms.TextBox PVBulto;
        private System.Windows.Forms.Button AtrasBtn;
        private System.Windows.Forms.Button AgregarProductoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Costo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox UnidadesXBulto;
        private MetroFramework.Controls.MetroRadioButton individualRadio;
        private MetroFramework.Controls.MetroRadioButton bultoRadio;
    }
}