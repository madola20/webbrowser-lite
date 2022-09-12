using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Madeline Laurance\nStudent ID: DML0042\nUse this web browser to search the world wide web!\nTo manage your tabs, click File." +
                " To Manage your bookmarks and browser history, click Tools.");
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newTabToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TabBrowser myTB = new TabBrowser();
            myTB.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();

            myTabPage.Controls.Add(myTB);
            tabControl1.TabPages.Add(myTabPage);
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HistoryManagerForm();
            form.Show();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new BookmarkManagerForm();
            form.Show();
        }

        private void Browser_Load(object sender, EventArgs e)
        {
          
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManagerForm bop = new HistoryManagerForm();
            bop.clearHistoryBtn_Click(null, null);
        }
    }
}
