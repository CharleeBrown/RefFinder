
namespace ReferFind
{
    partial class Form1
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
            this.refList = new System.Windows.Forms.ListBox();
            this.fileText = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // refList
            // 
            this.refList.FormattingEnabled = true;
            this.refList.ItemHeight = 16;
            this.refList.Location = new System.Drawing.Point(31, 107);
            this.refList.MultiColumn = true;
            this.refList.Name = "refList";
            this.refList.Size = new System.Drawing.Size(454, 132);
            this.refList.Sorted = true;
            this.refList.TabIndex = 0;
            this.refList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.refList_KeyDown);
            // 
            // fileText
            // 
            this.fileText.Cursor = System.Windows.Forms.Cursors.Default;
            this.fileText.Location = new System.Drawing.Point(133, 18);
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(245, 22);
            this.fileText.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(389, 18);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(96, 25);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Browse";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Document Title";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(133, 55);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(352, 22);
            this.title.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 251);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.fileText);
            this.Controls.Add(this.refList);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Reference Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox refList;
        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
    }
}

