namespace PruebaInterfaz2
{
    partial class LibrosActuales
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.icBuscar = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.DT_Libros = new System.Windows.Forms.DataGridView();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_Libros)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelContenedor.Controls.Add(this.icBuscar);
            this.panelContenedor.Controls.Add(this.panel6);
            this.panelContenedor.Controls.Add(this.txt_Nombre);
            this.panelContenedor.Controls.Add(this.DT_Libros);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1102, 603);
            this.panelContenedor.TabIndex = 0;
            // 
            // icBuscar
            // 
            this.icBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.icBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icBuscar.FlatAppearance.BorderSize = 0;
            this.icBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.icBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.icBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.icBuscar.IconColor = System.Drawing.Color.White;
            this.icBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBuscar.IconSize = 30;
            this.icBuscar.Location = new System.Drawing.Point(868, 84);
            this.icBuscar.Name = "icBuscar";
            this.icBuscar.Size = new System.Drawing.Size(64, 44);
            this.icBuscar.TabIndex = 57;
            this.icBuscar.UseVisualStyleBackColor = true;
            this.icBuscar.Click += new System.EventHandler(this.icBuscar_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(551, 119);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(311, 2);
            this.panel6.TabIndex = 56;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Nombre.Location = new System.Drawing.Point(551, 93);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Buscar por nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(311, 25);
            this.txt_Nombre.TabIndex = 55;
            // 
            // DT_Libros
            // 
            this.DT_Libros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_Libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DT_Libros.Location = new System.Drawing.Point(113, 128);
            this.DT_Libros.Name = "DT_Libros";
            this.DT_Libros.RowHeadersWidth = 51;
            this.DT_Libros.RowTemplate.Height = 29;
            this.DT_Libros.Size = new System.Drawing.Size(843, 373);
            this.DT_Libros.TabIndex = 3;
            // 
            // LibrosActuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 603);
            this.Controls.Add(this.panelContenedor);
            this.Name = "LibrosActuales";
            this.Text = "LibrosActuales";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_Libros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContenedor;
        private DataGridView DT_Libros;
        private Panel panel6;
        private TextBox txt_Nombre;
        private FontAwesome.Sharp.IconButton icBuscar;
    }
}