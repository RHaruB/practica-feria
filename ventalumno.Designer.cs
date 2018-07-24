namespace practica_feria
{
    partial class ventalumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventalumno));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_ci_alumno = new System.Windows.Forms.TextBox();
            this.comboBox_opciones = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_profesor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_horario = new System.Windows.Forms.TextBox();
            this.textBox_curso = new System.Windows.Forms.TextBox();
            this.textBox_Nombre_alumno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 149);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox_ci_alumno
            // 
            this.textBox_ci_alumno.Location = new System.Drawing.Point(150, 184);
            this.textBox_ci_alumno.Name = "textBox_ci_alumno";
            this.textBox_ci_alumno.Size = new System.Drawing.Size(100, 20);
            this.textBox_ci_alumno.TabIndex = 2;
            // 
            // comboBox_opciones
            // 
            this.comboBox_opciones.FormattingEnabled = true;
            this.comboBox_opciones.Items.AddRange(new object[] {
            "Total",
            "Actual",
            "Siguiente"});
            this.comboBox_opciones.Location = new System.Drawing.Point(320, 183);
            this.comboBox_opciones.Name = "comboBox_opciones";
            this.comboBox_opciones.Size = new System.Drawing.Size(121, 21);
            this.comboBox_opciones.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.textBox_profesor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_horario);
            this.groupBox1.Controls.Add(this.textBox_curso);
            this.groupBox1.Controls.Add(this.textBox_Nombre_alumno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(350, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 138);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_profesor
            // 
            this.textBox_profesor.Location = new System.Drawing.Point(128, 88);
            this.textBox_profesor.Name = "textBox_profesor";
            this.textBox_profesor.Size = new System.Drawing.Size(100, 20);
            this.textBox_profesor.TabIndex = 7;
            this.textBox_profesor.TextChanged += new System.EventHandler(this.textBox_profesor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Profesor";
            // 
            // textBox_horario
            // 
            this.textBox_horario.Location = new System.Drawing.Point(128, 67);
            this.textBox_horario.Name = "textBox_horario";
            this.textBox_horario.Size = new System.Drawing.Size(100, 20);
            this.textBox_horario.TabIndex = 5;
            // 
            // textBox_curso
            // 
            this.textBox_curso.Location = new System.Drawing.Point(128, 46);
            this.textBox_curso.Name = "textBox_curso";
            this.textBox_curso.Size = new System.Drawing.Size(100, 20);
            this.textBox_curso.TabIndex = 4;
            // 
            // textBox_Nombre_alumno
            // 
            this.textBox_Nombre_alumno.Location = new System.Drawing.Point(128, 25);
            this.textBox_Nombre_alumno.Name = "textBox_Nombre_alumno";
            this.textBox_Nombre_alumno.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nombre_alumno.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ventalumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_opciones);
            this.Controls.Add(this.textBox_ci_alumno);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ventalumno";
            this.Text = "ventalumno";
            this.Load += new System.EventHandler(this.ventalumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_ci_alumno;
        private System.Windows.Forms.ComboBox comboBox_opciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_profesor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_horario;
        private System.Windows.Forms.TextBox textBox_curso;
        private System.Windows.Forms.TextBox textBox_Nombre_alumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}