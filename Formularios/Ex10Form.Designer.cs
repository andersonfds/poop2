namespace POOP2.Formularios
{
    partial class Ex10Form
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
            this.ageTxb = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxb = new System.Windows.Forms.TextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.emitSoundBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageTxb)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ageTxb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameTxb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Cachorro";
            // 
            // ageTxb
            // 
            this.ageTxb.Location = new System.Drawing.Point(6, 88);
            this.ageTxb.Name = "ageTxb";
            this.ageTxb.Size = new System.Drawing.Size(120, 20);
            this.ageTxb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Idade do cachorro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do cachorro";
            // 
            // nameTxb
            // 
            this.nameTxb.Location = new System.Drawing.Point(6, 49);
            this.nameTxb.Name = "nameTxb";
            this.nameTxb.Size = new System.Drawing.Size(446, 20);
            this.nameTxb.TabIndex = 0;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(12, 289);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(225, 54);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Imprimir";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(243, 289);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(227, 54);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Salvar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // emitSoundBtn
            // 
            this.emitSoundBtn.Location = new System.Drawing.Point(12, 349);
            this.emitSoundBtn.Name = "emitSoundBtn";
            this.emitSoundBtn.Size = new System.Drawing.Size(458, 54);
            this.emitSoundBtn.TabIndex = 3;
            this.emitSoundBtn.Text = "Emitir Som";
            this.emitSoundBtn.UseVisualStyleBackColor = true;
            this.emitSoundBtn.Click += new System.EventHandler(this.emitSoundBtn_Click);
            // 
            // Ex10Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 421);
            this.Controls.Add(this.emitSoundBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ex10Form";
            this.Text = "Ex10Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageTxb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button emitSoundBtn;
        private System.Windows.Forms.NumericUpDown ageTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxb;
    }
}