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
    public partial class AddDictionaryMenu : Form
    {
        public AddDictionaryMenu()
        {
            InitializeComponent();
        }

        private void AddDictionaryMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackFromAddDictionaryMenu_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu addDictionaryMenu = new MainMenu();

            SetCurrentCenterPointOfForm();
            addDictionaryMenu.Location = FindLocatinOfNewForm();
            addDictionaryMenu.Show();
        }

        private Point currentCenterPointOfForm;

        private void SetCurrentCenterPointOfForm()
        {
            currentCenterPointOfForm = new Point(this.Left + this.Width / 2, this.Top + this.Height / 2);
        }

        private Point FindLocatinOfNewForm()
        {
            int newLeft = currentCenterPointOfForm.X - this.Width / 2;
            int newTop = currentCenterPointOfForm.Y - this.Height / 2;
            return new Point(newLeft, newTop);
        }
    }
}
