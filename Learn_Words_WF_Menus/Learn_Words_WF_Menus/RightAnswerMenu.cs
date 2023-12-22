using System;
using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class RightAnswerMenu : ControlMenu
    {
        public Button Continue_Button;

        public RightAnswerMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            Continue_Button = new System.Windows.Forms.Button();
            Label RightLabel_Label = new System.Windows.Forms.Label();
            
            // 
            // Continue_Button
            // 
            Continue_Button.AutoSize = true;
            Continue_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Continue_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Continue_Button.Location = new System.Drawing.Point(49, 99);
            Continue_Button.Name = "Continue_Button";
            Continue_Button.Size = new System.Drawing.Size(188, 42);
            Continue_Button.TabIndex = 38;
            Continue_Button.Text = "Продолжить";
            Continue_Button.UseVisualStyleBackColor = true;
            Continue_Button.Visible = false;
            // 
            // RightLabel_Label
            // 
            RightLabel_Label.AutoSize = true;
            RightLabel_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            RightLabel_Label.Location = new System.Drawing.Point(51, 45);
            RightLabel_Label.Name = "RightLabel_Label";
            RightLabel_Label.Size = new System.Drawing.Size(186, 36);
            RightLabel_Label.TabIndex = 37;
            RightLabel_Label.Text = "Правильно";
            RightLabel_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            RightLabel_Label.Visible = false;

            Elements.Add(new Element(RightLabel_Label));
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