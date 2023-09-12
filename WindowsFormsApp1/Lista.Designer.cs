namespace WindowsFormsApp1
{
    partial class Lista
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
            this.ListaD = new System.Windows.Forms.DataGridView();
            this.EliminarA = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ListaD)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaD
            // 
            this.ListaD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaD.Location = new System.Drawing.Point(173, 6);
            this.ListaD.Name = "ListaD";
            this.ListaD.Size = new System.Drawing.Size(582, 364);
            this.ListaD.TabIndex = 0;
            // 
            // EliminarA
            // 
            this.EliminarA.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EliminarA.IconColor = System.Drawing.Color.Black;
            this.EliminarA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarA.Location = new System.Drawing.Point(49, 152);
            this.EliminarA.Name = "EliminarA";
            this.EliminarA.Size = new System.Drawing.Size(75, 23);
            this.EliminarA.TabIndex = 3;
            this.EliminarA.Text = "Eliminar";
            this.EliminarA.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 377);
            this.Controls.Add(this.EliminarA);
            this.Controls.Add(this.ListaD);
            this.Name = "Lista";
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.ListaD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaD;
        private FontAwesome.Sharp.IconButton EliminarA;
    }
}