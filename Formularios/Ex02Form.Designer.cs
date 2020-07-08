namespace POOP2.Formularios
{
    partial class Ex02Form
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
            this.btnProductDetails = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStorePrint = new System.Windows.Forms.Button();
            this.btnIsClosed = new System.Windows.Forms.Button();
            this.btnStoreSave = new System.Windows.Forms.Button();
            this.txbStoreAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbStoreName = new System.Windows.Forms.TextBox();
            this.btnStoreBreak = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.txbProductPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbQtdAvailable = new System.Windows.Forms.NumericUpDown();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwProduct = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbQtdAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductDetails
            // 
            this.btnProductDetails.Location = new System.Drawing.Point(499, 378);
            this.btnProductDetails.Name = "btnProductDetails";
            this.btnProductDetails.Size = new System.Drawing.Size(137, 34);
            this.btnProductDetails.TabIndex = 1;
            this.btnProductDetails.Text = "Detalhes do Item (Print)";
            this.btnProductDetails.UseVisualStyleBackColor = true;
            this.btnProductDetails.Click += new System.EventHandler(this.btnProductDetails_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(350, 378);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(143, 34);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "Vender";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome da Loja";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStorePrint);
            this.groupBox1.Controls.Add(this.btnIsClosed);
            this.groupBox1.Controls.Add(this.btnStoreSave);
            this.groupBox1.Controls.Add(this.txbStoreAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbStoreName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 158);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Loja";
            // 
            // btnStorePrint
            // 
            this.btnStorePrint.Location = new System.Drawing.Point(115, 103);
            this.btnStorePrint.Name = "btnStorePrint";
            this.btnStorePrint.Size = new System.Drawing.Size(96, 48);
            this.btnStorePrint.TabIndex = 10;
            this.btnStorePrint.Text = "Imprimir";
            this.btnStorePrint.UseVisualStyleBackColor = true;
            this.btnStorePrint.Click += new System.EventHandler(this.btnStorePrint_Click);
            // 
            // btnIsClosed
            // 
            this.btnIsClosed.Location = new System.Drawing.Point(9, 104);
            this.btnIsClosed.Name = "btnIsClosed";
            this.btnIsClosed.Size = new System.Drawing.Size(100, 48);
            this.btnIsClosed.TabIndex = 9;
            this.btnIsClosed.Text = "Está fechada?";
            this.btnIsClosed.UseVisualStyleBackColor = true;
            this.btnIsClosed.Click += new System.EventHandler(this.btnIsClosed_Click);
            // 
            // btnStoreSave
            // 
            this.btnStoreSave.Location = new System.Drawing.Point(217, 104);
            this.btnStoreSave.Name = "btnStoreSave";
            this.btnStoreSave.Size = new System.Drawing.Size(108, 48);
            this.btnStoreSave.TabIndex = 8;
            this.btnStoreSave.Text = "Salvar";
            this.btnStoreSave.UseVisualStyleBackColor = true;
            this.btnStoreSave.Click += new System.EventHandler(this.btnStoreSave_Click);
            // 
            // txbStoreAddress
            // 
            this.txbStoreAddress.Location = new System.Drawing.Point(9, 77);
            this.txbStoreAddress.Name = "txbStoreAddress";
            this.txbStoreAddress.Size = new System.Drawing.Size(317, 20);
            this.txbStoreAddress.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Endereço";
            // 
            // txbStoreName
            // 
            this.txbStoreName.Location = new System.Drawing.Point(9, 35);
            this.txbStoreName.Name = "txbStoreName";
            this.txbStoreName.Size = new System.Drawing.Size(317, 20);
            this.txbStoreName.TabIndex = 5;
            // 
            // btnStoreBreak
            // 
            this.btnStoreBreak.Location = new System.Drawing.Point(12, 179);
            this.btnStoreBreak.Name = "btnStoreBreak";
            this.btnStoreBreak.Size = new System.Drawing.Size(332, 40);
            this.btnStoreBreak.TabIndex = 6;
            this.btnStoreBreak.Text = "Arrombar Loja (caso esteja fechada)";
            this.btnStoreBreak.UseVisualStyleBackColor = true;
            this.btnStoreBreak.Click += new System.EventHandler(this.btnStoreBreak_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProductSave);
            this.groupBox2.Controls.Add(this.txbProductPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbQtdAvailable);
            this.groupBox2.Controls.Add(this.txbProductName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 186);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // btnProductSave
            // 
            this.btnProductSave.Location = new System.Drawing.Point(173, 136);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(152, 44);
            this.btnProductSave.TabIndex = 10;
            this.btnProductSave.Text = "Salvar";
            this.btnProductSave.UseVisualStyleBackColor = true;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // txbProductPrice
            // 
            this.txbProductPrice.Location = new System.Drawing.Point(8, 110);
            this.txbProductPrice.Name = "txbProductPrice";
            this.txbProductPrice.Size = new System.Drawing.Size(317, 20);
            this.txbProductPrice.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantidade disponível";
            // 
            // txbQtdAvailable
            // 
            this.txbQtdAvailable.Location = new System.Drawing.Point(9, 71);
            this.txbQtdAvailable.Name = "txbQtdAvailable";
            this.txbQtdAvailable.Size = new System.Drawing.Size(316, 20);
            this.txbQtdAvailable.TabIndex = 12;
            // 
            // txbProductName
            // 
            this.txbProductName.Location = new System.Drawing.Point(9, 32);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(317, 20);
            this.txbProductName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome do Produto";
            // 
            // lvwProduct
            // 
            this.lvwProduct.FormattingEnabled = true;
            this.lvwProduct.Location = new System.Drawing.Point(353, 33);
            this.lvwProduct.Name = "lvwProduct";
            this.lvwProduct.Size = new System.Drawing.Size(280, 329);
            this.lvwProduct.TabIndex = 8;
            // 
            // Ex02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 422);
            this.Controls.Add(this.lvwProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStoreBreak);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnProductDetails);
            this.Name = "Ex02Form";
            this.Text = "Ex02Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbQtdAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProductDetails;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbStoreAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbStoreName;
        private System.Windows.Forms.Button btnIsClosed;
        private System.Windows.Forms.Button btnStoreSave;
        private System.Windows.Forms.Button btnStoreBreak;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txbQtdAvailable;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.TextBox txbProductPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStorePrint;
        private System.Windows.Forms.ListBox lvwProduct;
    }
}