using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class ShowDictionariesListMenu : ControlMenu
    {
        public TextBox EnterDictionaryName_TextBox;
        public ListBox EnterDictionaryName_ListBox;
        public Button BackFromShowAddedDictionariesMenu_Button;

        public ShowDictionariesListMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            EnterDictionaryName_TextBox = new System.Windows.Forms.TextBox();
            EnterDictionaryName_ListBox = new System.Windows.Forms.ListBox();
            BackFromShowAddedDictionariesMenu_Button = new System.Windows.Forms.Button();
            Label EnterDictionaryName_Label = new System.Windows.Forms.Label();
            
            // 
            // EnterDictionaryName_TextBox
            // 
            EnterDictionaryName_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            EnterDictionaryName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            EnterDictionaryName_TextBox.Location = new System.Drawing.Point(57, 67);
            EnterDictionaryName_TextBox.Name = "EnterDictionaryName_TextBox";
            EnterDictionaryName_TextBox.Size = new System.Drawing.Size(290, 38);
            EnterDictionaryName_TextBox.TabIndex = 23;
            EnterDictionaryName_TextBox.Visible = false;
            // 
            // EnterDictionaryName_ListBox
            // 
            EnterDictionaryName_ListBox.FormattingEnabled = true;
            EnterDictionaryName_ListBox.ItemHeight = 16;
            EnterDictionaryName_ListBox.Location = new System.Drawing.Point(21, 147);
            EnterDictionaryName_ListBox.Name = "EnterDictionaryName_ListBox";
            EnterDictionaryName_ListBox.Size = new System.Drawing.Size(378, 212);
            EnterDictionaryName_ListBox.TabIndex = 24;
            EnterDictionaryName_ListBox.Visible = false;
            EnterDictionaryName_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // BackFromShowAddedDictionariesMenu_Button
            // 
            BackFromShowAddedDictionariesMenu_Button.AutoSize = true;
            BackFromShowAddedDictionariesMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackFromShowAddedDictionariesMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackFromShowAddedDictionariesMenu_Button.Location = new System.Drawing.Point(149, 380);
            BackFromShowAddedDictionariesMenu_Button.Name = "BackFromShowAddedDictionariesMenu_Button";
            BackFromShowAddedDictionariesMenu_Button.Size = new System.Drawing.Size(106, 42);
            BackFromShowAddedDictionariesMenu_Button.TabIndex = 25;
            BackFromShowAddedDictionariesMenu_Button.Text = "Назад";
            BackFromShowAddedDictionariesMenu_Button.UseVisualStyleBackColor = true;
            BackFromShowAddedDictionariesMenu_Button.Visible = false;
            // 
            // EnterDictionaryName_Label
            // 
            EnterDictionaryName_Label.AutoSize = true;
            EnterDictionaryName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            EnterDictionaryName_Label.Location = new System.Drawing.Point(51, 19);
            EnterDictionaryName_Label.Name = "EnterDictionaryName_Label";
            EnterDictionaryName_Label.Size = new System.Drawing.Size(298, 32);
            EnterDictionaryName_Label.TabIndex = 26;
            EnterDictionaryName_Label.Text = "Введите имя словаря";
            EnterDictionaryName_Label.Visible = false;

            Elements.Add(new Element(EnterDictionaryName_Label));
            Elements.Add(new Element(EnterDictionaryName_TextBox));
            Elements.Add(new Element(EnterDictionaryName_ListBox));
            Elements.Add(new Element(BackFromShowAddedDictionariesMenu_Button));

            controlToSelect = EnterDictionaryName_TextBox;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }

        public override void Clear()
        {
            EnterDictionaryName_TextBox.Text = "";
            EnterDictionaryName_ListBox.Items.Clear();
        }
    }
}