using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class MainMenu : ControlMenu
    {
        public Button TestingMenu_Button;
        public Button DictionariesMenu_Button;
        public Button SettingsMenu_Button;

        public MainMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            SettingsMenu_Button = new System.Windows.Forms.Button();
            DictionariesMenu_Button = new System.Windows.Forms.Button();
            TestingMenu_Button = new System.Windows.Forms.Button();
            // 
            // SettingsMenu_Button
            // 
            SettingsMenu_Button.AutoSize = true;
            SettingsMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            SettingsMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            SettingsMenu_Button.Location = new System.Drawing.Point(72, 138);
            SettingsMenu_Button.Name = "SettingsMenu_Button";
            SettingsMenu_Button.Size = new System.Drawing.Size(165, 42);
            SettingsMenu_Button.TabIndex = 5;
            SettingsMenu_Button.Text = "Настройки";
            SettingsMenu_Button.UseVisualStyleBackColor = true;
            SettingsMenu_Button.Visible = false;
            SettingsMenu_Button.AutoSize = false;

            // 
            // DictionariesMenu_Button
            // 
            DictionariesMenu_Button.AutoSize = true;
            DictionariesMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            DictionariesMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            DictionariesMenu_Button.Location = new System.Drawing.Point(87, 90);
            DictionariesMenu_Button.Name = "DictionariesMenu_Button";
            DictionariesMenu_Button.Size = new System.Drawing.Size(139, 42);
            DictionariesMenu_Button.TabIndex = 4;
            DictionariesMenu_Button.Text = "Словари";
            DictionariesMenu_Button.UseVisualStyleBackColor = true;
            DictionariesMenu_Button.Visible = false;
            DictionariesMenu_Button.AutoSize = false;

            // 
            // TestingMenu_Button
            // 
            TestingMenu_Button.AutoSize = true;
            TestingMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            TestingMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            TestingMenu_Button.Location = new System.Drawing.Point(49, 42);
            TestingMenu_Button.Name = "TestingMenu_Button";
            TestingMenu_Button.Size = new System.Drawing.Size(211, 42);
            TestingMenu_Button.TabIndex = 3;
            TestingMenu_Button.Text = "Тестирование";
            TestingMenu_Button.UseVisualStyleBackColor = true;
            TestingMenu_Button.Visible = false;
            TestingMenu_Button.AutoSize = false;

            Elements.Add(new Element(TestingMenu_Button));
            Elements.Add(new Element(DictionariesMenu_Button));
            Elements.Add(new Element(SettingsMenu_Button));

            controlToSelect = TestingMenu_Button;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }
    }
}