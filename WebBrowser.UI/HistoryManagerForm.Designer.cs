namespace WebBrowser.UI
{
    partial class HistoryManagerForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.searchHistoryTextBox = new System.Windows.Forms.TextBox();
            this.searchHistoryBtn = new System.Windows.Forms.Button();
            this.deleteHistoryBtn = new System.Windows.Forms.Button();
            this.clearHistoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(800, 394);
            this.listBox1.TabIndex = 0;
            // 
            // searchHistoryTextBox
            // 
            this.searchHistoryTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchHistoryTextBox.Location = new System.Drawing.Point(0, 0);
            this.searchHistoryTextBox.Name = "searchHistoryTextBox";
            this.searchHistoryTextBox.Size = new System.Drawing.Size(800, 20);
            this.searchHistoryTextBox.TabIndex = 1;
            // 
            // searchHistoryBtn
            // 
            this.searchHistoryBtn.Location = new System.Drawing.Point(632, 27);
            this.searchHistoryBtn.Name = "searchHistoryBtn";
            this.searchHistoryBtn.Size = new System.Drawing.Size(75, 23);
            this.searchHistoryBtn.TabIndex = 2;
            this.searchHistoryBtn.Text = "Search";
            this.searchHistoryBtn.UseVisualStyleBackColor = true;
            this.searchHistoryBtn.Click += new System.EventHandler(this.searchHistoryBtn_Click);
            // 
            // deleteHistoryBtn
            // 
            this.deleteHistoryBtn.Location = new System.Drawing.Point(713, 27);
            this.deleteHistoryBtn.Name = "deleteHistoryBtn";
            this.deleteHistoryBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteHistoryBtn.TabIndex = 3;
            this.deleteHistoryBtn.Text = "Delete";
            this.deleteHistoryBtn.UseVisualStyleBackColor = true;
            this.deleteHistoryBtn.Click += new System.EventHandler(this.deleteHistoryBtn_Click);
            // 
            // clearHistoryBtn
            // 
            this.clearHistoryBtn.Location = new System.Drawing.Point(544, 27);
            this.clearHistoryBtn.Name = "clearHistoryBtn";
            this.clearHistoryBtn.Size = new System.Drawing.Size(75, 23);
            this.clearHistoryBtn.TabIndex = 4;
            this.clearHistoryBtn.Text = "Clear History";
            this.clearHistoryBtn.UseVisualStyleBackColor = true;
            this.clearHistoryBtn.Click += new System.EventHandler(this.clearHistoryBtn_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearHistoryBtn);
            this.Controls.Add(this.deleteHistoryBtn);
            this.Controls.Add(this.searchHistoryBtn);
            this.Controls.Add(this.searchHistoryTextBox);
            this.Controls.Add(this.listBox1);
            this.Name = "HistoryManagerForm";
            this.Text = "History Manager";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox searchHistoryTextBox;
        private System.Windows.Forms.Button searchHistoryBtn;
        private System.Windows.Forms.Button deleteHistoryBtn;
        private System.Windows.Forms.Button clearHistoryBtn;
    }
}