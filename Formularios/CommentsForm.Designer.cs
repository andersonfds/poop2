namespace POOP2.Formularios
{
    partial class CommentsForm
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
            this.lbxComments = new System.Windows.Forms.ListBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCurtir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxComments
            // 
            this.lbxComments.FormattingEnabled = true;
            this.lbxComments.Location = new System.Drawing.Point(12, 12);
            this.lbxComments.Name = "lbxComments";
            this.lbxComments.Size = new System.Drawing.Size(342, 329);
            this.lbxComments.TabIndex = 15;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(183, 349);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(169, 33);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCurtir
            // 
            this.btnCurtir.Location = new System.Drawing.Point(12, 349);
            this.btnCurtir.Name = "btnCurtir";
            this.btnCurtir.Size = new System.Drawing.Size(165, 33);
            this.btnCurtir.TabIndex = 12;
            this.btnCurtir.Text = "Curtir";
            this.btnCurtir.UseVisualStyleBackColor = true;
            this.btnCurtir.Click += new System.EventHandler(this.btnCurtir_Click);
            // 
            // CommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 394);
            this.Controls.Add(this.lbxComments);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCurtir);
            this.Name = "CommentsForm";
            this.Text = "CommentsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox lbxComments;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCurtir;
    }
}