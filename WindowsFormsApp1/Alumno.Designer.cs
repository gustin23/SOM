
namespace WindowsFormsApp1
{
    partial class Alumno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumno));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Monto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DatosPersonales = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Turno = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Curso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Atras = new FontAwesome.Sharp.IconButton();
            this.btnenviar = new System.Windows.Forms.Button();
            this.Consultar = new FontAwesome.Sharp.IconButton();
            this.tslRegistrar = new FontAwesome.Sharp.IconButton();
            this.Elimininar = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ListaD = new System.Windows.Forms.DataGridView();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaD)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(525, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Informacion Economica:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Informacion Personal:";
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(606, 89);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(125, 20);
            this.Monto.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(524, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "MONTO:";
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.DatosPersonales.Controls.Add(this.pictureBox2);
            this.DatosPersonales.Controls.Add(this.label9);
            this.DatosPersonales.Controls.Add(this.Turno);
            this.DatosPersonales.Controls.Add(this.label8);
            this.DatosPersonales.Controls.Add(this.label7);
            this.DatosPersonales.Controls.Add(this.Curso);
            this.DatosPersonales.Controls.Add(this.label4);
            this.DatosPersonales.Controls.Add(this.label1);
            this.DatosPersonales.Controls.Add(this.label3);
            this.DatosPersonales.Controls.Add(this.Atras);
            this.DatosPersonales.Controls.Add(this.Nombre);
            this.DatosPersonales.Controls.Add(this.Apellido);
            this.DatosPersonales.Controls.Add(this.label2);
            this.DatosPersonales.Controls.Add(this.Monto);
            this.DatosPersonales.Controls.Add(this.label5);
            this.DatosPersonales.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatosPersonales.Location = new System.Drawing.Point(0, 0);
            this.DatosPersonales.Name = "DatosPersonales";
            this.DatosPersonales.Size = new System.Drawing.Size(784, 172);
            this.DatosPersonales.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(739, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(270, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "CURSO:";
            // 
            // Turno
            // 
            this.Turno.FormattingEnabled = true;
            this.Turno.Items.AddRange(new object[] {
            "",
            "Mañana",
            "Tarde",
            "Noche"});
            this.Turno.Location = new System.Drawing.Point(349, 117);
            this.Turno.Name = "Turno";
            this.Turno.Size = new System.Drawing.Size(125, 21);
            this.Turno.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(270, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "TURNO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(270, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 22;
            // 
            // Curso
            // 
            this.Curso.Location = new System.Drawing.Point(349, 87);
            this.Curso.Name = "Curso";
            this.Curso.Size = new System.Drawing.Size(125, 20);
            this.Curso.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "APELLIDO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "NOMBRE:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(128, 87);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(125, 20);
            this.Nombre.TabIndex = 3;
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(128, 118);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(125, 20);
            this.Apellido.TabIndex = 4;
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
            this.Atras.Location = new System.Drawing.Point(3, 0);
            this.Atras.Name = "Atras";
            this.Atras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Atras.Size = new System.Drawing.Size(79, 33);
            this.Atras.TabIndex = 16;
            this.Atras.Text = "Atras";
            this.Atras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.btnenviar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnenviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnenviar.ForeColor = System.Drawing.Color.White;
            this.btnenviar.Location = new System.Drawing.Point(635, 368);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(124, 32);
            this.btnenviar.TabIndex = 42;
            this.btnenviar.Text = "ENVIAR";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Consultar.ForeColor = System.Drawing.Color.White;
            this.Consultar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.Consultar.IconColor = System.Drawing.Color.Black;
            this.Consultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Consultar.IconSize = 35;
            this.Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultar.Location = new System.Drawing.Point(635, 207);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(124, 32);
            this.Consultar.TabIndex = 17;
            this.Consultar.Text = "Buscar";
            this.Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // tslRegistrar
            // 
            this.tslRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.tslRegistrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.tslRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.tslRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.tslRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tslRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslRegistrar.ForeColor = System.Drawing.Color.White;
            this.tslRegistrar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.tslRegistrar.IconColor = System.Drawing.SystemColors.ControlText;
            this.tslRegistrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.tslRegistrar.IconSize = 35;
            this.tslRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tslRegistrar.Location = new System.Drawing.Point(635, 245);
            this.tslRegistrar.Name = "tslRegistrar";
            this.tslRegistrar.Size = new System.Drawing.Size(124, 32);
            this.tslRegistrar.TabIndex = 0;
            this.tslRegistrar.Text = "Registrar";
            this.tslRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tslRegistrar.UseVisualStyleBackColor = false;
            this.tslRegistrar.Click += new System.EventHandler(this.tslRegistrar_Click);
            // 
            // Elimininar
            // 
            this.Elimininar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.Elimininar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Elimininar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Elimininar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Elimininar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Elimininar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Elimininar.ForeColor = System.Drawing.Color.White;
            this.Elimininar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.Elimininar.IconColor = System.Drawing.Color.Black;
            this.Elimininar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Elimininar.IconSize = 32;
            this.Elimininar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Elimininar.Location = new System.Drawing.Point(635, 281);
            this.Elimininar.Name = "Elimininar";
            this.Elimininar.Size = new System.Drawing.Size(124, 32);
            this.Elimininar.TabIndex = 2;
            this.Elimininar.Text = "Eliminar";
            this.Elimininar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Elimininar.UseVisualStyleBackColor = false;
            this.Elimininar.Click += new System.EventHandler(this.Elimininar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ListaD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ListaD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListaD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.ListaD.Location = new System.Drawing.Point(42, 187);
            this.ListaD.Name = "ListaD";
            this.ListaD.Size = new System.Drawing.Size(552, 182);
            this.ListaD.TabIndex = 17;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(665, 377);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 31);
            this.lbltotal.TabIndex = 39;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(494, 371);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(419, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "TOTAL:";
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.ListaD);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.tslRegistrar);
            this.Controls.Add(this.Elimininar);
            this.Controls.Add(this.DatosPersonales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.DatosPersonales.ResumeLayout(false);
            this.DatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel DatosPersonales;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton Atras;
        private FontAwesome.Sharp.IconButton Elimininar;
        private FontAwesome.Sharp.IconButton tslRegistrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView ListaD;
        private FontAwesome.Sharp.IconButton Consultar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.ComboBox Turno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Curso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}