using System;
using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class EndOfCheckingMenu : ControlMenu
    {
        public Button Continue_Button;

        public EndOfCheckingMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            Continue_Button = new System.Windows.Forms.Button();
            Label Congratulations_Label = new System.Windows.Forms.Label();
            
            // 
            // Continue_Button
            // 
            Continue_Button.AutoSize = true;
            Continue_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Continue_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Continue_Button.Location = new System.Drawing.Point(62, 107);
            Continue_Button.Name = "Continue_Button";
            Continue_Button.Size = new System.Drawing.Size(188, 42);
            Continue_Button.TabIndex = 46;
            Continue_Button.Text = "Продолжить";
            Continue_Button.UseVisualStyleBackColor = true;
            Continue_Button.Visible = false;
            // 
            // Congratulations_Label
            // 
            Congratulations_Label.AutoSize = true;
            Congratulations_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Congratulations_Label.Location = new System.Drawing.Point(26, 27);
            Congratulations_Label.Name = "Congratulations_Label";
            Congratulations_Label.Size = new System.Drawing.Size(272, 64);
            Congratulations_Label.TabIndex = 45;
            Congratulations_Label.Text = "Поздравляю\r\nСлова закончились";
            Congratulations_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Congratulations_Label.Visible = false;

            Elements.Add(new Element(Congratulations_Label));
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
