using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class TabBrowser : UserControl
    {
        public TabBrowser()
        {
            InitializeComponent();
        }
        public static int totalBytes = 0;
        private void toolStripButton6_Click(object sender, EventArgs e)
        {

            try
            {
                progressLabel.Visible = false;
                totalBytes = 0;
                webBrowser1.Navigate(toolStripTextBox1.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid URL");
            }
        }






        private void toolStripTextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                webBrowser1.Navigate(toolStripTextBox1.Text);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            backBtn.Enabled = webBrowser1.CanGoBack;
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            forwardBtn.Enabled = webBrowser1.CanGoForward;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void bookmarkBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Document == null)
            {
                return;
            }
            var things = new BookmarkItem();
            things.URL = webBrowser1.Document.Url.ToString();
            things.Title = webBrowser1.Document.Title;
            Boolean foundDuplicate = false;
            foreach (var item in BookmarkManager.GetItems())
            {
                if (item.URL == things.URL)
                {
                    foundDuplicate = true;
                }
            }
            if (!foundDuplicate)
            {
                BookmarkManager.AddItem(things);
            }
       
        }




        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           toolStripTextBox1.Text = webBrowser1.Document.Url.ToString();
            var things = new HistoryItem();
           things.URL = webBrowser1.Document.Url.ToString();
            things.Title = webBrowser1.Document.Title;
            things.Date = DateTime.Now;

            HistoryManager.AddItem(things);


            progressLabel.Visible = true;
            progressLabel.Text = "Done";
        }





        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {

            Console.WriteLine(e.CurrentProgress + " " + e.MaximumProgress);
            progressBar.Maximum = (int)e.MaximumProgress;
            if (e.CurrentProgress != -1 && e.CurrentProgress <= e.MaximumProgress)
            {
                progressBar.Value = (int)e.CurrentProgress;
            }
        }

        private void TabBrowser_Load(object sender, EventArgs e)
        {
        
            progressLabel.Visible = false;
        }
    }
}
