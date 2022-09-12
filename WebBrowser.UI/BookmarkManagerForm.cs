using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            listBox1.Items.Clear();

            foreach(var item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            listBox1.Items.Clear();
            foreach (var item in items) { 
            if (item.ToString().Contains(searchTerm.Text.Trim()))
            {
                listBox1.Items.Add(item);
            }
        }

        }

        private void deleteBookmarkBtn_Click(object sender, EventArgs e)
        {
           BookmarkItem item = (BookmarkItem)listBox1.SelectedItem;
            BookmarkManager.DeleteItem(item);
           BookmarkManagerForm_Load(null, null);
        }
    }
}
