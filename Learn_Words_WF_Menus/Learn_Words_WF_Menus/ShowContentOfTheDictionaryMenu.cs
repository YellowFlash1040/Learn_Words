using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class ShowContentOfTheDictionaryMenu : ControlMenu
    {
        public ListBox DictionaryContent_ListBox;
        public Label DictionaryName_Label;
        public Button BackFromShowContentOfTheDictionary_Button;

        public ShowContentOfTheDictionaryMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            DictionaryName_Label = new System.Windows.Forms.Label();
            BackFromShowContentOfTheDictionary_Button = new System.Windows.Forms.Button();
            DictionaryContent_ListBox = new System.Windows.Forms.ListBox();
            // 
            // DictionaryName_Label
            // 
            DictionaryName_Label.AutoSize = true;
            DictionaryName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            DictionaryName_Label.Location = new System.Drawing.Point(243, 35);
            DictionaryName_Label.Name = "DictionaryName_Label";
            DictionaryName_Label.Size = new System.Drawing.Size(298, 36);
            DictionaryName_Label.TabIndex = 39;
            DictionaryName_Label.Text = "Название словаря";
            DictionaryName_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            DictionaryName_Label.Visible = false;
            // 
            // BackFromShowContentOfTheDictionary_Button
            // 
            BackFromShowContentOfTheDictionary_Button.AutoSize = true;
            BackFromShowContentOfTheDictionary_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackFromShowContentOfTheDictionary_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackFromShowContentOfTheDictionary_Button.Location = new System.Drawing.Point(333, 386);
            BackFromShowContentOfTheDictionary_Button.Name = "BackFromShowContentOfTheDictionary_Button";
            BackFromShowContentOfTheDictionary_Button.Size = new System.Drawing.Size(106, 42);
            BackFromShowContentOfTheDictionary_Button.TabIndex = 40;
            BackFromShowContentOfTheDictionary_Button.Text = "Назад";
            BackFromShowContentOfTheDictionary_Button.UseVisualStyleBackColor = true;
            BackFromShowContentOfTheDictionary_Button.Visible = false;
            // 
            // DictionaryContent_ListBox
            // 
            DictionaryContent_ListBox.BackColor = System.Drawing.SystemColors.Control;
            DictionaryContent_ListBox.FormattingEnabled = true;
            DictionaryContent_ListBox.ItemHeight = 16;
            DictionaryContent_ListBox.Location = new System.Drawing.Point(127, 95);
            DictionaryContent_ListBox.Name = "DictionaryContent_ListBox";
            DictionaryContent_ListBox.Size = new System.Drawing.Size(524, 276);
            DictionaryContent_ListBox.TabIndex = 41;
            DictionaryContent_ListBox.Visible = false;
            DictionaryContent_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            Elements.Add(new Element(DictionaryName_Label));
            Elements.Add(new Element(DictionaryContent_ListBox));
            Elements.Add(new Element(BackFromShowContentOfTheDictionary_Button));

            controlToSelect = BackFromShowContentOfTheDictionary_Button;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }

        public override void Hide()
        {
            base.Hide();
            Clear();
        }

        public override void Clear()
        {
            DictionaryContent_ListBox.Items.Clear();
        }
    }
}