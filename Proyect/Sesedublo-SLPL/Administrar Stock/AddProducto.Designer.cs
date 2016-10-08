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
            this.CantidadIndividual = new System.Windows.Forms.TextBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.CantidadBultos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UnidadesXBulto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CantidadIndividual
            // 
            this.CantidadIndividual.Location = new System.Drawing.Point(128, 28);
            this.CantidadIndividual.MaxLength = 5;
            this.CantidadIndividual.Name = "CantidadIndividual";
            this.CantidadIndividual.Size = new System.Drawing.Size(100, 20);
            this.CantidadIndividual.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(128, 107);
            this.Nombre.MaxLength = 100;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 1;
            // 
            // PVunitario
            // 
            this.PVunitario.Location = new System.Drawing.Point(128, 160);
            this.PVunitario.Name = "PVunitario";
            this.PVunitario.Size = new System.Drawing.Size(100, 20);
            this.PVunitario.TabIndex = 2;
            // 
            // PVBulto
            // 
            this.PVBulto.Location = new System.Drawing.Point(128, 186);
            this.PVBulto.Name = "PVBulto";
            this.PVBulto.Size = new System.Drawing.Size(100, 20);
            this.PVBulto.TabIndex = 3;
            // 
            // AtrasBtn
            // 
            this.AtrasBtn.Location = new System.Drawing.Point(12, 235);
            this.AtrasBtn.Name = "AtrasBtn";
            this.AtrasBtn.Size = new System.Drawing.Size(81, 28);
            this.AtrasBtn.TabIndex = 4;
            this.AtrasBtn.Text = "Atras";
            this.AtrasBtn.UseVisualStyleBackColor = true;
            this.AtrasBtn.Click += new System.EventHandler(this.AtrasBtn_Click);
            // 
            // AgregarProductoBtn
            // 
            this.AgregarProductoBtn.Location = new System.Drawing.Point(174, 235);
            this.AgregarProductoBtn.Name = "AgregarProductoBtn";
            this.AgregarProductoBtn.Size = new System.Drawing.Size(75, 28);
            this.AgregarProductoBtn.TabIndex = 5;
            this.AgregarProductoBtn.Text = "Aceptar";
            this.AgregarProductoBtn.UseVisualStyleBackColor = true;
            this.AgregarProductoBtn.Click += new System.EventHandler(this.AgregarProductoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad individual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio por bulto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Costo:";
            // 
            // Costo
            // 
            this.Costo.Location = new System.Drawing.Point(128, 133);
            this.Costo.MaxLength = 12;
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(100, 20);
            this.Costo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de bultos:";
            // 
            // CantidadBultos
            // 
            this.CantidadBultos.Location = new System.Drawing.Point(128, 54);
            this.CantidadBultos.Name = "CantidadBultos";
            this.CantidadBultos.Size = new System.Drawing.Size(100, 20);
            this.CantidadBultos.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
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
            this.UnidadesXBulto.Location = new System.Drawing.Point(128, 80);
            this.UnidadesXBulto.Name = "UnidadesXBulto";
            this.UnidadesXBulto.Size = new System.Drawing.Size(100, 21);
            this.UnidadesXBulto.TabIndex = 15;
            // 
            // AddProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 275);
            this.Controls.Add(this.UnidadesXBulto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CantidadBultos);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.CantidadIndividual);
            this.Name = "AddProducto";
            this.Text = "AddProducto";
            this.Load += new System.EventHandler(this.AddProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CantidadIndividual;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CantidadBultos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox UnidadesXBulto;
    }
}