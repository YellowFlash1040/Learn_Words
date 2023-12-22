using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class EditDictionaryMenu : ControlMenu
    {
        public Button BackFromEditDictionariesMenu_Button;
        public ListBox ChooseDictionaryToEdit_ListBox;
        private TextBox ChooseDictionaryToEdit_TextBox;

        public EditDictionaryMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            ChooseDictionaryToEdit_TextBox = new System.Windows.Forms.TextBox();
            ChooseDictionaryToEdit_ListBox = new System.Windows.Forms.ListBox();
            BackFromEditDictionariesMenu_Button = new System.Windows.Forms.Button();
            Label ChooseDictionaryToEdit_Label = new System.Windows.Forms.Label();
            
            // 
            // ChooseDictionaryToEdit_TextBox
            // 
            ChooseDictionaryToEdit_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ChooseDictionaryToEdit_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseDictionaryToEdit_TextBox.Location = new System.Drawing.Point(247, 71);
            ChooseDictionaryToEdit_TextBox.Name = "ChooseDictionaryToEdit_TextBox";
            ChooseDictionaryToEdit_TextBox.Size = new System.Drawing.Size(290, 38);
            ChooseDictionaryToEdit_TextBox.TabIndex = 20;
            ChooseDictionaryToEdit_TextBox.Visible = false;
            // 
            // ChooseDictionaryToEdit_ListBox
            // 
            ChooseDictionaryToEdit_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseDictionaryToEdit_ListBox.FormattingEnabled = true;
            ChooseDictionaryToEdit_ListBox.ItemHeight = 29;
            ChooseDictionaryToEdit_ListBox.Location = new System.Drawing.Point(211, 151);
            ChooseDictionaryToEdit_ListBox.Name = "ChooseDictionaryToEdit_ListBox";
            ChooseDictionaryToEdit_ListBox.Size = new System.Drawing.Size(378, 207);
            ChooseDictionaryToEdit_ListBox.TabIndex = 21;
            ChooseDictionaryToEdit_ListBox.Visible = false;
            // 
            // BackFromEditDictionariesMenu_Button
            // 
            BackFromEditDictionariesMenu_Button.AutoSize = true;
            BackFromEditDictionariesMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackFromEditDictionariesMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackFromEditDictionariesMenu_Button.Location = new System.Drawing.Point(335, 385);
            BackFromEditDictionariesMenu_Button.Name = "BackFromEditDictionariesMenu_Button";
            BackFromEditDictionariesMenu_Button.Size = new System.Drawing.Size(106, 42);
            BackFromEditDictionariesMenu_Button.TabIndex = 22;
            BackFromEditDictionariesMenu_Button.Text = "Назад";
            BackFromEditDictionariesMenu_Button.UseVisualStyleBackColor = true;
            BackFromEditDictionariesMenu_Button.Visible = false;
            // 
            // ChooseDictionaryToEdit_Label
            // 
            ChooseDictionaryToEdit_Label.AutoSize = true;
            ChooseDictionaryToEdit_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseDictionaryToEdit_Label.Location = new System.Drawing.Point(267, 24);
            ChooseDictionaryToEdit_Label.Name = "ChooseDictionaryToEdit_Label";
            ChooseDictionaryToEdit_Label.Size = new System.Drawing.Size(261, 32);
            ChooseDictionaryToEdit_Label.TabIndex = 23;
            ChooseDictionaryToEdit_Label.Text = "Выберите словарь";
            ChooseDictionaryToEdit_Label.Visible = false;

            Elements.Add(new Element(ChooseDictionaryToEdit_Label));
            Elements.Add(new Element(ChooseDictionaryToEdit_TextBox));
            Elements.Add(new Element(ChooseDictionaryToEdit_ListBox));
            Elements.Add(new Element(BackFromEditDictionariesMenu_Button));

            controlToSelect = ChooseDictionaryToEdit_TextBox;
        }

        public override void Hide()
        {
            base.Hide();
            Clear();
        }

        public override void Clear()
        {
            ChooseDictionaryToEdit_TextBox.Text = "";
            ChooseDictionaryToEdit_ListBox.Items.Clear();
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }
    }
}