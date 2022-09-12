namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
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
            this.searchTerm = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBookmarkBtn = new System.Windows.Forms.Button();
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
            // searchTerm
            // 
            this.searchTerm.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchTerm.Location = new System.Drawing.Point(0, 0);
            this.searchTerm.Name = "searchTerm";
            this.searchTerm.Size = new System.Drawing.Size(800, 20);
            this.searchTerm.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(596, 26);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBookmarkBtn
            // 
            this.deleteBookmarkBtn.Location = new System.Drawing.Point(677, 27);
            this.deleteBookmarkBtn.Name = "deleteBookmarkBtn";
            this.deleteBookmarkBtn.Size = new System.Drawing.Size(123, 23);
            this.deleteBookmarkBtn.TabIndex = 3;
            this.deleteBookmarkBtn.Text = "Delete Bookmark";
            this.deleteBookmarkBtn.UseVisualStyleBackColor = true;
            this.deleteBookmarkBtn.Click += new System.EventHandler(this.deleteBookmarkBtn_Click);
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBookmarkBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTerm);
            this.Controls.Add(this.listBox1);
            this.Name = "BookmarkManagerForm";
            this.Text = "Bookmark Manager";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox searchTerm;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBookmarkBtn;
    }
}