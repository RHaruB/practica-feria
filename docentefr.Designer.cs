namespace practica_feria
{
    partial class docentefr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(docentefr));
            this.textBox_docente = new System.Windows.Forms.TextBox();
            this.comboBox_docente = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_horario_docente = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_horario_docente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_docente
            // 
            this.textBox_docente.Location = new System.Drawing.Point(202, 163);
            this.textBox_docente.Name = "textBox_docente";
            this.textBox_docente.Size = new System.Drawing.Size(100, 20);
            this.textBox_docente.TabIndex = 0;
            // 
            // comboBox_docente
            // 
            this.comboBox_docente.FormattingEnabled = true;
            this.comboBox_docente.Items.AddRange(new object[] {
            "Todos",
            "Actual",
            "Siguiente"});
            this.comboBox_docente.Location = new System.Drawing.Point(332, 163);
            this.comboBox_docente.Name = "comboBox_docente";
            this.comboBox_docente.Size = new System.Drawing.Size(121, 21);
            this.comboBox_docente.TabIndex = 1;
            this.comboBox_docente.SelectedIndexChanged += new System.EventHandler(this.docentecbox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 145);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_horario_docente
            // 
            this.groupBox_horario_docente.Controls.Add(this.pictureBox2);
            this.groupBox_horario_docente.Controls.Add(this.comboBox1);
            this.groupBox_horario_docente.Controls.Add(this.textBox2);
            this.groupBox_horario_docente.Controls.Add(this.textBox1);
            this.groupBox_horario_docente.Controls.Add(this.label3);
            this.groupBox_horario_docente.Controls.Add(this.label2);
            this.groupBox_horario_docente.Controls.Add(this.label1);
            this.groupBox_horario_docente.Location = new System.Drawing.Point(12, 209);
            this.groupBox_horario_docente.Name = "groupBox_horario_docente";
            this.groupBox_horario_docente.Size = new System.Drawing.Size(604, 213);
            this.groupBox_horario_docente.TabIndex = 3;
            this.groupBox_horario_docente.TabStop = false;
            this.groupBox_horario_docente.Text = "groupBox1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(373, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 152);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // docentefr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_horario_docente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_docente);
            this.Controls.Add(this.textBox_docente);
            this.Name = "docentefr";
            this.Text = "docentefr";
            this.Load += new System.EventHandler(this.docentefr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_horario_docente.ResumeLayout(false);
            this.groupBox_horario_docente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_docente;
        private System.Windows.Forms.ComboBox comboBox_docente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_horario_docente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}