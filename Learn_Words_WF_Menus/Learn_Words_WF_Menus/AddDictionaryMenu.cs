using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class AddDictionaryMenu : ControlMenu
    {
        public Button BackFromAddDictionaryMenu_Button;
        public Button AddDictionary_Button;

        private OpenFileDialog openFileDialog;
        private TextBox ChooseFile_TextBox;
        private TextBox ChooseNameForDictionary_TextBox;

        public AddDictionaryMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            Label ChooseNameForDictionary_Label = new System.Windows.Forms.Label();
            Label ChooseFile_Label = new System.Windows.Forms.Label();
            ChooseNameForDictionary_TextBox = new System.Windows.Forms.TextBox();
            BackFromAddDictionaryMenu_Button = new System.Windows.Forms.Button();
            Button ChooseFile_Button = new System.Windows.Forms.Button();
            AddDictionary_Button = new System.Windows.Forms.Button();
            ChooseFile_TextBox = new System.Windows.Forms.TextBox();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();

            // 
            // ChooseNameForDictionary_Label
            // 
            ChooseNameForDictionary_Label.AutoSize = true;
            ChooseNameForDictionary_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseNameForDictionary_Label.Location = new System.Drawing.Point(27, 146);
            ChooseNameForDictionary_Label.Name = "ChooseNameForDictionary_Label";
            ChooseNameForDictionary_Label.Size = new System.Drawing.Size(447, 32);
            ChooseNameForDictionary_Label.TabIndex = 21;
            ChooseNameForDictionary_Label.Text = "Выберите название для словаря";
            ChooseNameForDictionary_Label.Visible = false;
            // 
            // ChooseFile_Label
            // 
            ChooseFile_Label.AutoSize = true;
            ChooseFile_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseFile_Label.Location = new System.Drawing.Point(130, 40);
            ChooseFile_Label.Name = "ChooseFile_Label";
            ChooseFile_Label.Size = new System.Drawing.Size(224, 32);
            ChooseFile_Label.TabIndex = 20;
            ChooseFile_Label.Text = "Выберите файл";
            ChooseFile_Label.Visible = false;
            // 
            // ChooseNameForDictionary_TextBox
            // 
            ChooseNameForDictionary_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseNameForDictionary_TextBox.Location = new System.Drawing.Point(117, 192);
            ChooseNameForDictionary_TextBox.Name = "ChooseNameForDictionary_TextBox";
            ChooseNameForDictionary_TextBox.Size = new System.Drawing.Size(256, 38);
            ChooseNameForDictionary_TextBox.TabIndex = 17;
            ChooseNameForDictionary_TextBox.Visible = false;
            // 
            // BackFromAddDictionaryMenu_Button
            // 
            BackFromAddDictionaryMenu_Button.AutoSize = true;
            BackFromAddDictionaryMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackFromAddDictionaryMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackFromAddDictionaryMenu_Button.Location = new System.Drawing.Point(184, 284);
            BackFromAddDictionaryMenu_Button.Name = "BackFromAddDictionaryMenu_Button";
            BackFromAddDictionaryMenu_Button.Size = new System.Drawing.Size(106, 42);
            BackFromAddDictionaryMenu_Button.TabIndex = 19;
            BackFromAddDictionaryMenu_Button.Text = "Назад";
            BackFromAddDictionaryMenu_Button.UseVisualStyleBackColor = true;
            BackFromAddDictionaryMenu_Button.Visible = false;
            // 
            // ChooseFile_Button
            // 
            ChooseFile_Button.AutoSize = true;
            ChooseFile_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ChooseFile_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseFile_Button.Location = new System.Drawing.Point(250, 84);
            ChooseFile_Button.Name = "ChooseFile_Button";
            ChooseFile_Button.Size = new System.Drawing.Size(104, 42);
            ChooseFile_Button.TabIndex = 15;
            ChooseFile_Button.Text = "Поиск";
            ChooseFile_Button.UseVisualStyleBackColor = true;
            ChooseFile_Button.Visible = false;
            ChooseFile_Button.Click += ChooseFile_Button_Click;
            // 
            // AddDictionary_Button
            // 
            AddDictionary_Button.AutoSize = true;
            AddDictionary_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            AddDictionary_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            AddDictionary_Button.Location = new System.Drawing.Point(167, 236);
            AddDictionary_Button.Name = "AddDictionary_Button";
            AddDictionary_Button.Size = new System.Drawing.Size(153, 42);
            AddDictionary_Button.TabIndex = 18;
            AddDictionary_Button.Text = "Добавить";
            AddDictionary_Button.UseVisualStyleBackColor = true;
            AddDictionary_Button.Visible = false;
            // 
            // ChooseFile_TextBox
            // 
            ChooseFile_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseFile_TextBox.Location = new System.Drawing.Point(134, 88);
            ChooseFile_TextBox.Name = "ChooseFile_TextBox";
            ChooseFile_TextBox.Size = new System.Drawing.Size(100, 38);
            ChooseFile_TextBox.TabIndex = 22;
            ChooseFile_TextBox.Visible = false;

            Elements.Add(new Element(ChooseFile_Label));
            Elements.Add(new Element(new List<Control>() { ChooseFile_TextBox, ChooseFile_Button }));
            Elements.Add(new Element(ChooseNameForDictionary_Label));
            Elements.Add(new Element(ChooseNameForDictionary_TextBox));
            Elements.Add(new Element(AddDictionary_Button));
            Elements.Add(new Element(BackFromAddDictionaryMenu_Button));

            controlToSelect = ChooseFile_Button;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }

        private void ChooseFile_Button_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "(*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ChooseFile_TextBox.Text = openFileDialog.FileName;
            }

            ChooseNameForDictionary_TextBox.Select();
        }

        public override void Clear()
        {
            ClearTextBox(ChooseFile_TextBox);
            ClearTextBox(ChooseNameForDictionary_TextBox);
        }

        private void ClearTextBox(TextBox textBox)
        {
            textBox.Text = "";
        }
    }
}