namespace practica_feria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alumno_bt = new System.Windows.Forms.Button();
            this.docente_bt = new System.Windows.Forms.Button();
            this.aula_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 149);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // alumno_bt
            // 
            this.alumno_bt.Location = new System.Drawing.Point(12, 226);
            this.alumno_bt.Name = "alumno_bt";
            this.alumno_bt.Size = new System.Drawing.Size(75, 23);
            this.alumno_bt.TabIndex = 1;
            this.alumno_bt.Text = "Alumno";
            this.alumno_bt.UseVisualStyleBackColor = true;
            this.alumno_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // docente_bt
            // 
            this.docente_bt.Location = new System.Drawing.Point(107, 226);
            this.docente_bt.Name = "docente_bt";
            this.docente_bt.Size = new System.Drawing.Size(75, 23);
            this.docente_bt.TabIndex = 2;
            this.docente_bt.Text = "Docente";
            this.docente_bt.UseVisualStyleBackColor = true;
            this.docente_bt.Click += new System.EventHandler(this.docente_bt_Click);
            // 
            // aula_bt
            // 
            this.aula_bt.Location = new System.Drawing.Point(197, 226);
            this.aula_bt.Name = "aula_bt";
            this.aula_bt.Size = new System.Drawing.Size(75, 23);
            this.aula_bt.TabIndex = 3;
            this.aula_bt.Text = "Curso";
            this.aula_bt.UseVisualStyleBackColor = true;
            this.aula_bt.Click += new System.EventHandler(this.aula_bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.aula_bt);
            this.Controls.Add(this.docente_bt);
            this.Controls.Add(this.alumno_bt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button alumno_bt;
        private System.Windows.Forms.Button docente_bt;
        private System.Windows.Forms.Button aula_bt;
    }
}

