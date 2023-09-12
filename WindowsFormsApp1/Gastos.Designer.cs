namespace WindowsFormsApp1
{
    partial class formgastos
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DatosPersonales = new System.Windows.Forms.Panel();
            this.Atras = new FontAwesome.Sharp.IconButton();
            this.Monto2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Nombre2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Consultar2 = new FontAwesome.Sharp.IconButton();
            this.tslRegistrar2 = new FontAwesome.Sharp.IconButton();
            this.Elimininar2 = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.totalEnviado = new System.Windows.Forms.TextBox();
            this.ListaD2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gastoTotal = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.DatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.DatosPersonales.Controls.Add(this.Atras);
            this.DatosPersonales.Controls.Add(this.Monto2);
            this.DatosPersonales.Controls.Add(this.label5);
            this.DatosPersonales.Controls.Add(this.Nombre2);
            this.DatosPersonales.Controls.Add(this.label3);
            this.DatosPersonales.Controls.Add(this.Consultar2);
            this.DatosPersonales.Controls.Add(this.tslRegistrar2);
            this.DatosPersonales.Controls.Add(this.Elimininar2);
            this.DatosPersonales.Dock = System.Windows.Forms.DockStyle.Left;
            this.DatosPersonales.Location = new System.Drawing.Point(0, 0);
            this.DatosPersonales.Name = "DatosPersonales";
            this.DatosPersonales.Size = new System.Drawing.Size(291, 450);
            this.DatosPersonales.TabIndex = 42;
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.Color.Transparent;
            this.Atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras.ForeColor = System.Drawing.Color.White;
            this.Atras.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            this.Atras.IconColor = System.Drawing.Color.White;
            this.Atras.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Atras.IconSize = 30;
            this.Atras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Atras.Location = new System.Drawing.Point(7, 409);
            this.Atras.Name = "Atras";
            this.Atras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Atras.Size = new System.Drawing.Size(79, 33);
            this.Atras.TabIndex = 49;
            this.Atras.Text = "Atras";
            this.Atras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Monto2
            // 
            this.Monto2.Location = new System.Drawing.Point(134, 163);
            this.Monto2.Name = "Monto2";
            this.Monto2.Size = new System.Drawing.Size(125, 20);
            this.Monto2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "MONTO:";
            // 
            // Nombre2
            // 
            this.Nombre2.Location = new System.Drawing.Point(134, 113);
            this.Nombre2.Name = "Nombre2";
            this.Nombre2.Size = new System.Drawing.Size(125, 20);
            this.Nombre2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "PRODUCTO:";
            // 
            // Consultar2
            // 
            this.Consultar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.Consultar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Consultar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Consultar2.ForeColor = System.Drawing.Color.White;
            this.Consultar2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.Consultar2.IconColor = System.Drawing.Color.Black;
            this.Consultar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Consultar2.IconSize = 35;
            this.Consultar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultar2.Location = new System.Drawing.Point(80, 211);
            this.Consultar2.Name = "Consultar2";
            this.Consultar2.Size = new System.Drawing.Size(124, 32);
            this.Consultar2.TabIndex = 17;
            this.Consultar2.Text = "Consultar";
            this.Consultar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultar2.UseVisualStyleBackColor = false;
            this.Consultar2.Click += new System.EventHandler(this.Consultar2_Click_1);
            // 
            // tslRegistrar2
            // 
            this.tslRegistrar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.tslRegistrar2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.tslRegistrar2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.tslRegistrar2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.tslRegistrar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tslRegistrar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslRegistrar2.ForeColor = System.Drawing.Color.White;
            this.tslRegistrar2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.tslRegistrar2.IconColor = System.Drawing.SystemColors.ControlText;
            this.tslRegistrar2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.tslRegistrar2.IconSize = 35;
            this.tslRegistrar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tslRegistrar2.Location = new System.Drawing.Point(80, 249);
            this.tslRegistrar2.Name = "tslRegistrar2";
            this.tslRegistrar2.Size = new System.Drawing.Size(124, 32);
            this.tslRegistrar2.TabIndex = 0;
            this.tslRegistrar2.Text = "Registrar";
            this.tslRegistrar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tslRegistrar2.UseVisualStyleBackColor = false;
            this.tslRegistrar2.Click += new System.EventHandler(this.tslRegistrar2_Click);
            // 
            // Elimininar2
            // 
            this.Elimininar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.Elimininar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Elimininar2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Elimininar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Elimininar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Elimininar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Elimininar2.ForeColor = System.Drawing.Color.White;
            this.Elimininar2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.Elimininar2.IconColor = System.Drawing.Color.Black;
            this.Elimininar2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Elimininar2.IconSize = 32;
            this.Elimininar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Elimininar2.Location = new System.Drawing.Point(80, 287);
            this.Elimininar2.Name = "Elimininar2";
            this.Elimininar2.Size = new System.Drawing.Size(124, 32);
            this.Elimininar2.TabIndex = 2;
            this.Elimininar2.Text = "Eliminar";
            this.Elimininar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Elimininar2.UseVisualStyleBackColor = false;
            this.Elimininar2.Click += new System.EventHandler(this.Elimininar2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(386, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "TOTAL:";
            // 
            // totalEnviado
            // 
            this.totalEnviado.Location = new System.Drawing.Point(481, 28);
            this.totalEnviado.Name = "totalEnviado";
            this.totalEnviado.Size = new System.Drawing.Size(100, 20);
            this.totalEnviado.TabIndex = 44;
            // 
            // ListaD2
            // 
            this.ListaD2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.ListaD2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaD2.Location = new System.Drawing.Point(329, 95);
            this.ListaD2.Name = "ListaD2";
            this.ListaD2.Size = new System.Drawing.Size(444, 343);
            this.ListaD2.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Presupuesto Inicial:";
            // 
            // gastoTotal
            // 
            this.gastoTotal.Location = new System.Drawing.Point(481, 54);
            this.gastoTotal.Name = "gastoTotal";
            this.gastoTotal.Size = new System.Drawing.Size(100, 20);
            this.gastoTotal.TabIndex = 47;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(775, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // formgastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gastoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatosPersonales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ListaD2);
            this.Controls.Add(this.totalEnviado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formgastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.DatosPersonales.ResumeLayout(false);
            this.DatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel DatosPersonales;
        private FontAwesome.Sharp.IconButton Consultar2;
        private FontAwesome.Sharp.IconButton tslRegistrar2;
        private FontAwesome.Sharp.IconButton Elimininar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ListaD2;
        private System.Windows.Forms.TextBox Monto2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nombre2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox totalEnviado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gastoTotal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton Atras;
    }
}