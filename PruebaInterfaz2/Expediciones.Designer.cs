namespace PruebaInterfaz2
{
    partial class Expediciones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expediciones));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError1 = new System.Windows.Forms.Label();
            this.lblError2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.txtPaquetes = new System.Windows.Forms.TextBox();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.icBuscar = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.DT_Productos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrabar = new FontAwesome.Sharp.IconButton();
            this.btnQuitar = new FontAwesome.Sharp.IconButton();
            this.DT_Ventas = new System.Windows.Forms.DataGridView();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_Productos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.tableLayoutPanel1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1102, 600);
            this.panelContenedor.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1102, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblError1);
            this.panel1.Controls.Add(this.lblError2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtUnidades);
            this.panel1.Controls.Add(this.txtPaquetes);
            this.panel1.Controls.Add(this.txtLibro);
            this.panel1.Controls.Add(this.icBuscar);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.DT_Productos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 294);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.Location = new System.Drawing.Point(1027, 163);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(0, 20);
            this.lblError1.TabIndex = 74;
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.Location = new System.Drawing.Point(1027, 212);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(0, 20);
            this.lblError2.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(100, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 23);
            this.label2.TabIndex = 73;
            this.label2.Text = "Productos en Stock";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardar.Location = new System.Drawing.Point(710, 59);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(311, 43);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Selección";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(710, 283);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(311, 2);
            this.panel5.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(710, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 2);
            this.panel3.TabIndex = 56;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(710, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 2);
            this.panel4.TabIndex = 56;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(710, 138);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(311, 2);
            this.panel6.TabIndex = 56;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.Location = new System.Drawing.Point(710, 257);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PlaceholderText = "Total";
            this.txtTotal.Size = new System.Drawing.Size(311, 25);
            this.txtTotal.TabIndex = 55;
            // 
            // txtUnidades
            // 
            this.txtUnidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtUnidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnidades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnidades.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUnidades.Location = new System.Drawing.Point(710, 160);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.PlaceholderText = "Unidades";
            this.txtUnidades.Size = new System.Drawing.Size(311, 25);
            this.txtUnidades.TabIndex = 55;
            this.txtUnidades.TextChanged += new System.EventHandler(this.txtUnidades_TextChanged);
            // 
            // txtPaquetes
            // 
            this.txtPaquetes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaquetes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPaquetes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaquetes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPaquetes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPaquetes.Location = new System.Drawing.Point(710, 209);
            this.txtPaquetes.Name = "txtPaquetes";
            this.txtPaquetes.PlaceholderText = "Paquetes";
            this.txtPaquetes.Size = new System.Drawing.Size(311, 25);
            this.txtPaquetes.TabIndex = 55;
            this.txtPaquetes.TextChanged += new System.EventHandler(this.txtPaquetes_TextChanged);
            // 
            // txtLibro
            // 
            this.txtLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtLibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLibro.Enabled = false;
            this.txtLibro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLibro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLibro.Location = new System.Drawing.Point(710, 112);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.PlaceholderText = "Libro";
            this.txtLibro.Size = new System.Drawing.Size(311, 25);
            this.txtLibro.TabIndex = 55;
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
            this.icBuscar.Location = new System.Drawing.Point(661, 27);
            this.icBuscar.Name = "icBuscar";
            this.icBuscar.Size = new System.Drawing.Size(30, 28);
            this.icBuscar.TabIndex = 53;
            this.icBuscar.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(344, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(311, 2);
            this.panel7.TabIndex = 52;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.Location = new System.Drawing.Point(344, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Buscar por Nombre";
            this.txtBuscar.Size = new System.Drawing.Size(311, 25);
            this.txtBuscar.TabIndex = 51;
            // 
            // DT_Productos
            // 
            this.DT_Productos.AllowUserToAddRows = false;
            this.DT_Productos.AllowUserToDeleteRows = false;
            this.DT_Productos.AllowUserToResizeColumns = false;
            this.DT_Productos.AllowUserToResizeRows = false;
            this.DT_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DT_Productos.Location = new System.Drawing.Point(100, 61);
            this.DT_Productos.Name = "DT_Productos";
            this.DT_Productos.RowHeadersWidth = 65;
            this.DT_Productos.RowTemplate.Height = 29;
            this.DT_Productos.Size = new System.Drawing.Size(591, 220);
            this.DT_Productos.TabIndex = 8;
            this.DT_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DT_Productos_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnGrabar);
            this.panel2.Controls.Add(this.btnQuitar);
            this.panel2.Controls.Add(this.DT_Ventas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 294);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(100, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "Productos Añadidos";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.Enabled = false;
            this.btnGrabar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGrabar.FlatAppearance.BorderSize = 2;
            this.btnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnGrabar.IconColor = System.Drawing.Color.White;
            this.btnGrabar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGrabar.IconSize = 30;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGrabar.Location = new System.Drawing.Point(710, 94);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(311, 43);
            this.btnGrabar.TabIndex = 64;
            this.btnGrabar.Text = "Finalizar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.Enabled = false;
            this.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuitar.FlatAppearance.BorderSize = 2;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnQuitar.IconColor = System.Drawing.Color.White;
            this.btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuitar.IconSize = 30;
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnQuitar.Location = new System.Drawing.Point(710, 38);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(311, 43);
            this.btnQuitar.TabIndex = 63;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // DT_Ventas
            // 
            this.DT_Ventas.AllowUserToAddRows = false;
            this.DT_Ventas.AllowUserToDeleteRows = false;
            this.DT_Ventas.AllowUserToResizeColumns = false;
            this.DT_Ventas.AllowUserToResizeRows = false;
            this.DT_Ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DT_Ventas.Location = new System.Drawing.Point(100, 38);
            this.DT_Ventas.Name = "DT_Ventas";
            this.DT_Ventas.RowHeadersWidth = 51;
            this.DT_Ventas.RowTemplate.Height = 29;
            this.DT_Ventas.Size = new System.Drawing.Size(591, 235);
            this.DT_Ventas.TabIndex = 10;
            this.DT_Ventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DT_Ventas_CellClick);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            this.error1.Icon = ((System.Drawing.Icon)(resources.GetObject("error1.Icon")));
            // 
            // error2
            // 
            this.error2.ContainerControl = this;
            this.error2.Icon = ((System.Drawing.Icon)(resources.GetObject("error2.Icon")));
            // 
            // Expediciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 600);
            this.Controls.Add(this.panelContenedor);
            this.Name = "Expediciones";
            this.Text = "Expediciones";
            this.panelContenedor.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_Productos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContenedor;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView DT_Productos;
        private DataGridView DT_Ventas;
        private FontAwesome.Sharp.IconButton icBuscar;
        private Panel panel7;
        private TextBox txtBuscar;
        private Panel panel5;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private TextBox txtTotal;
        private TextBox txtUnidades;
        private TextBox txtPaquetes;
        private TextBox txtLibro;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnGrabar;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private Label label2;
        private Label label1;
        private Label lblError1;
        private Label lblError2;
        private ErrorProvider error1;
        private ErrorProvider error2;
    }
}