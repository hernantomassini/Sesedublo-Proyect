namespace Sesedublo_SLPL
{
    partial class Pantalla_Principal
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
            this.GoToPedidos = new System.Windows.Forms.Button();
            this.GoToStock = new System.Windows.Forms.Button();
            this.GoToUsuarios = new System.Windows.Forms.Button();
            this.GoToHistorialFacturas = new System.Windows.Forms.Button();
            this.GoToHistorialOperaciones = new System.Windows.Forms.Button();
            this.GoToRevisarCaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoToPedidos
            // 
            this.GoToPedidos.Location = new System.Drawing.Point(91, 27);
            this.GoToPedidos.Name = "GoToPedidos";
            this.GoToPedidos.Size = new System.Drawing.Size(101, 42);
            this.GoToPedidos.TabIndex = 0;
            this.GoToPedidos.Text = "Administrar Pedidos";
            this.GoToPedidos.UseVisualStyleBackColor = true;
            this.GoToPedidos.Click += new System.EventHandler(this.GoToPedidos_Click);
            // 
            // GoToStock
            // 
            this.GoToStock.Location = new System.Drawing.Point(91, 75);
            this.GoToStock.Name = "GoToStock";
            this.GoToStock.Size = new System.Drawing.Size(101, 35);
            this.GoToStock.TabIndex = 1;
            this.GoToStock.Text = "Administrar Stock";
            this.GoToStock.UseVisualStyleBackColor = true;
            this.GoToStock.Click += new System.EventHandler(this.GoToStock_Click);
            // 
            // GoToUsuarios
            // 
            this.GoToUsuarios.Location = new System.Drawing.Point(91, 116);
            this.GoToUsuarios.Name = "GoToUsuarios";
            this.GoToUsuarios.Size = new System.Drawing.Size(101, 38);
            this.GoToUsuarios.TabIndex = 2;
            this.GoToUsuarios.Text = "Administrar Usuarios";
            this.GoToUsuarios.UseVisualStyleBackColor = true;
            this.GoToUsuarios.Click += new System.EventHandler(this.GoToUsuarios_Click);
            // 
            // GoToHistorialFacturas
            // 
            this.GoToHistorialFacturas.Location = new System.Drawing.Point(91, 160);
            this.GoToHistorialFacturas.Name = "GoToHistorialFacturas";
            this.GoToHistorialFacturas.Size = new System.Drawing.Size(101, 39);
            this.GoToHistorialFacturas.TabIndex = 3;
            this.GoToHistorialFacturas.Text = "Ver historial de facturas";
            this.GoToHistorialFacturas.UseVisualStyleBackColor = true;
            this.GoToHistorialFacturas.Click += new System.EventHandler(this.GoToHistorialFacturas_Click);
            // 
            // GoToHistorialOperaciones
            // 
            this.GoToHistorialOperaciones.Location = new System.Drawing.Point(91, 205);
            this.GoToHistorialOperaciones.Name = "GoToHistorialOperaciones";
            this.GoToHistorialOperaciones.Size = new System.Drawing.Size(101, 37);
            this.GoToHistorialOperaciones.TabIndex = 4;
            this.GoToHistorialOperaciones.Text = "Ver historial de operaciones";
            this.GoToHistorialOperaciones.UseVisualStyleBackColor = true;
            this.GoToHistorialOperaciones.Click += new System.EventHandler(this.GoToHistorialOperaciones_Click);
            // 
            // GoToRevisarCaja
            // 
            this.GoToRevisarCaja.Location = new System.Drawing.Point(91, 248);
            this.GoToRevisarCaja.Name = "GoToRevisarCaja";
            this.GoToRevisarCaja.Size = new System.Drawing.Size(101, 36);
            this.GoToRevisarCaja.TabIndex = 5;
            this.GoToRevisarCaja.Text = "Revisar caja";
            this.GoToRevisarCaja.UseVisualStyleBackColor = true;
            this.GoToRevisarCaja.Click += new System.EventHandler(this.GoToRevisarCaja_Click);
            // 
            // Pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 305);
            this.Controls.Add(this.GoToRevisarCaja);
            this.Controls.Add(this.GoToHistorialOperaciones);
            this.Controls.Add(this.GoToHistorialFacturas);
            this.Controls.Add(this.GoToUsuarios);
            this.Controls.Add(this.GoToStock);
            this.Controls.Add(this.GoToPedidos);
            this.Name = "Pantalla_Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Pantalla_Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoToPedidos;
        private System.Windows.Forms.Button GoToStock;
        private System.Windows.Forms.Button GoToUsuarios;
        private System.Windows.Forms.Button GoToHistorialFacturas;
        private System.Windows.Forms.Button GoToHistorialOperaciones;
        private System.Windows.Forms.Button GoToRevisarCaja;
    }
}

