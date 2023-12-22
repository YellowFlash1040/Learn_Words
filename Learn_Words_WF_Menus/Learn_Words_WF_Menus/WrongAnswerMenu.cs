using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class WrongAnswerMenu : ControlMenu
    {
        public Button Continue_Button;

        public WrongAnswerMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            Label GeneratedWord_Label = new System.Windows.Forms.Label();
            Label WordLabel_Label = new System.Windows.Forms.Label();
            Label Answer_Label = new System.Windows.Forms.Label();
            Label UsersInput_Label = new System.Windows.Forms.Label();
            Label RightAnswerLabel_Label = new System.Windows.Forms.Label();
            Label YourInputLabel_Label = new System.Windows.Forms.Label();
            Continue_Button = new System.Windows.Forms.Button();
            Label WrongLabel_Label = new System.Windows.Forms.Label();
            
            // 
            // GeneratedWord_Label
            // 
            GeneratedWord_Label.AutoSize = true;
            GeneratedWord_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            GeneratedWord_Label.Location = new System.Drawing.Point(47, 154);
            GeneratedWord_Label.Name = "GeneratedWord_Label";
            GeneratedWord_Label.Size = new System.Drawing.Size(330, 32);
            GeneratedWord_Label.TabIndex = 54;
            GeneratedWord_Label.Text = "сгенерированное слово";
            GeneratedWord_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            GeneratedWord_Label.Visible = false;
            // 
            // WordLabel_Label
            // 
            WordLabel_Label.AutoSize = true;
            WordLabel_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            WordLabel_Label.Location = new System.Drawing.Point(145, 100);
            WordLabel_Label.Name = "WordLabel_Label";
            WordLabel_Label.Size = new System.Drawing.Size(105, 32);
            WordLabel_Label.TabIndex = 53;
            WordLabel_Label.Text = "Слово:";
            WordLabel_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            WordLabel_Label.Visible = false;
            // 
            // Answer_Label
            // 
            Answer_Label.AutoSize = true;
            Answer_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Answer_Label.Location = new System.Drawing.Point(163, 376);
            Answer_Label.Name = "Answer_Label";
            Answer_Label.Size = new System.Drawing.Size(87, 32);
            Answer_Label.TabIndex = 52;
            Answer_Label.Text = "ответ";
            Answer_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Answer_Label.Visible = false;
            // 
            // UsersInput_Label
            // 
            UsersInput_Label.AutoSize = true;
            UsersInput_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            UsersInput_Label.Location = new System.Drawing.Point(71, 272);
            UsersInput_Label.Name = "UsersInput_Label";
            UsersInput_Label.Size = new System.Drawing.Size(278, 32);
            UsersInput_Label.TabIndex = 51;
            UsersInput_Label.Text = "ответ пользователя";
            UsersInput_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            UsersInput_Label.Visible = false;
            // 
            // RightAnswerLabel_Label
            // 
            RightAnswerLabel_Label.AutoSize = true;
            RightAnswerLabel_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            RightAnswerLabel_Label.Location = new System.Drawing.Point(81, 328);
            RightAnswerLabel_Label.Name = "RightAnswerLabel_Label";
            RightAnswerLabel_Label.Size = new System.Drawing.Size(268, 32);
            RightAnswerLabel_Label.TabIndex = 50;
            RightAnswerLabel_Label.Text = "Правильный ответ:";
            RightAnswerLabel_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            RightAnswerLabel_Label.Visible = false;
            // 
            // YourInputLabel_Label
            // 
            YourInputLabel_Label.AutoSize = true;
            YourInputLabel_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            YourInputLabel_Label.Location = new System.Drawing.Point(132, 218);
            YourInputLabel_Label.Name = "YourInputLabel_Label";
            YourInputLabel_Label.Size = new System.Drawing.Size(148, 32);
            YourInputLabel_Label.TabIndex = 49;
            YourInputLabel_Label.Text = "Ваш ввод:";
            YourInputLabel_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            YourInputLabel_Label.Visible = false;
            // 
            // Continue_Button
            // 
            Continue_Button.AutoSize = true;
            Continue_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Continue_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Continue_Button.Location = new System.Drawing.Point(108, 432);
            Continue_Button.Name = "Continue_Button";
            Continue_Button.Size = new System.Drawing.Size(188, 42);
            Continue_Button.TabIndex = 48;
            Continue_Button.Text = "Продолжить";
            Continue_Button.UseVisualStyleBackColor = true;
            Continue_Button.Visible = false;
            // 
            // WrongLabel_Label
            // 
            WrongLabel_Label.AutoSize = true;
            WrongLabel_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            WrongLabel_Label.Location = new System.Drawing.Point(102, 43);
            WrongLabel_Label.Name = "WrongLabel_Label";
            WrongLabel_Label.Size = new System.Drawing.Size(221, 36);
            WrongLabel_Label.TabIndex = 47;
            WrongLabel_Label.Text = "Неправильно";
            WrongLabel_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            WrongLabel_Label.Visible = false;

            Elements.Add(new Element(WrongLabel_Label));
            Elements.Add(new Element(WordLabel_Label));
            Elements.Add(new Element(GeneratedWord_Label));
            Elements.Add(new Element(YourInputLabel_Label));
            Elements.Add(new Element(UsersInput_Label));
            Elements.Add(new Element(RightAnswerLabel_Label));
            Elements.Add(new Element(Answer_Label));
            Elements.Add(new Element(Continue_Button));

            controlToSelect = Continue_Button;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }
    }
}