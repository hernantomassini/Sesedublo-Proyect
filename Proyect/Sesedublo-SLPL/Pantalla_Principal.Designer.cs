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
            this.GoToPedidos.Location = new System.Drawing.Point(130, 78);
            this.GoToPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoToPedidos.Name = "GoToPedidos";
            this.GoToPedidos.Size = new System.Drawing.Size(135, 52);
            this.GoToPedidos.TabIndex = 0;
            this.GoToPedidos.Text = "Administrar Pedidos";
            this.GoToPedidos.UseVisualStyleBackColor = true;
            this.GoToPedidos.Click += new System.EventHandler(this.GoToPedidos_Click);
            // 
            // GoToStock
            // 
            this.GoToStock.Location = new System.Drawing.Point(130, 137);
            this.GoToStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoToStock.Name = "GoToStock";
            this.GoToStock.Size = new System.Drawing.Size(135, 43);
            this.GoToStock.TabIndex = 1;
            this.GoToStock.Text = "Administrar Stock";
            this.GoToStock.UseVisualStyleBackColor = true;
            this.GoToStock.Click += new System.EventHandler(this.GoToStock_Click);
            // 
            // GoToUsuarios
            // 
            this.GoToUsuarios.Location = new System.Drawing.Point(130, 188);
            this.GoToUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoToUsuarios.Name = "GoToUsuarios";
            this.GoToUsuarios.Size = new System.Drawing.Size(135, 47);
            this.GoToUsuarios.TabIndex = 2;
            this.GoToUsuarios.Text = "Administrar Usuarios";
            this.GoToUsuarios.UseVisualStyleBackColor = true;
            this.GoToUsuarios.Click += new System.EventHandler(this.GoToUsuarios_Click);
            // 
            // GoToHistorialFacturas
            // 
            this.GoToHistorialFacturas.Location = new System.Drawing.Point(130, 242);
            this.GoToHistorialFacturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoToHistorialFacturas.Name = "GoToHistorialFacturas";
            this.GoToHistorialFacturas.Size = new System.Drawing.Size(135, 48);
            this.GoToHistorialFacturas.TabIndex = 3;
            this.GoToHistorialFacturas.Text = "Ver historial de facturas";
            this.GoToHistorialFacturas.UseVisualStyleBackColor = true;
            this.GoToHistorialFacturas.Click += new System.EventHandler(this.GoToHistorialFacturas_Click);
            // 
            // GoToHistorialOperaciones
            // 
            this.GoToHistorialOperaciones.Location = new System.Drawing.Point(130, 297);
            this.GoToHistorialOperaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoToHistorialOperaciones.Name = "GoToHistorialOperaciones";
            this.GoToHistorialOperaciones.Size = new System.Drawing.Size(135, 46);
            this.GoToHistorialOperaciones.TabIndex = 4;
            this.GoToHistorialOperaciones.Text = "Ver historial de operaciones";
            this.GoToHistorialOperaciones.UseVisualStyleBackColor = true;
            this.GoToHistorialOperaciones.Click += new System.EventHandler(this.GoToHistorialOperaciones_Click);
            // 
            // GoToRevisarCaja
            // 
            this.GoToRevisarCaja.Location = new System.Drawing.Point(130, 350);
            this.GoToRevisarCaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoToRevisarCaja.Name = "GoToRevisarCaja";
            this.GoToRevisarCaja.Size = new System.Drawing.Size(135, 44);
            this.GoToRevisarCaja.TabIndex = 5;
            this.GoToRevisarCaja.Text = "Revisar caja";
            this.GoToRevisarCaja.UseVisualStyleBackColor = true;
            this.GoToRevisarCaja.Click += new System.EventHandler(this.GoToRevisarCaja_Click);
            // 
            // Pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 484);
            this.Controls.Add(this.GoToRevisarCaja);
            this.Controls.Add(this.GoToHistorialOperaciones);
            this.Controls.Add(this.GoToHistorialFacturas);
            this.Controls.Add(this.GoToUsuarios);
            this.Controls.Add(this.GoToStock);
            this.Controls.Add(this.GoToPedidos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pantalla_Principal";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Menú Principal";
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

