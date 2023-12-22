using System.Windows.Forms;
using System;

namespace Learn_Words_WF_Menus
{
    public class CheckingWordMenu:ControlMenu
    {
        public TextBox UsersInput_TextBox;
        public Button CheckUsersInput_Button;
        public Button BackFromCheckingWordMenu_Button;

        public CheckingWordMenu(Form form):base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            BackFromCheckingWordMenu_Button = new System.Windows.Forms.Button();
            CheckUsersInput_Button = new System.Windows.Forms.Button();
            Label WordToTranslate_Label = new System.Windows.Forms.Label();
            UsersInput_TextBox = new System.Windows.Forms.TextBox();
            
            // 
            // BackFromCheckingWordMenu_Button
            // 
            BackFromCheckingWordMenu_Button.AutoSize = true;
            BackFromCheckingWordMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackFromCheckingWordMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackFromCheckingWordMenu_Button.Location = new System.Drawing.Point(114, 188);
            BackFromCheckingWordMenu_Button.Name = "BackFromCheckingWordMenu_Button";
            BackFromCheckingWordMenu_Button.Size = new System.Drawing.Size(106, 42);
            BackFromCheckingWordMenu_Button.TabIndex = 38;
            BackFromCheckingWordMenu_Button.Text = "Назад";
            BackFromCheckingWordMenu_Button.UseVisualStyleBackColor = true;
            BackFromCheckingWordMenu_Button.Visible = false;
            // 
            // CheckUsersInput_Button
            // 
            CheckUsersInput_Button.AutoSize = true;
            CheckUsersInput_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CheckUsersInput_Button.Enabled = false;
            CheckUsersInput_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            CheckUsersInput_Button.Location = new System.Drawing.Point(88, 131);
            CheckUsersInput_Button.Name = "CheckUsersInput_Button";
            CheckUsersInput_Button.Size = new System.Drawing.Size(167, 42);
            CheckUsersInput_Button.TabIndex = 37;
            CheckUsersInput_Button.Text = "Проверить";
            CheckUsersInput_Button.UseVisualStyleBackColor = true;
            CheckUsersInput_Button.Visible = false;
            // 
            // WordToTranslate_Label
            // 
            WordToTranslate_Label.AutoSize = true;
            WordToTranslate_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            WordToTranslate_Label.Location = new System.Drawing.Point(32, 42);
            WordToTranslate_Label.Name = "WordToTranslate_Label";
            WordToTranslate_Label.Size = new System.Drawing.Size(285, 32);
            WordToTranslate_Label.TabIndex = 36;
            WordToTranslate_Label.Text = "Слово для перевода";
            WordToTranslate_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            WordToTranslate_Label.Visible = false;
            // 
            // UsersInput_TextBox
            // 
            UsersInput_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            UsersInput_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            UsersInput_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            UsersInput_TextBox.Location = new System.Drawing.Point(38, 87);
            UsersInput_TextBox.Name = "UsersInput_TextBox";
            UsersInput_TextBox.Size = new System.Drawing.Size(264, 38);
            UsersInput_TextBox.TabIndex = 35;
            UsersInput_TextBox.Visible = false;
            UsersInput_TextBox.TextChanged += UsersInput_TextBox_TextChanged;

            Elements.Add(new Element(WordToTranslate_Label));
            Elements.Add(new Element(UsersInput_TextBox));
            Elements.Add(new Element(CheckUsersInput_Button));
            Elements.Add(new Element(BackFromCheckingWordMenu_Button));

            controlToSelect = UsersInput_TextBox;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }

        private void UsersInput_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (UsersInput_TextBox.Text == "")
            {
                CheckUsersInput_Button.Enabled = false;
            }
            else
            {
                CheckUsersInput_Button.Enabled = true;
            }
        }

        public override void Clear()
        {
            UsersInput_TextBox.Text = "";
            CheckUsersInput_Button.Enabled = false;
        }
    }
}