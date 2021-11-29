
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.refList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.paramBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileText = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // refList
            // 
            this.refList.FormattingEnabled = true;
            this.refList.ItemHeight = 16;
            this.refList.Location = new System.Drawing.Point(49, 159);
            this.refList.MultiColumn = true;
            this.refList.Name = "refList";
            this.refList.Size = new System.Drawing.Size(475, 132);
            this.refList.Sorted = true;
            this.refList.TabIndex = 0;
            this.refList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.refList_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Document Title";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(151, 89);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(373, 22);
            this.title.TabIndex = 5;
            // 
            // paramBox
            // 
            this.paramBox.FormattingEnabled = true;
            this.paramBox.Location = new System.Drawing.Point(151, 12);
            this.paramBox.Name = "paramBox";
            this.paramBox.Size = new System.Drawing.Size(243, 24);
            this.paramBox.TabIndex = 6;
            this.paramBox.SelectedIndexChanged += new System.EventHandler(this.paramBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search Parameters";
            // 
            // fileText
            // 
            this.fileText.Cursor = System.Windows.Forms.Cursors.Default;
            this.fileText.Location = new System.Drawing.Point(151, 47);
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(243, 22);
            this.fileText.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(407, 47);
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
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "References Found";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 313);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paramBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.fileText);
            this.Controls.Add(this.refList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Reference Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox refList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.ComboBox paramBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

