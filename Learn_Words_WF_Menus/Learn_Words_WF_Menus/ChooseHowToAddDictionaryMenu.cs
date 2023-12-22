using System.Collections.Generic;
using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class ChooseHowToAddDictionaryMenu : ControlMenu
    {
        public Button AddDictionaryMenu_Button;
        public Button CreateNewDictionaryMenu_Button;
        public Button BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button;

        public ChooseHowToAddDictionaryMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button = new System.Windows.Forms.Button();
            Label ChooseHowYouWouldLikeToAddDictionary_Label = new System.Windows.Forms.Label();
            AddDictionaryMenu_Button = new System.Windows.Forms.Button();
            CreateNewDictionaryMenu_Button = new System.Windows.Forms.Button();

            // 
            // BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button
            // 
            BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button.AutoSize = true;
            BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button.Location = new System.Drawing.Point(340, 290);
            BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button.Name = "BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button";
            BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button.Size = new System.Drawing.Size(106, 42);
            BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button.TabIndex = 57;
            BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button.Text = "Назад";
            BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button.UseVisualStyleBackColor = true;
            BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button.Visible = false;
            // 
            // ChooseHowYouWouldLikeToAddDictionary_Label
            // 
            ChooseHowYouWouldLikeToAddDictionary_Label.AutoSize = true;
            ChooseHowYouWouldLikeToAddDictionary_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseHowYouWouldLikeToAddDictionary_Label.Location = new System.Drawing.Point(30, 109);
            ChooseHowYouWouldLikeToAddDictionary_Label.Name = "ChooseHowYouWouldLikeToAddDictionary_Label";
            ChooseHowYouWouldLikeToAddDictionary_Label.Size = new System.Drawing.Size(744, 32);
            ChooseHowYouWouldLikeToAddDictionary_Label.TabIndex = 56;
            ChooseHowYouWouldLikeToAddDictionary_Label.Text = "Выберите, каким образом вы хотите добавить словарь";
            ChooseHowYouWouldLikeToAddDictionary_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            ChooseHowYouWouldLikeToAddDictionary_Label.Visible = false;
            // 
            // AddDictionaryMenu_Button
            // 
            AddDictionaryMenu_Button.AutoSize = true;
            AddDictionaryMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            AddDictionaryMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            AddDictionaryMenu_Button.Location = new System.Drawing.Point(206, 220);
            AddDictionaryMenu_Button.Name = "AddDictionaryMenu_Button";
            AddDictionaryMenu_Button.Size = new System.Drawing.Size(359, 42);
            AddDictionaryMenu_Button.TabIndex = 55;
            AddDictionaryMenu_Button.Text = "Добавить существующий";
            AddDictionaryMenu_Button.UseVisualStyleBackColor = true;
            AddDictionaryMenu_Button.Visible = false;
            // 
            // CreateNewDictionaryMenu_Button
            // 
            CreateNewDictionaryMenu_Button.AutoSize = true;
            CreateNewDictionaryMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CreateNewDictionaryMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            CreateNewDictionaryMenu_Button.Location = new System.Drawing.Point(282, 162);
            CreateNewDictionaryMenu_Button.Name = "CreateNewDictionaryMenu_Button";
            CreateNewDictionaryMenu_Button.Size = new System.Drawing.Size(224, 42);
            CreateNewDictionaryMenu_Button.TabIndex = 54;
            CreateNewDictionaryMenu_Button.Text = "Создать новый";
            CreateNewDictionaryMenu_Button.UseVisualStyleBackColor = true;
            CreateNewDictionaryMenu_Button.Visible = false;

            Elements.Add(new Element(ChooseHowYouWouldLikeToAddDictionary_Label));
            Elements.Add(new Element(CreateNewDictionaryMenu_Button));
            Elements.Add(new Element(AddDictionaryMenu_Button));
            Elements.Add(new Element(BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button));

            controlToSelect = CreateNewDictionaryMenu_Button;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }
    }
}