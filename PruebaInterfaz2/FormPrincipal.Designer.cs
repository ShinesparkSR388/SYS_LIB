﻿namespace PruebaInterfaz2
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubMenu2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnOrden = new FontAwesome.Sharp.IconButton();
            this.panelSubMenu1 = new System.Windows.Forms.Panel();
            this.btnListaLibros = new FontAwesome.Sharp.IconButton();
            this.btnCompraLibros = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelSubMenu2.SuspendLayout();
            this.panelSubMenu1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1382, 653);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelFormularios.Controls.Add(this.pictureBox5);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(240, 42);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1142, 611);
            this.panelFormularios.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(302, 58);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(500, 500);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.panelSubMenu2);
            this.panelMenu.Controls.Add(this.panelSubMenu1);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 42);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 611);
            this.panelMenu.TabIndex = 1;
            // 
            // panelSubMenu2
            // 
            this.panelSubMenu2.Controls.Add(this.iconButton1);
            this.panelSubMenu2.Controls.Add(this.iconButton3);
            this.panelSubMenu2.Controls.Add(this.btnOrden);
            this.panelSubMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu2.Location = new System.Drawing.Point(0, 291);
            this.panelSubMenu2.Name = "panelSubMenu2";
            this.panelSubMenu2.Size = new System.Drawing.Size(240, 214);
            this.panelSubMenu2.TabIndex = 11;
            this.panelSubMenu2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSubMenu2_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 106);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(240, 53);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.Text = "Proveedores";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 53);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(240, 53);
            this.iconButton3.TabIndex = 8;
            this.iconButton3.Text = "Registro de Productos";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click_2);
            // 
            // btnOrden
            // 
            this.btnOrden.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrden.FlatAppearance.BorderSize = 0;
            this.btnOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrden.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrden.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.btnOrden.IconColor = System.Drawing.Color.White;
            this.btnOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrden.Location = new System.Drawing.Point(0, 0);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(240, 53);
            this.btnOrden.TabIndex = 5;
            this.btnOrden.Text = "Ingresar Orden";
            this.btnOrden.UseVisualStyleBackColor = true;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // panelSubMenu1
            // 
            this.panelSubMenu1.Controls.Add(this.btnListaLibros);
            this.panelSubMenu1.Controls.Add(this.btnCompraLibros);
            this.panelSubMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu1.Location = new System.Drawing.Point(0, 185);
            this.panelSubMenu1.Name = "panelSubMenu1";
            this.panelSubMenu1.Size = new System.Drawing.Size(240, 106);
            this.panelSubMenu1.TabIndex = 9;
            // 
            // btnListaLibros
            // 
            this.btnListaLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaLibros.FlatAppearance.BorderSize = 0;
            this.btnListaLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaLibros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListaLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnListaLibros.IconColor = System.Drawing.Color.White;
            this.btnListaLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListaLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaLibros.Location = new System.Drawing.Point(0, 53);
            this.btnListaLibros.Name = "btnListaLibros";
            this.btnListaLibros.Size = new System.Drawing.Size(240, 53);
            this.btnListaLibros.TabIndex = 6;
            this.btnListaLibros.Text = "Libros";
            this.btnListaLibros.UseVisualStyleBackColor = true;
            this.btnListaLibros.Click += new System.EventHandler(this.btnListaLibros_Click);
            // 
            // btnCompraLibros
            // 
            this.btnCompraLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompraLibros.FlatAppearance.BorderSize = 0;
            this.btnCompraLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraLibros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCompraLibros.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnCompraLibros.IconColor = System.Drawing.Color.White;
            this.btnCompraLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompraLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompraLibros.Location = new System.Drawing.Point(0, 0);
            this.btnCompraLibros.Name = "btnCompraLibros";
            this.btnCompraLibros.Size = new System.Drawing.Size(240, 53);
            this.btnCompraLibros.TabIndex = 5;
            this.btnCompraLibros.Text = "Ventas";
            this.btnCompraLibros.UseVisualStyleBackColor = true;
            this.btnCompraLibros.Click += new System.EventHandler(this.btnCompraLibros_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 185);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(240, 185);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.DarkOrange;
            this.panelBarraTitulo.Controls.Add(this.pictureBox3);
            this.panelBarraTitulo.Controls.Add(this.pictureBox2);
            this.panelBarraTitulo.Controls.Add(this.pictureBox1);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1382, 42);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDoubleClick);
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1308, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1330, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1352, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.panelContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.panelContenedor.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenu2.ResumeLayout(false);
            this.panelSubMenu1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContenedor;
        private Panel panelBarraTitulo;
        private Panel panelMenu;
        private Panel panelFormularios;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Panel panelSubMenu1;
        private FontAwesome.Sharp.IconButton btnListaLibros;
        private FontAwesome.Sharp.IconButton btnCompraLibros;
        private Panel panelSubMenu2;
        private FontAwesome.Sharp.IconButton btnOrden;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}