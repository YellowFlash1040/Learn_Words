using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class DeleteDictionaryMenu:ControlMenu
    {
        public Button BackFromDeleteDictionariesMenu_Button;
        private TextBox ChooseDictionaryToDelete_TextBox;
        public ListBox ChooseDictionaryToDelete_ListBox;

        public DeleteDictionaryMenu(Form form) : base(form) 
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            ChooseDictionaryToDelete_TextBox = new System.Windows.Forms.TextBox();
            ChooseDictionaryToDelete_ListBox = new System.Windows.Forms.ListBox();
            BackFromDeleteDictionariesMenu_Button = new System.Windows.Forms.Button();
            Label ChooseDictionaryToDelete_Label = new System.Windows.Forms.Label();
            // 
            // ChooseDictionaryToDelete_TextBox
            // 
            ChooseDictionaryToDelete_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ChooseDictionaryToDelete_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseDictionaryToDelete_TextBox.Location = new System.Drawing.Point(69, 66);
            ChooseDictionaryToDelete_TextBox.Name = "ChooseDictionaryToDelete_TextBox";
            ChooseDictionaryToDelete_TextBox.Size = new System.Drawing.Size(290, 38);
            ChooseDictionaryToDelete_TextBox.TabIndex = 15;
            ChooseDictionaryToDelete_TextBox.Visible = false;
            // 
            // ChooseDictionaryToDelete_ListBox
            // 
            ChooseDictionaryToDelete_ListBox.FormattingEnabled = true;
            ChooseDictionaryToDelete_ListBox.ItemHeight = 16;
            ChooseDictionaryToDelete_ListBox.Location = new System.Drawing.Point(33, 146);
            ChooseDictionaryToDelete_ListBox.Name = "ChooseDictionaryToDelete_ListBox";
            ChooseDictionaryToDelete_ListBox.Size = new System.Drawing.Size(378, 212);
            ChooseDictionaryToDelete_ListBox.TabIndex = 16;
            ChooseDictionaryToDelete_ListBox.Visible = false;
            ChooseDictionaryToDelete_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // BackFromDeleteDictionariesMenu_Button
            // 
            BackFromDeleteDictionariesMenu_Button.AutoSize = true;
            BackFromDeleteDictionariesMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackFromDeleteDictionariesMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackFromDeleteDictionariesMenu_Button.Location = new System.Drawing.Point(157, 380);
            BackFromDeleteDictionariesMenu_Button.Name = "BackFromDeleteDictionariesMenu_Button";
            BackFromDeleteDictionariesMenu_Button.Size = new System.Drawing.Size(106, 42);
            BackFromDeleteDictionariesMenu_Button.TabIndex = 17;
            BackFromDeleteDictionariesMenu_Button.Text = "Назад";
            BackFromDeleteDictionariesMenu_Button.UseVisualStyleBackColor = true;
            BackFromDeleteDictionariesMenu_Button.Visible = false;
            // 
            // ChooseDictionaryToDelete_Label
            // 
            ChooseDictionaryToDelete_Label.AutoSize = true;
            ChooseDictionaryToDelete_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseDictionaryToDelete_Label.Location = new System.Drawing.Point(89, 19);
            ChooseDictionaryToDelete_Label.Name = "ChooseDictionaryToDelete_Label";
            ChooseDictionaryToDelete_Label.Size = new System.Drawing.Size(261, 32);
            ChooseDictionaryToDelete_Label.TabIndex = 19;
            ChooseDictionaryToDelete_Label.Text = "Выберите словарь";
            ChooseDictionaryToDelete_Label.Visible = false;

            Elements.Add(new Element(ChooseDictionaryToDelete_Label));
            Elements.Add(new Element(ChooseDictionaryToDelete_TextBox));
            Elements.Add(new Element(ChooseDictionaryToDelete_ListBox));
            Elements.Add(new Element(BackFromDeleteDictionariesMenu_Button));

            controlToSelect = ChooseDictionaryToDelete_TextBox;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }

        public override void Clear()
        {
            ChooseDictionaryToDelete_TextBox.Text = "";
            ChooseDictionaryToDelete_ListBox.Items.Clear();
        }
    }
}