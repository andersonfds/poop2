namespace POOP2.Formularios
{
    partial class PostsForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblPostTitle = new System.Windows.Forms.Label();
            this.lblPostContent = new System.Windows.Forms.Label();
            this.btnCurtir = new System.Windows.Forms.Button();
            this.btnComentar = new System.Windows.Forms.Button();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.lbxPosts = new System.Windows.Forms.ListBox();
            this.btnComments = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPostTitle
            // 
            this.lblPostTitle.AutoSize = true;
            this.lblPostTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblPostTitle.Location = new System.Drawing.Point(364, 117);
            this.lblPostTitle.MaximumSize = new System.Drawing.Size(280, 0);
            this.lblPostTitle.MinimumSize = new System.Drawing.Size(280, 0);
            this.lblPostTitle.Name = "lblPostTitle";
            this.lblPostTitle.Size = new System.Drawing.Size(280, 26);
            this.lblPostTitle.TabIndex = 2;
            this.lblPostTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPostContent
            // 
            this.lblPostContent.AutoSize = true;
            this.lblPostContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPostContent.Location = new System.Drawing.Point(364, 177);
            this.lblPostContent.MaximumSize = new System.Drawing.Size(280, 0);
            this.lblPostContent.MinimumSize = new System.Drawing.Size(280, 0);
            this.lblPostContent.Name = "lblPostContent";
            this.lblPostContent.Size = new System.Drawing.Size(280, 13);
            this.lblPostContent.TabIndex = 3;
            // 
            // btnCurtir
            // 
            this.btnCurtir.Location = new System.Drawing.Point(365, 12);
            this.btnCurtir.Name = "btnCurtir";
            this.btnCurtir.Size = new System.Drawing.Size(137, 33);
            this.btnCurtir.TabIndex = 4;
            this.btnCurtir.Text = "Curtir";
            this.btnCurtir.UseVisualStyleBackColor = true;
            this.btnCurtir.Click += new System.EventHandler(this.btnCurtir_Click);
            // 
            // btnComentar
            // 
            this.btnComentar.Location = new System.Drawing.Point(508, 12);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(136, 33);
            this.btnComentar.TabIndex = 5;
            this.btnComentar.Text = "Comentar";
            this.btnComentar.UseVisualStyleBackColor = true;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(365, 51);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(279, 20);
            this.txbComment.TabIndex = 6;
            // 
            // lbxPosts
            // 
            this.lbxPosts.FormattingEnabled = true;
            this.lbxPosts.Location = new System.Drawing.Point(12, 12);
            this.lbxPosts.Name = "lbxPosts";
            this.lbxPosts.Size = new System.Drawing.Size(342, 368);
            this.lbxPosts.TabIndex = 7;
            this.lbxPosts.SelectedIndexChanged += new System.EventHandler(this.lbxPosts_SelectedIndexChanged);
            // 
            // btnComments
            // 
            this.btnComments.Location = new System.Drawing.Point(365, 77);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(137, 23);
            this.btnComments.TabIndex = 8;
            this.btnComments.Text = "Ver Comentários";
            this.btnComments.UseVisualStyleBackColor = true;
            this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(508, 77);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(137, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 394);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnComments);
            this.Controls.Add(this.lbxPosts);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.btnComentar);
            this.Controls.Add(this.btnCurtir);
            this.Controls.Add(this.lblPostContent);
            this.Controls.Add(this.lblPostTitle);
            this.Name = "PostsForm";
            this.Text = "PostsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblPostTitle;
        private System.Windows.Forms.Label lblPostContent;
        private System.Windows.Forms.Button btnCurtir;
        private System.Windows.Forms.Button btnComentar;
        private System.Windows.Forms.TextBox txbComment;
        private System.Windows.Forms.ListBox lbxPosts;
        private System.Windows.Forms.Button btnComments;
        private System.Windows.Forms.Button btnPrint;
    }
}