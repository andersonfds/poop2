namespace POOP2.Formularios
{
    partial class Ex04Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProfessorName = new System.Windows.Forms.TextBox();
            this.txtGradeName = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditProfessor = new System.Windows.Forms.Button();
            this.btnPrintProfessor = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnPrintSelectedStudent = new System.Windows.Forms.Button();
            this.btnMakeTest = new System.Windows.Forms.Button();
            this.listViewStudents = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.btnPrintProfessor);
            this.groupBox1.Controls.Add(this.btnEditProfessor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.txtGradeName);
            this.groupBox1.Controls.Add(this.txtProfessorName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome da matéria";
            // 
            // txtProfessorName
            // 
            this.txtProfessorName.Location = new System.Drawing.Point(9, 32);
            this.txtProfessorName.Name = "txtProfessorName";
            this.txtProfessorName.Size = new System.Drawing.Size(252, 20);
            this.txtProfessorName.TabIndex = 2;
            // 
            // txtGradeName
            // 
            this.txtGradeName.Location = new System.Drawing.Point(9, 71);
            this.txtGradeName.Name = "txtGradeName";
            this.txtGradeName.Size = new System.Drawing.Size(252, 20);
            this.txtGradeName.TabIndex = 3;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(9, 158);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(252, 20);
            this.txtStudentName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome do aluno";
            // 
            // btnEditProfessor
            // 
            this.btnEditProfessor.Location = new System.Drawing.Point(9, 97);
            this.btnEditProfessor.Name = "btnEditProfessor";
            this.btnEditProfessor.Size = new System.Drawing.Size(124, 35);
            this.btnEditProfessor.TabIndex = 6;
            this.btnEditProfessor.Text = "Salvar alterações";
            this.btnEditProfessor.UseVisualStyleBackColor = true;
            this.btnEditProfessor.Click += new System.EventHandler(this.btnEditProfessor_Click);
            // 
            // btnPrintProfessor
            // 
            this.btnPrintProfessor.Location = new System.Drawing.Point(137, 97);
            this.btnPrintProfessor.Name = "btnPrintProfessor";
            this.btnPrintProfessor.Size = new System.Drawing.Size(124, 35);
            this.btnPrintProfessor.TabIndex = 7;
            this.btnPrintProfessor.Text = "Imprimir";
            this.btnPrintProfessor.UseVisualStyleBackColor = true;
            this.btnPrintProfessor.Click += new System.EventHandler(this.btnPrintProfessor_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(9, 184);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(124, 35);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Adicionar aluno";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnPrintSelectedStudent
            // 
            this.btnPrintSelectedStudent.Location = new System.Drawing.Point(428, 286);
            this.btnPrintSelectedStudent.Name = "btnPrintSelectedStudent";
            this.btnPrintSelectedStudent.Size = new System.Drawing.Size(124, 36);
            this.btnPrintSelectedStudent.TabIndex = 2;
            this.btnPrintSelectedStudent.Text = "Imprimir selecionado";
            this.btnPrintSelectedStudent.UseVisualStyleBackColor = true;
            this.btnPrintSelectedStudent.Click += new System.EventHandler(this.btnPrintSelectedStudent_Click);
            // 
            // btnMakeTest
            // 
            this.btnMakeTest.Location = new System.Drawing.Point(285, 286);
            this.btnMakeTest.Name = "btnMakeTest";
            this.btnMakeTest.Size = new System.Drawing.Size(137, 36);
            this.btnMakeTest.TabIndex = 3;
            this.btnMakeTest.Text = "Fazer prova";
            this.btnMakeTest.UseVisualStyleBackColor = true;
            this.btnMakeTest.Click += new System.EventHandler(this.btnMakeTest_Click);
            // 
            // listViewStudents
            // 
            this.listViewStudents.DisplayMember = "Name";
            this.listViewStudents.FormattingEnabled = true;
            this.listViewStudents.Location = new System.Drawing.Point(288, 28);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(263, 251);
            this.listViewStudents.TabIndex = 4;
            // 
            // Ex04Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 329);
            this.Controls.Add(this.listViewStudents);
            this.Controls.Add(this.btnMakeTest);
            this.Controls.Add(this.btnPrintSelectedStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ex04Form";
            this.Text = "Ex04Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnPrintProfessor;
        private System.Windows.Forms.Button btnEditProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtGradeName;
        private System.Windows.Forms.TextBox txtProfessorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintSelectedStudent;
        private System.Windows.Forms.Button btnMakeTest;
        private System.Windows.Forms.ListBox listViewStudents;
    }
}