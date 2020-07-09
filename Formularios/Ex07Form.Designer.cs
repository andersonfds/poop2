namespace POOP2.Formularios
{
    partial class Ex07Form
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPublisherName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbChapterNumber = new System.Windows.Forms.NumericUpDown();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbChapterTitle = new System.Windows.Forms.TextBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnTurnPage = new System.Windows.Forms.Button();
            this.btnChapters = new System.Windows.Forms.Button();
            this.lbxChapters = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbChapterNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbPublisherName);
            this.groupBox1.Controls.Add(this.lblBookName);
            this.groupBox1.Controls.Add(this.txbBookName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livro";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(97, 101);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(178, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Editora do Livro";
            // 
            // txbPublisherName
            // 
            this.txbPublisherName.Location = new System.Drawing.Point(6, 75);
            this.txbPublisherName.Name = "txbPublisherName";
            this.txbPublisherName.Size = new System.Drawing.Size(247, 20);
            this.txbPublisherName.TabIndex = 2;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(7, 20);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(76, 13);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "Nome do Livro";
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(6, 36);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(247, 20);
            this.txbBookName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbChapterNumber);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbChapterTitle);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 133);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capítulo";
            // 
            // txbChapterNumber
            // 
            this.txbChapterNumber.Location = new System.Drawing.Point(6, 75);
            this.txbChapterNumber.Name = "txbChapterNumber";
            this.txbChapterNumber.Size = new System.Drawing.Size(247, 20);
            this.txbChapterNumber.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(178, 101);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Inserir";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de Páginas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome do Capítulo";
            // 
            // txbChapterTitle
            // 
            this.txbChapterTitle.Location = new System.Drawing.Point(6, 36);
            this.txbChapterTitle.Name = "txbChapterTitle";
            this.txbChapterTitle.Size = new System.Drawing.Size(247, 20);
            this.txbChapterTitle.TabIndex = 0;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(497, 311);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(117, 23);
            this.btnDetails.TabIndex = 6;
            this.btnDetails.Text = "Detalhes";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnTurnPage
            // 
            this.btnTurnPage.Location = new System.Drawing.Point(295, 311);
            this.btnTurnPage.Name = "btnTurnPage";
            this.btnTurnPage.Size = new System.Drawing.Size(116, 23);
            this.btnTurnPage.TabIndex = 7;
            this.btnTurnPage.Text = "Virar a Página";
            this.btnTurnPage.UseVisualStyleBackColor = true;
            this.btnTurnPage.Click += new System.EventHandler(this.btnTurnPage_Click);
            // 
            // btnChapters
            // 
            this.btnChapters.Location = new System.Drawing.Point(12, 151);
            this.btnChapters.Name = "btnChapters";
            this.btnChapters.Size = new System.Drawing.Size(259, 39);
            this.btnChapters.TabIndex = 8;
            this.btnChapters.Text = "Trocar de Capítulo";
            this.btnChapters.UseVisualStyleBackColor = true;
            this.btnChapters.Click += new System.EventHandler(this.btnChapters_Click);
            // 
            // lbxChapters
            // 
            this.lbxChapters.FormattingEnabled = true;
            this.lbxChapters.Location = new System.Drawing.Point(295, 41);
            this.lbxChapters.Name = "lbxChapters";
            this.lbxChapters.Size = new System.Drawing.Size(319, 264);
            this.lbxChapters.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Capítulos do Livro";
            // 
            // Ex07Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lbxChapters);
            this.Controls.Add(this.btnChapters);
            this.Controls.Add(this.btnTurnPage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ex07Form";
            this.Text = "Ex07Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbChapterNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPublisherName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbChapterTitle;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.NumericUpDown txbChapterNumber;
        private System.Windows.Forms.Button btnTurnPage;
        private System.Windows.Forms.Button btnChapters;
        private System.Windows.Forms.ListBox lbxChapters;
        private System.Windows.Forms.Label label4;
    }
}