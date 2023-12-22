using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class ChooseHowYouWouldLikeToEnterAnswersMenu : ControlMenu
    {
        public Button BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button;
        public Button ChooseFromOptions_Button;
        public Button EnterByMySelf_Button;

        public ChooseHowYouWouldLikeToEnterAnswersMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            Label ChooseHowYouWouldLikeToEnterAnswers_Label = new System.Windows.Forms.Label();
            ChooseFromOptions_Button = new System.Windows.Forms.Button();
            EnterByMySelf_Button = new System.Windows.Forms.Button();
            BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button = new System.Windows.Forms.Button();

            // 
            // ChooseHowYouWouldLikeToEnterAnswers_Label
            // 
            ChooseHowYouWouldLikeToEnterAnswers_Label.AutoSize = true;
            ChooseHowYouWouldLikeToEnterAnswers_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseHowYouWouldLikeToEnterAnswers_Label.Location = new System.Drawing.Point(34, 40);
            ChooseHowYouWouldLikeToEnterAnswers_Label.Name = "ChooseHowYouWouldLikeToEnterAnswers_Label";
            ChooseHowYouWouldLikeToEnterAnswers_Label.Size = new System.Drawing.Size(563, 32);
            ChooseHowYouWouldLikeToEnterAnswers_Label.TabIndex = 52;
            ChooseHowYouWouldLikeToEnterAnswers_Label.Text = "Выберите, как вы хотите вводить ответы:";
            ChooseHowYouWouldLikeToEnterAnswers_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            ChooseHowYouWouldLikeToEnterAnswers_Label.Visible = false;
            // 
            // ChooseFromOptions_Button
            // 
            ChooseFromOptions_Button.AutoSize = true;
            ChooseFromOptions_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ChooseFromOptions_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseFromOptions_Button.Location = new System.Drawing.Point(142, 150);
            ChooseFromOptions_Button.Name = "ChooseFromOptions_Button";
            ChooseFromOptions_Button.Size = new System.Drawing.Size(338, 42);
            ChooseFromOptions_Button.TabIndex = 51;
            ChooseFromOptions_Button.Text = "Выбирать из вариантов";
            ChooseFromOptions_Button.UseVisualStyleBackColor = true;
            ChooseFromOptions_Button.Visible = false;
            // 
            // EnterByMySelf_Button
            // 
            EnterByMySelf_Button.AutoSize = true;
            EnterByMySelf_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            EnterByMySelf_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            EnterByMySelf_Button.Location = new System.Drawing.Point(190, 95);
            EnterByMySelf_Button.Name = "EnterByMySelf_Button";
            EnterByMySelf_Button.Size = new System.Drawing.Size(252, 42);
            EnterByMySelf_Button.TabIndex = 50;
            EnterByMySelf_Button.Text = "Вводить вручную";
            EnterByMySelf_Button.UseVisualStyleBackColor = true;
            EnterByMySelf_Button.Visible = false;
            // 
            // BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button
            // 
            BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button.AutoSize = true;
            BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button.Location = new System.Drawing.Point(262, 214);
            BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button.Name = "BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button";
            BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button.Size = new System.Drawing.Size(106, 42);
            BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button.TabIndex = 53;
            BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button.Text = "Назад";
            BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button.UseVisualStyleBackColor = true;
            BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button.Visible = false;

            Elements.Add(new Element(ChooseHowYouWouldLikeToEnterAnswers_Label));
            Elements.Add(new Element(EnterByMySelf_Button));
            Elements.Add(new Element(ChooseFromOptions_Button));
            Elements.Add(new Element(BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button));

            controlToSelect = EnterByMySelf_Button;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }
    }
}
