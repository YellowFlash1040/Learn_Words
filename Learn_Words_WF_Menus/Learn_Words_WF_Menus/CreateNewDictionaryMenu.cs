using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Learn_Words_WF_Menus
{
    public class CreateNewDictionaryMenu : ControlMenu
    {
        FolderBrowserDialog folderBrowserDialog;
        public TextBox ChoosePlaceWhereNeedToCreateNewDictionary_TextBox;
        public Button CreateNewDictionary_Button;
        public TextBox ChooseNameForTheNewDictionary_TextBox;
        public TextBox WriteNameOfTheNewDictionaryTXTFile_TextBox;
        public Button BackFromCreateDictionaryMenu_Button;

        public CreateNewDictionaryMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            CreateNewDictionary_Button = new System.Windows.Forms.Button();
            Label ChooseNameForTheNewDictionary_Label = new System.Windows.Forms.Label();
            Label ChoosePlaceWhereNeedToCreateNewDictionary_Label = new System.Windows.Forms.Label();
            Button ChoosePlaceWhereNeedToCreateNewDictionary_Button = new System.Windows.Forms.Button();
            ChoosePlaceWhereNeedToCreateNewDictionary_TextBox = new System.Windows.Forms.TextBox();
            ChooseNameForTheNewDictionary_TextBox = new System.Windows.Forms.TextBox();
            folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            Label WriteNameOfTheNewDictionaryTXTFile_Label = new System.Windows.Forms.Label();
            WriteNameOfTheNewDictionaryTXTFile_TextBox = new System.Windows.Forms.TextBox();
            BackFromCreateDictionaryMenu_Button = new Button();

            // 
            // CreateNewDictionary_Button
            // 
            CreateNewDictionary_Button.AutoSize = true;
            CreateNewDictionary_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CreateNewDictionary_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            CreateNewDictionary_Button.Location = new System.Drawing.Point(336, 464);
            CreateNewDictionary_Button.Name = "CreateNewDictionary_Button";
            CreateNewDictionary_Button.Size = new System.Drawing.Size(134, 42);
            CreateNewDictionary_Button.TabIndex = 55;
            CreateNewDictionary_Button.Text = "Создать";
            CreateNewDictionary_Button.UseVisualStyleBackColor = true;
            CreateNewDictionary_Button.Visible = false;
            CreateNewDictionary_Button.Enabled = false;
            // 
            // ChooseNameForTheNewDictionary_Label
            // 
            ChooseNameForTheNewDictionary_Label.AutoSize = true;
            ChooseNameForTheNewDictionary_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseNameForTheNewDictionary_Label.Location = new System.Drawing.Point(150, 327);
            ChooseNameForTheNewDictionary_Label.Name = "ChooseNameForTheNewDictionary_Label";
            ChooseNameForTheNewDictionary_Label.Size = new System.Drawing.Size(517, 64);
            ChooseNameForTheNewDictionary_Label.TabIndex = 57;
            ChooseNameForTheNewDictionary_Label.Text = "Напишите под каким именем словарь\r\nбудет отображаться в программе";
            ChooseNameForTheNewDictionary_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ChooseNameForTheNewDictionary_Label.Visible = false;
            // 
            // ChoosePlaceWhereNeedToCreateNewDictionary_Label
            // 
            ChoosePlaceWhereNeedToCreateNewDictionary_Label.AutoSize = true;
            ChoosePlaceWhereNeedToCreateNewDictionary_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChoosePlaceWhereNeedToCreateNewDictionary_Label.Location = new System.Drawing.Point(109, 47);
            ChoosePlaceWhereNeedToCreateNewDictionary_Label.Name = "ChoosePlaceWhereNeedToCreateNewDictionary_Label";
            ChoosePlaceWhereNeedToCreateNewDictionary_Label.Size = new System.Drawing.Size(597, 32);
            ChoosePlaceWhereNeedToCreateNewDictionary_Label.TabIndex = 60;
            ChoosePlaceWhereNeedToCreateNewDictionary_Label.Text = "Выберите место где нужно создать словарь";
            ChoosePlaceWhereNeedToCreateNewDictionary_Label.Visible = false;
            // 
            // ChoosePlaceWhereNeedToCreateNewDictionary_Button
            // 
            ChoosePlaceWhereNeedToCreateNewDictionary_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChoosePlaceWhereNeedToCreateNewDictionary_Button.Location = new System.Drawing.Point(539, 101);
            ChoosePlaceWhereNeedToCreateNewDictionary_Button.Name = "ChoosePlaceWhereNeedToCreateNewDictionary_Button";
            ChoosePlaceWhereNeedToCreateNewDictionary_Button.Size = new System.Drawing.Size(128, 38);
            ChoosePlaceWhereNeedToCreateNewDictionary_Button.TabIndex = 1;
            ChoosePlaceWhereNeedToCreateNewDictionary_Button.Text = "Найти";
            ChoosePlaceWhereNeedToCreateNewDictionary_Button.UseVisualStyleBackColor = true;
            ChoosePlaceWhereNeedToCreateNewDictionary_Button.Visible = false;
            ChoosePlaceWhereNeedToCreateNewDictionary_Button.Click += new System.EventHandler(ChoosePlaceWhereNeedToCreateNewDictionary_Button_Click);
            // 
            // ChoosePlaceWhereNeedToCreateNewDictionary_TextBox
            // 
            ChoosePlaceWhereNeedToCreateNewDictionary_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChoosePlaceWhereNeedToCreateNewDictionary_TextBox.Location = new System.Drawing.Point(148, 100);
            ChoosePlaceWhereNeedToCreateNewDictionary_TextBox.Name = "ChoosePlaceWhereNeedToCreateNewDictionary_TextBox";
            ChoosePlaceWhereNeedToCreateNewDictionary_TextBox.Size = new System.Drawing.Size(349, 38);
            ChoosePlaceWhereNeedToCreateNewDictionary_TextBox.TabIndex = 0;
            ChoosePlaceWhereNeedToCreateNewDictionary_TextBox.Visible = false;
            // 
            // ChooseNameForTheNewDictionary_TextBox
            // 
            ChooseNameForTheNewDictionary_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseNameForTheNewDictionary_TextBox.Location = new System.Drawing.Point(243, 404);
            ChooseNameForTheNewDictionary_TextBox.Name = "ChooseNameForTheNewDictionary_TextBox";
            ChooseNameForTheNewDictionary_TextBox.Size = new System.Drawing.Size(349, 38);
            ChooseNameForTheNewDictionary_TextBox.TabIndex = 3;
            ChooseNameForTheNewDictionary_TextBox.Visible = false;
            // 
            // WriteNameOfTheNewDictionaryTXTFile_Label
            // 
            WriteNameOfTheNewDictionaryTXTFile_Label.AutoSize = true;
            WriteNameOfTheNewDictionaryTXTFile_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            WriteNameOfTheNewDictionaryTXTFile_Label.Location = new System.Drawing.Point(182, 165);
            WriteNameOfTheNewDictionaryTXTFile_Label.Name = "WriteNameOfTheNewDictionaryTXTFile_Label";
            WriteNameOfTheNewDictionaryTXTFile_Label.Size = new System.Drawing.Size(443, 64);
            WriteNameOfTheNewDictionaryTXTFile_Label.TabIndex = 6;
            WriteNameOfTheNewDictionaryTXTFile_Label.Text = "Напишите как будет называться\r\nтекстовый файл";
            WriteNameOfTheNewDictionaryTXTFile_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            WriteNameOfTheNewDictionaryTXTFile_Label.Visible = false;
            // 
            // WriteNameOfTheNewDictionaryTXTFile_TextBox
            // 
            WriteNameOfTheNewDictionaryTXTFile_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            WriteNameOfTheNewDictionaryTXTFile_TextBox.Location = new System.Drawing.Point(233, 249);
            WriteNameOfTheNewDictionaryTXTFile_TextBox.Name = "WriteNameOfTheNewDictionaryTXTFile_TextBox";
            WriteNameOfTheNewDictionaryTXTFile_TextBox.Size = new System.Drawing.Size(349, 38);
            WriteNameOfTheNewDictionaryTXTFile_TextBox.TabIndex = 2;
            WriteNameOfTheNewDictionaryTXTFile_TextBox.Visible = false;
            // 
            // BackFromCreateDictionaryMenu_Button
            // 
            this.BackFromCreateDictionaryMenu_Button.AutoSize = true;
            this.BackFromCreateDictionaryMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackFromCreateDictionaryMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackFromCreateDictionaryMenu_Button.Location = new System.Drawing.Point(353, 542);
            this.BackFromCreateDictionaryMenu_Button.Name = "BackFromCreateDictionaryMenu_Button";
            this.BackFromCreateDictionaryMenu_Button.Size = new System.Drawing.Size(106, 42);
            this.BackFromCreateDictionaryMenu_Button.TabIndex = 65;
            this.BackFromCreateDictionaryMenu_Button.Text = "Назад";
            this.BackFromCreateDictionaryMenu_Button.UseVisualStyleBackColor = true;
            this.BackFromCreateDictionaryMenu_Button.Visible = false;

            Elements.Add(new Element(ChoosePlaceWhereNeedToCreateNewDictionary_Label));
            Elements.Add(new Element(new List<Control>() { ChoosePlaceWhereNeedToCreateNewDictionary_TextBox, ChoosePlaceWhereNeedToCreateNewDictionary_Button }));
            Elements.Add(new Element(WriteNameOfTheNewDictionaryTXTFile_Label));
            Elements.Add(new Element(WriteNameOfTheNewDictionaryTXTFile_TextBox));
            Elements.Add(new Element(ChooseNameForTheNewDictionary_Label));
            Elements.Add(new Element(ChooseNameForTheNewDictionary_TextBox));
            Elements.Add(new Element(CreateNewDictionary_Button));
            Elements.Add(new Element(BackFromCreateDictionaryMenu_Button));

            controlToSelect = ChoosePlaceWhereNeedToCreateNewDictionary_Button;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }

        public override void Hide()
        {
            base.Hide();
            ChoosePlaceWhereNeedToCreateNewDictionary_TextBox.Text = "";
            ChooseNameForTheNewDictionary_TextBox.Text = "";
            WriteNameOfTheNewDictionaryTXTFile_TextBox.Text = "";
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