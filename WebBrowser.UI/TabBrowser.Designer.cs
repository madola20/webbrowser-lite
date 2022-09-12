namespace WebBrowser.UI
{
    partial class TabBrowser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabBrowser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backBtn = new System.Windows.Forms.ToolStripButton();
            this.forwardBtn = new System.Windows.Forms.ToolStripButton();
            this.refreshBtn = new System.Windows.Forms.ToolStripButton();
            this.homeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.goBtn = new System.Windows.Forms.ToolStripButton();
            this.bookmarkBtn = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.progressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backBtn,
            this.forwardBtn,
            this.refreshBtn,
            this.homeBtn,
            this.toolStripTextBox1,
            this.goBtn,
            this.bookmarkBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(389, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // backBtn
            // 
            this.backBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(23, 22);
            this.backBtn.Text = "backButton";
            this.backBtn.ToolTipText = "backButton";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardBtn.Image = ((System.Drawing.Image)(resources.GetObject("forwardBtn.Image")));
            this.forwardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(23, 22);
            this.forwardBtn.Text = "forwardButton";
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(23, 22);
            this.refreshBtn.Text = "refreshButton";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(23, 22);
            this.homeBtn.Text = "homeButton";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress_1);
            // 
            // goBtn
            // 
            this.goBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goBtn.Image = ((System.Drawing.Image)(resources.GetObject("goBtn.Image")));
            this.goBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(23, 22);
            this.goBtn.Text = "goButton";
            this.goBtn.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // bookmarkBtn
            // 
            this.bookmarkBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmarkBtn.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkBtn.Image")));
            this.bookmarkBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarkBtn.Name = "bookmarkBtn";
            this.bookmarkBtn.Size = new System.Drawing.Size(23, 22);
            this.bookmarkBtn.Text = "bookmarkButton";
            this.bookmarkBtn.Click += new System.EventHandler(this.bookmarkBtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(389, 276);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.progressLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(389, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // progressLabel
            // 
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // TabBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TabBrowser";
            this.Size = new System.Drawing.Size(389, 301);
            this.Load += new System.EventHandler(this.TabBrowser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton backBtn;
        public System.Windows.Forms.ToolStripButton forwardBtn;
        public System.Windows.Forms.ToolStripButton refreshBtn;
        public System.Windows.Forms.ToolStripButton homeBtn;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.ToolStripButton goBtn;
        public System.Windows.Forms.ToolStripButton bookmarkBtn;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel progressLabel;
    }
}
