namespace POOP2.Formularios
{
    partial class Ex01Form
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
            this.firstNameTxb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lastNameTxb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cardNumberTxb = new System.Windows.Forms.TextBox();
            this.dateTxb = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userSaveBtn = new System.Windows.Forms.Button();
            this.userPrintBtn = new System.Windows.Forms.Button();
            this.printCreditCardTxb = new System.Windows.Forms.Button();
            this.saveCreditCardTxb = new System.Windows.Forms.Button();
            this.userBuyTxb = new System.Windows.Forms.Button();
            this.creditCardIncreaseLimitTxb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cvvNumberTxb = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cvvNumberTxb)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTxb
            // 
            this.firstNameTxb.Location = new System.Drawing.Point(6, 39);
            this.firstNameTxb.Name = "firstNameTxb";
            this.firstNameTxb.Size = new System.Drawing.Size(257, 20);
            this.firstNameTxb.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.userPrintBtn);
            this.groupBox1.Controls.Add(this.userSaveBtn);
            this.groupBox1.Controls.Add(this.lastNameTxb);
            this.groupBox1.Controls.Add(this.firstNameTxb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // lastNameTxb
            // 
            this.lastNameTxb.Location = new System.Drawing.Point(6, 88);
            this.lastNameTxb.Name = "lastNameTxb";
            this.lastNameTxb.Size = new System.Drawing.Size(257, 20);
            this.lastNameTxb.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cvvNumberTxb);
            this.groupBox2.Controls.Add(this.saveCreditCardTxb);
            this.groupBox2.Controls.Add(this.printCreditCardTxb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTxb);
            this.groupBox2.Controls.Add(this.cardNumberTxb);
            this.groupBox2.Location = new System.Drawing.Point(307, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 196);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cartão de Crédito";
            // 
            // cardNumberTxb
            // 
            this.cardNumberTxb.Location = new System.Drawing.Point(6, 39);
            this.cardNumberTxb.Name = "cardNumberTxb";
            this.cardNumberTxb.Size = new System.Drawing.Size(177, 20);
            this.cardNumberTxb.TabIndex = 0;
            // 
            // dateTxb
            // 
            this.dateTxb.Location = new System.Drawing.Point(6, 88);
            this.dateTxb.Name = "dateTxb";
            this.dateTxb.Size = new System.Drawing.Size(257, 20);
            this.dateTxb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data de Expiração";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero do Cartão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CVV";
            // 
            // userSaveBtn
            // 
            this.userSaveBtn.Location = new System.Drawing.Point(146, 147);
            this.userSaveBtn.Name = "userSaveBtn";
            this.userSaveBtn.Size = new System.Drawing.Size(117, 43);
            this.userSaveBtn.TabIndex = 2;
            this.userSaveBtn.Text = "Salvar";
            this.userSaveBtn.UseVisualStyleBackColor = true;
            this.userSaveBtn.Click += new System.EventHandler(this.userSaveBtn_Click);
            // 
            // userPrintBtn
            // 
            this.userPrintBtn.Location = new System.Drawing.Point(6, 147);
            this.userPrintBtn.Name = "userPrintBtn";
            this.userPrintBtn.Size = new System.Drawing.Size(117, 43);
            this.userPrintBtn.TabIndex = 3;
            this.userPrintBtn.Text = "Imprimir";
            this.userPrintBtn.UseVisualStyleBackColor = true;
            this.userPrintBtn.Click += new System.EventHandler(this.userPrintBtn_Click);
            // 
            // printCreditCardTxb
            // 
            this.printCreditCardTxb.Location = new System.Drawing.Point(6, 147);
            this.printCreditCardTxb.Name = "printCreditCardTxb";
            this.printCreditCardTxb.Size = new System.Drawing.Size(117, 43);
            this.printCreditCardTxb.TabIndex = 4;
            this.printCreditCardTxb.Text = "Imprimir";
            this.printCreditCardTxb.UseVisualStyleBackColor = true;
            this.printCreditCardTxb.Click += new System.EventHandler(this.printCreditCardTxb_Click);
            // 
            // saveCreditCardTxb
            // 
            this.saveCreditCardTxb.Location = new System.Drawing.Point(146, 147);
            this.saveCreditCardTxb.Name = "saveCreditCardTxb";
            this.saveCreditCardTxb.Size = new System.Drawing.Size(117, 43);
            this.saveCreditCardTxb.TabIndex = 4;
            this.saveCreditCardTxb.Text = "Salvar";
            this.saveCreditCardTxb.UseVisualStyleBackColor = true;
            this.saveCreditCardTxb.Click += new System.EventHandler(this.saveCreditCardTxb_Click);
            // 
            // userBuyTxb
            // 
            this.userBuyTxb.Location = new System.Drawing.Point(12, 227);
            this.userBuyTxb.Name = "userBuyTxb";
            this.userBuyTxb.Size = new System.Drawing.Size(269, 42);
            this.userBuyTxb.TabIndex = 3;
            this.userBuyTxb.Text = "Comprar";
            this.userBuyTxb.UseVisualStyleBackColor = true;
            this.userBuyTxb.Click += new System.EventHandler(this.userBuyTxb_Click);
            // 
            // creditCardIncreaseLimitTxb
            // 
            this.creditCardIncreaseLimitTxb.Location = new System.Drawing.Point(307, 227);
            this.creditCardIncreaseLimitTxb.Name = "creditCardIncreaseLimitTxb";
            this.creditCardIncreaseLimitTxb.Size = new System.Drawing.Size(269, 42);
            this.creditCardIncreaseLimitTxb.TabIndex = 4;
            this.creditCardIncreaseLimitTxb.Text = "Aumentar Limite";
            this.creditCardIncreaseLimitTxb.UseVisualStyleBackColor = true;
            this.creditCardIncreaseLimitTxb.Click += new System.EventHandler(this.creditCardIncreaseLimitTxb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sobrenome";
            // 
            // cvvNumberTxb
            // 
            this.cvvNumberTxb.Location = new System.Drawing.Point(189, 39);
            this.cvvNumberTxb.Name = "cvvNumberTxb";
            this.cvvNumberTxb.Size = new System.Drawing.Size(74, 20);
            this.cvvNumberTxb.TabIndex = 10;
            // 
            // Ex01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 290);
            this.Controls.Add(this.creditCardIncreaseLimitTxb);
            this.Controls.Add(this.userBuyTxb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ex01Form";
            this.Text = "Ex01Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cvvNumberTxb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTxb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lastNameTxb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTxb;
        private System.Windows.Forms.TextBox cardNumberTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button userPrintBtn;
        private System.Windows.Forms.Button userSaveBtn;
        private System.Windows.Forms.Button saveCreditCardTxb;
        private System.Windows.Forms.Button printCreditCardTxb;
        private System.Windows.Forms.Button userBuyTxb;
        private System.Windows.Forms.Button creditCardIncreaseLimitTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cvvNumberTxb;
    }
}