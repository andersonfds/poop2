namespace POOP2.Formularios
{
    partial class Ex09Form
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
            this.modelTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearTxb = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTxb = new System.Windows.Forms.TextBox();
            this.doorCountTxb = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.eletricRangeTxb = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.printParentBtn = new System.Windows.Forms.Button();
            this.startCarBtn = new System.Windows.Forms.Button();
            this.rechargeBatteriesBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearTxb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorCountTxb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletricRangeTxb)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eletricRangeTxb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.doorCountTxb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.priceTxb);
            this.groupBox1.Controls.Add(this.yearTxb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.colorTxb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.modelTxb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carro Elétrico";
            // 
            // modelTxb
            // 
            this.modelTxb.Location = new System.Drawing.Point(6, 39);
            this.modelTxb.Name = "modelTxb";
            this.modelTxb.Size = new System.Drawing.Size(457, 20);
            this.modelTxb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cor";
            // 
            // colorTxb
            // 
            this.colorTxb.Location = new System.Drawing.Point(6, 81);
            this.colorTxb.Name = "colorTxb";
            this.colorTxb.Size = new System.Drawing.Size(457, 20);
            this.colorTxb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ano";
            // 
            // yearTxb
            // 
            this.yearTxb.Location = new System.Drawing.Point(7, 123);
            this.yearTxb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yearTxb.Name = "yearTxb";
            this.yearTxb.Size = new System.Drawing.Size(456, 20);
            this.yearTxb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço";
            // 
            // priceTxb
            // 
            this.priceTxb.Location = new System.Drawing.Point(6, 165);
            this.priceTxb.Name = "priceTxb";
            this.priceTxb.Size = new System.Drawing.Size(457, 20);
            this.priceTxb.TabIndex = 7;
            // 
            // doorCountTxb
            // 
            this.doorCountTxb.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.doorCountTxb.Location = new System.Drawing.Point(7, 205);
            this.doorCountTxb.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.doorCountTxb.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.doorCountTxb.Name = "doorCountTxb";
            this.doorCountTxb.Size = new System.Drawing.Size(456, 20);
            this.doorCountTxb.TabIndex = 10;
            this.doorCountTxb.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero de Portas";
            // 
            // eletricRangeTxb
            // 
            this.eletricRangeTxb.Location = new System.Drawing.Point(7, 245);
            this.eletricRangeTxb.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.eletricRangeTxb.Name = "eletricRangeTxb";
            this.eletricRangeTxb.Size = new System.Drawing.Size(456, 20);
            this.eletricRangeTxb.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "KMs por Bateria Cheia";
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(12, 293);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(211, 52);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Imprimir";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(270, 293);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(211, 52);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Salvar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // printParentBtn
            // 
            this.printParentBtn.Location = new System.Drawing.Point(12, 360);
            this.printParentBtn.Name = "printParentBtn";
            this.printParentBtn.Size = new System.Drawing.Size(211, 52);
            this.printParentBtn.TabIndex = 3;
            this.printParentBtn.Text = "Imprimir (Pai)";
            this.printParentBtn.UseVisualStyleBackColor = true;
            this.printParentBtn.Click += new System.EventHandler(this.printParentBtn_Click);
            // 
            // startCarBtn
            // 
            this.startCarBtn.Location = new System.Drawing.Point(270, 360);
            this.startCarBtn.Name = "startCarBtn";
            this.startCarBtn.Size = new System.Drawing.Size(211, 52);
            this.startCarBtn.TabIndex = 4;
            this.startCarBtn.Text = "Iniciar o Carro";
            this.startCarBtn.UseVisualStyleBackColor = true;
            this.startCarBtn.Click += new System.EventHandler(this.startCarBtn_Click);
            // 
            // rechargeBatteriesBtn
            // 
            this.rechargeBatteriesBtn.Location = new System.Drawing.Point(270, 425);
            this.rechargeBatteriesBtn.Name = "rechargeBatteriesBtn";
            this.rechargeBatteriesBtn.Size = new System.Drawing.Size(211, 52);
            this.rechargeBatteriesBtn.TabIndex = 5;
            this.rechargeBatteriesBtn.Text = "Recarregar a Bateria";
            this.rechargeBatteriesBtn.UseVisualStyleBackColor = true;
            this.rechargeBatteriesBtn.Click += new System.EventHandler(this.rechargeBatteriesBtn_Click);
            // 
            // Ex09Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 489);
            this.Controls.Add(this.rechargeBatteriesBtn);
            this.Controls.Add(this.startCarBtn);
            this.Controls.Add(this.printParentBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ex09Form";
            this.Text = "Ex09Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearTxb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorCountTxb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eletricRangeTxb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox modelTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox colorTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown yearTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTxb;
        private System.Windows.Forms.NumericUpDown doorCountTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown eletricRangeTxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button printParentBtn;
        private System.Windows.Forms.Button startCarBtn;
        private System.Windows.Forms.Button rechargeBatteriesBtn;
    }
}