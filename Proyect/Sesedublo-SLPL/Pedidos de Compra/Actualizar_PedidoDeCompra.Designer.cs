﻿namespace Sesedublo_SLPL.Pedidos_de_Compra
{
    partial class Actualizar_PedidoDeCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_PedidoDeCompra));
            this.pagadoCheck = new MetroFramework.Controls.MetroCheckBox();
            this.titleCancelar = new MetroFramework.Controls.MetroTile();
            this.titleAceptar = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cantidadPagada = new MetroFramework.Controls.MetroTextBox();
            this.cantidadAPagar = new MetroFramework.Controls.MetroTextBox();
            this.ctacorriente = new MetroFramework.Controls.MetroRadioButton();
            this.Caja = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // pagadoCheck
            // 
            this.pagadoCheck.AutoSize = true;
            this.pagadoCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pagadoCheck.Location = new System.Drawing.Point(35, 178);
            this.pagadoCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pagadoCheck.Name = "pagadoCheck";
            this.pagadoCheck.Size = new System.Drawing.Size(151, 17);
            this.pagadoCheck.TabIndex = 27;
            this.pagadoCheck.Text = "Es el pago completo?";
            this.pagadoCheck.UseSelectable = true;
            // 
            // titleCancelar
            // 
            this.titleCancelar.ActiveControl = null;
            this.titleCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.titleCancelar.Location = new System.Drawing.Point(31, 274);
            this.titleCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleCancelar.Name = "titleCancelar";
            this.titleCancelar.Size = new System.Drawing.Size(136, 50);
            this.titleCancelar.TabIndex = 26;
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
            this.titleAceptar.Location = new System.Drawing.Point(203, 274);
            this.titleAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleAceptar.Name = "titleAceptar";
            this.titleAceptar.Size = new System.Drawing.Size(132, 50);
            this.titleAceptar.TabIndex = 25;
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 130);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 20);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Cantidad pagada:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 74);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 20);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Cantidad a pagar:";
            // 
            // cantidadPagada
            // 
            // 
            // 
            // 
            this.cantidadPagada.CustomButton.Image = null;
            this.cantidadPagada.CustomButton.Location = new System.Drawing.Point(156, 2);
            this.cantidadPagada.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantidadPagada.CustomButton.Name = "";
            this.cantidadPagada.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.cantidadPagada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cantidadPagada.CustomButton.TabIndex = 1;
            this.cantidadPagada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cantidadPagada.CustomButton.UseSelectable = true;
            this.cantidadPagada.CustomButton.Visible = false;
            this.cantidadPagada.Lines = new string[0];
            this.cantidadPagada.Location = new System.Drawing.Point(192, 130);
            this.cantidadPagada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantidadPagada.MaxLength = 12;
            this.cantidadPagada.Name = "cantidadPagada";
            this.cantidadPagada.PasswordChar = '\0';
            this.cantidadPagada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cantidadPagada.SelectedText = "";
            this.cantidadPagada.SelectionLength = 0;
            this.cantidadPagada.SelectionStart = 0;
            this.cantidadPagada.ShortcutsEnabled = true;
            this.cantidadPagada.Size = new System.Drawing.Size(143, 28);
            this.cantidadPagada.TabIndex = 22;
            this.cantidadPagada.UseSelectable = true;
            this.cantidadPagada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cantidadPagada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cantidadPagada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadPagada_KeyPress);
            // 
            // cantidadAPagar
            // 
            // 
            // 
            // 
            this.cantidadAPagar.CustomButton.Image = null;
            this.cantidadAPagar.CustomButton.Location = new System.Drawing.Point(156, 2);
            this.cantidadAPagar.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantidadAPagar.CustomButton.Name = "";
            this.cantidadAPagar.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.cantidadAPagar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cantidadAPagar.CustomButton.TabIndex = 1;
            this.cantidadAPagar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cantidadAPagar.CustomButton.UseSelectable = true;
            this.cantidadAPagar.CustomButton.Visible = false;
            this.cantidadAPagar.Lines = new string[0];
            this.cantidadAPagar.Location = new System.Drawing.Point(192, 74);
            this.cantidadAPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantidadAPagar.MaxLength = 12;
            this.cantidadAPagar.Name = "cantidadAPagar";
            this.cantidadAPagar.PasswordChar = '\0';
            this.cantidadAPagar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cantidadAPagar.SelectedText = "";
            this.cantidadAPagar.SelectionLength = 0;
            this.cantidadAPagar.SelectionStart = 0;
            this.cantidadAPagar.ShortcutsEnabled = true;
            this.cantidadAPagar.Size = new System.Drawing.Size(143, 28);
            this.cantidadAPagar.TabIndex = 21;
            this.cantidadAPagar.UseSelectable = true;
            this.cantidadAPagar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cantidadAPagar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cantidadAPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadAPagar_KeyPress);
            // 
            // ctacorriente
            // 
            this.ctacorriente.AutoSize = true;
            this.ctacorriente.Location = new System.Drawing.Point(142, 227);
            this.ctacorriente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctacorriente.Name = "ctacorriente";
            this.ctacorriente.Size = new System.Drawing.Size(104, 17);
            this.ctacorriente.TabIndex = 29;
            this.ctacorriente.Text = "Cta. Corriente";
            this.ctacorriente.UseSelectable = true;
            // 
            // Caja
            // 
            this.Caja.AutoSize = true;
            this.Caja.Location = new System.Drawing.Point(35, 227);
            this.Caja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Caja.Name = "Caja";
            this.Caja.Size = new System.Drawing.Size(49, 17);
            this.Caja.TabIndex = 28;
            this.Caja.Text = "Caja";
            this.Caja.UseSelectable = true;
            // 
            // Actualizar_PedidoDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 353);
            this.Controls.Add(this.ctacorriente);
            this.Controls.Add(this.Caja);
            this.Controls.Add(this.pagadoCheck);
            this.Controls.Add(this.titleCancelar);
            this.Controls.Add(this.titleAceptar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cantidadPagada);
            this.Controls.Add(this.cantidadAPagar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Actualizar_PedidoDeCompra";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Actualizar Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox pagadoCheck;
        private MetroFramework.Controls.MetroTile titleCancelar;
        private MetroFramework.Controls.MetroTile titleAceptar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox cantidadPagada;
        private MetroFramework.Controls.MetroTextBox cantidadAPagar;
        private MetroFramework.Controls.MetroRadioButton ctacorriente;
        private MetroFramework.Controls.MetroRadioButton Caja;
    }
}