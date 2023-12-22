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
    public partial class CreateNewDictionary_Menu : Form
    {
        public CreateNewDictionary_Menu()
        {
            InitializeComponent();
        }

        private void ChoosePlaceWhereNeedToCreateNewDictionary_Button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ChoosePlaceWhereNeedToCreateNewDictionary_TextBox.Text = folderBrowserDialog.SelectedPath;
                ChoosePlaceWhereNeedToCreateNewDictionary_TextBox.SelectionStart = ChoosePlaceWhereNeedToCreateNewDictionary_TextBox.Text.Length;
            }
            folderBrowserDialog.SelectedPath = "";
        }
    }
}
