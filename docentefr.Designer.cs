﻿namespace practica_feria
{
    partial class horainicio_text
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
            this.textBox_docente = new System.Windows.Forms.TextBox();
            this.comboBox_docente = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_horario_docente = new System.Windows.Forms.GroupBox();
            this.paralelo_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Materia_text = new System.Windows.Forms.TextBox();
            this.horafin_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texthorainici = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textcurso = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btbuscar = new System.Windows.Forms.Button();
            this.groudatadocente = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_horario_docente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groudatadocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_docente
            // 
            this.textBox_docente.Location = new System.Drawing.Point(202, 163);
            this.textBox_docente.Name = "textBox_docente";
            this.textBox_docente.Size = new System.Drawing.Size(100, 20);
            this.textBox_docente.TabIndex = 0;
            this.textBox_docente.TextChanged += new System.EventHandler(this.textBox_docente_TextChanged);
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
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::practica_feria.Properties.Resources.asistentesinfondo;
            this.pictureBox1.Location = new System.Drawing.Point(221, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_horario_docente
            // 
            this.groupBox_horario_docente.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_horario_docente.Controls.Add(this.paralelo_text);
            this.groupBox_horario_docente.Controls.Add(this.label6);
            this.groupBox_horario_docente.Controls.Add(this.Materia_text);
            this.groupBox_horario_docente.Controls.Add(this.horafin_text);
            this.groupBox_horario_docente.Controls.Add(this.label5);
            this.groupBox_horario_docente.Controls.Add(this.label4);
            this.groupBox_horario_docente.Controls.Add(this.texthorainici);
            this.groupBox_horario_docente.Controls.Add(this.pictureBox2);
            this.groupBox_horario_docente.Controls.Add(this.textcurso);
            this.groupBox_horario_docente.Controls.Add(this.textnombre);
            this.groupBox_horario_docente.Controls.Add(this.label3);
            this.groupBox_horario_docente.Controls.Add(this.label2);
            this.groupBox_horario_docente.Controls.Add(this.label1);
            this.groupBox_horario_docente.Location = new System.Drawing.Point(12, 190);
            this.groupBox_horario_docente.Name = "groupBox_horario_docente";
            this.groupBox_horario_docente.Size = new System.Drawing.Size(718, 331);
            this.groupBox_horario_docente.TabIndex = 3;
            this.groupBox_horario_docente.TabStop = false;
            this.groupBox_horario_docente.Visible = false;
            this.groupBox_horario_docente.Enter += new System.EventHandler(this.groupBox_horario_docente_Enter);
            // 
            // paralelo_text
            // 
            this.paralelo_text.Location = new System.Drawing.Point(126, 74);
            this.paralelo_text.Name = "paralelo_text";
            this.paralelo_text.Size = new System.Drawing.Size(100, 20);
            this.paralelo_text.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Paralelo";
            // 
            // Materia_text
            // 
            this.Materia_text.Location = new System.Drawing.Point(126, 46);
            this.Materia_text.Name = "Materia_text";
            this.Materia_text.Size = new System.Drawing.Size(100, 20);
            this.Materia_text.TabIndex = 11;
            // 
            // horafin_text
            // 
            this.horafin_text.Location = new System.Drawing.Point(126, 126);
            this.horafin_text.Name = "horafin_text";
            this.horafin_text.Size = new System.Drawing.Size(100, 20);
            this.horafin_text.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hora fin";
            // 
            // texthorainici
            // 
            this.texthorainici.Location = new System.Drawing.Point(126, 100);
            this.texthorainici.Name = "texthorainici";
            this.texthorainici.Size = new System.Drawing.Size(100, 20);
            this.texthorainici.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(264, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(428, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // textcurso
            // 
            this.textcurso.Location = new System.Drawing.Point(126, 164);
            this.textcurso.Name = "textcurso";
            this.textcurso.Size = new System.Drawing.Size(100, 20);
            this.textcurso.TabIndex = 4;
            this.textcurso.TextChanged += new System.EventHandler(this.textcurso_TextChanged);
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(126, 19);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(100, 20);
            this.textnombre.TabIndex = 3;
            this.textnombre.TextChanged += new System.EventHandler(this.textnombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora incio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
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
            // btbuscar
            // 
            this.btbuscar.Location = new System.Drawing.Point(538, 161);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(75, 23);
            this.btbuscar.TabIndex = 5;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // groudatadocente
            // 
            this.groudatadocente.BackColor = System.Drawing.Color.Transparent;
            this.groudatadocente.Controls.Add(this.dataGridView1);
            this.groudatadocente.Location = new System.Drawing.Point(12, 189);
            this.groudatadocente.Name = "groudatadocente";
            this.groudatadocente.Size = new System.Drawing.Size(645, 258);
            this.groudatadocente.TabIndex = 6;
            this.groudatadocente.TabStop = false;
            this.groudatadocente.Visible = false;
            this.groudatadocente.Enter += new System.EventHandler(this.groudatadocente_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(526, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // horainicio_text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::practica_feria.Properties.Resources.degradadogris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 536);
            this.Controls.Add(this.groudatadocente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_horario_docente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_docente);
            this.Controls.Add(this.textBox_docente);
            this.Name = "horainicio_text";
            this.Text = "docentefr";
            this.Load += new System.EventHandler(this.docentefr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_horario_docente.ResumeLayout(false);
            this.groupBox_horario_docente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groudatadocente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox textcurso;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox texthorainici;
        private System.Windows.Forms.TextBox paralelo_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Materia_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox horafin_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.GroupBox groudatadocente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}