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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            listBox1.Items.Clear();

            foreach(var item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void searchHistoryBtn_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            listBox1.Items.Clear();
            foreach (var item in items)
            {
                if (item.ToString().Contains(searchHistoryTextBox.Text.Trim()))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void deleteHistoryBtn_Click(object sender, EventArgs e)
        {
            HistoryItem item = (HistoryItem)listBox1.SelectedItem;
            HistoryManager.DeleteItem(item);
            HistoryManagerForm_Load(null, null);
        }

        public void clearHistoryBtn_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            foreach (var item in items)
            {
                HistoryManager.DeleteItem(item);
            }
            HistoryManagerForm_Load(null, null);
        }
    }
}
