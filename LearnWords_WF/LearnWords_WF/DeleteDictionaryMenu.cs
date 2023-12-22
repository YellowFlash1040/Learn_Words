using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LearnWords_WF
{
    public partial class DeleteDictionaryMenu : Form
    {
        public DeleteDictionaryMenu()
        {
            InitializeComponent();
            ChooseDictionaryToDelete_ListBox.Items.Add("English");
            ChooseDictionaryToDelete_ListBox.Items.Add("Polish");
            ChooseDictionaryToDelete_ListBox.Items.Add("Ukrainian");
            for (int i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].Visible = true;
            }
        }

        private void ChooseDictionaryToDelete_ListBox_Click(object sender, EventArgs e)
        {
            
        }

        private void ChooseDictionaryToDelete_ListBox_DoubleClick(object sender, EventArgs e)
        {
            ChooseDictionaryToDelete_Label.Text = ChooseDictionaryToDelete_ListBox.SelectedItem.ToString();
        }
    }
}
