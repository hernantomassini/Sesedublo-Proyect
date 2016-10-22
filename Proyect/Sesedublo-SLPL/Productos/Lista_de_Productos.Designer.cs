namespace Sesedublo_SLPL.Productos
{
    partial class Lista_de_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_de_Productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nombre = new MetroFramework.Controls.MetroTextBox();
            this.nombreLabel = new MetroFramework.Controls.MetroLabel();
            this.titleAtras = new MetroFramework.Controls.MetroTile();
            this.titleAgregarProducto = new MetroFramework.Controls.MetroTile();
            this.dgvProductos = new MetroFramework.Controls.MetroGrid();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            // 
            // 
            // 
            this.nombre.CustomButton.Image = null;
            this.nombre.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.nombre.CustomButton.Name = "";
            this.nombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nombre.CustomButton.TabIndex = 1;
            this.nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nombre.CustomButton.UseSelectable = true;
            this.nombre.CustomButton.Visible = false;
            this.nombre.DisplayIcon = true;
            this.nombre.Icon = ((System.Drawing.Image)(resources.GetObject("nombre.Icon")));
            this.nombre.Lines = new string[0];
            this.nombre.Location = new System.Drawing.Point(91, 60);
            this.nombre.MaxLength = 70;
            this.nombre.Name = "nombre";
            this.nombre.PasswordChar = '\0';
            this.nombre.PromptText = "Buscar";
            this.nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombre.SelectedText = "";
            this.nombre.SelectionLength = 0;
            this.nombre.SelectionStart = 0;
            this.nombre.ShortcutsEnabled = true;
            this.nombre.Size = new System.Drawing.Size(114, 23);
            this.nombre.TabIndex = 12;
            this.nombre.UseSelectable = true;
            this.nombre.WaterMark = "Buscar";
            this.nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(23, 60);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(62, 19);
            this.nombreLabel.TabIndex = 16;
            this.nombreLabel.Text = "Nombre:";
            // 
            // titleAtras
            // 
            this.titleAtras.ActiveControl = null;
            this.titleAtras.BackColor = System.Drawing.Color.CadetBlue;
            this.titleAtras.Location = new System.Drawing.Point(24, 346);
            this.titleAtras.Name = "titleAtras";
            this.titleAtras.Size = new System.Drawing.Size(75, 44);
            this.titleAtras.TabIndex = 14;
            this.titleAtras.Text = "Atrás";
            this.titleAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleAtras.TileImage = ((System.Drawing.Image)(resources.GetObject("titleAtras.TileImage")));
            this.titleAtras.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleAtras.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleAtras.UseCustomBackColor = true;
            this.titleAtras.UseSelectable = true;
            this.titleAtras.UseTileImage = true;
            this.titleAtras.Click += new System.EventHandler(this.titleAtras_Click);
            // 
            // titleAgregarProducto
            // 
            this.titleAgregarProducto.ActiveControl = null;
            this.titleAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.titleAgregarProducto.Location = new System.Drawing.Point(572, 346);
            this.titleAgregarProducto.Name = "titleAgregarProducto";
            this.titleAgregarProducto.Size = new System.Drawing.Size(155, 44);
            this.titleAgregarProducto.TabIndex = 13;
            this.titleAgregarProducto.Text = "Agregar Producto";
            this.titleAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleAgregarProducto.TileImage = ((System.Drawing.Image)(resources.GetObject("titleAgregarProducto.TileImage")));
            this.titleAgregarProducto.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleAgregarProducto.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.titleAgregarProducto.UseCustomBackColor = true;
            this.titleAgregarProducto.UseSelectable = true;
            this.titleAgregarProducto.UseTileImage = true;
            this.titleAgregarProducto.Click += new System.EventHandler(this.titleAgregarCliente_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProductos.Location = new System.Drawing.Point(23, 92);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(704, 248);
            this.dgvProductos.TabIndex = 15;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.Silver;
            this.metroTile1.Location = new System.Drawing.Point(439, 346);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(127, 44);
            this.metroTile1.TabIndex = 17;
            this.metroTile1.Text = "PDF";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Lista_de_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 432);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.titleAtras);
            this.Controls.Add(this.titleAgregarProducto);
            this.Controls.Add(this.dgvProductos);
            this.MaximizeBox = false;
            this.Name = "Lista_de_Productos";
            this.Text = "Lista de Productos";
            this.Load += new System.EventHandler(this.Lista_de_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox nombre;
        private MetroFramework.Controls.MetroLabel nombreLabel;
        private MetroFramework.Controls.MetroTile titleAtras;
        private MetroFramework.Controls.MetroTile titleAgregarProducto;
        private MetroFramework.Controls.MetroGrid dgvProductos;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}