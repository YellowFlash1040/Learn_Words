using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class ChoosingAnswersMenu : ControlMenu
    {
        public List<Button> Answers;
        public Button BackFromChoosingAnswersMenu_Button;
        public Label WordToTranslate_Label;

        private int spaceBeetweenButtons;

        public ChoosingAnswersMenu(Form form) : base(form)
        {
            spaceBeetweenButtons = 20;
            CreateControls();
        }

        protected override void CreateControls()
        {
            Answers = new List<Button>();

            WordToTranslate_Label = new System.Windows.Forms.Label();
            Button Option1_Button = new System.Windows.Forms.Button();
            Button Option2_Button = new System.Windows.Forms.Button();
            Button Option3_Button = new System.Windows.Forms.Button();
            Button Option4_Button = new System.Windows.Forms.Button();
            Button Option5_Button = new System.Windows.Forms.Button();
            Button Option6_Button = new System.Windows.Forms.Button();
            Button Option7_Button = new System.Windows.Forms.Button();
            Button Option8_Button = new System.Windows.Forms.Button();
            Button Option9_Button = new System.Windows.Forms.Button();
            Button Option10_Button = new System.Windows.Forms.Button();
            BackFromChoosingAnswersMenu_Button = new System.Windows.Forms.Button();
            
            // 
            // WordToTranslate_Label
            // 
            WordToTranslate_Label.AutoSize = true;
            WordToTranslate_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            WordToTranslate_Label.Location = new System.Drawing.Point(212, 35);
            WordToTranslate_Label.Name = "WordToTranslate_Label";
            WordToTranslate_Label.Size = new System.Drawing.Size(285, 32);
            WordToTranslate_Label.TabIndex = 37;
            WordToTranslate_Label.Text = "Слово для перевода";
            WordToTranslate_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            WordToTranslate_Label.Visible = false;
            // 
            // Option1_Button
            // 
            Option1_Button.AutoSize = true;
            Option1_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Option1_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Option1_Button.Location = new System.Drawing.Point(149, 104);
            Option1_Button.Name = "Option1_Button";
            Option1_Button.Size = new System.Drawing.Size(136, 42);
            Option1_Button.TabIndex = 38;
            Option1_Button.Text = "Вариант";
            Option1_Button.UseVisualStyleBackColor = true;
            Option1_Button.Visible = false;
            // 
            // Option2_Button
            // 
            Option2_Button.AutoSize = true;
            Option2_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Option2_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Option2_Button.Location = new System.Drawing.Point(408, 104);
            Option2_Button.Name = "Option2_Button";
            Option2_Button.Size = new System.Drawing.Size(136, 42);
            Option2_Button.TabIndex = 39;
            Option2_Button.Text = "Вариант";
            Option2_Button.UseVisualStyleBackColor = true;
            Option2_Button.Visible = false;
            // 
            // Option3_Button
            // 
            Option3_Button.AutoSize = true;
            Option3_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Option3_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Option3_Button.Location = new System.Drawing.Point(149, 152);
            Option3_Button.Name = "Option3_Button";
            Option3_Button.Size = new System.Drawing.Size(136, 42);
            Option3_Button.TabIndex = 40;
            Option3_Button.Text = "Вариант";
            Option3_Button.UseVisualStyleBackColor = true;
            Option3_Button.Visible = false;
            // 
            // Option4_Button
            // 
            Option4_Button.AutoSize = true;
            Option4_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Option4_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Option4_Button.Location = new System.Drawing.Point(408, 152);
            Option4_Button.Name = "Option4_Button";
            Option4_Button.Size = new System.Drawing.Size(136, 42);
            Option4_Button.TabIndex = 41;
            Option4_Button.Text = "Вариант";
            Option4_Button.UseVisualStyleBackColor = true;
            Option4_Button.Visible = false;
            // 
            // Option5_Button
            // 
            Option5_Button.AutoSize = true;
            Option5_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Option5_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Option5_Button.Location = new System.Drawing.Point(149, 204);
            Option5_Button.Name = "Option5_Button";
            Option5_Button.Size = new System.Drawing.Size(136, 42);
            Option5_Button.TabIndex = 42;
            Option5_Button.Text = "Вариант";
            Option5_Button.UseVisualStyleBackColor = true;
            Option5_Button.Visible = false;
            // 
            // Option6_Button
            // 
            Option6_Button.AutoSize = true;
            Option6_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Option6_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Option6_Button.Location = new System.Drawing.Point(408, 204);
            Option6_Button.Name = "Option6_Button";
            Option6_Button.Size = new System.Drawing.Size(136, 42);
            Option6_Button.TabIndex = 43;
            Option6_Button.Text = "Вариант";
            Option6_Button.UseVisualStyleBackColor = true;
            Option6_Button.Visible = false;
            // 
            // Option7_Button
            // 
            Option7_Button.AutoSize = true;
            Option7_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Option7_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Option7_Button.Location = new System.Drawing.Point(149, 257);
            Option7_Button.Name = "Option7_Button";
            Option7_Button.Size = new System.Drawing.Size(136, 42);
            Option7_Button.TabIndex = 44;
            Option7_Button.Text = "Вариант";
            Option7_Button.UseVisualStyleBackColor = true;
            Option7_Button.Visible = false;
            // 
            // Option8_Button
            // 
            Option8_Button.AutoSize = true;
            Option8_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Option8_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Option8_Button.Location = new System.Drawing.Point(408, 257);
            Option8_Button.Name = "Option8_Button";
            Option8_Button.Size = new System.Drawing.Size(136, 42);
            Option8_Button.TabIndex = 45;
            Option8_Button.Text = "Вариант";
            Option8_Button.UseVisualStyleBackColor = true;
            Option8_Button.Visible = false;
            // 
            // Option9_Button
            // 
            Option9_Button.AutoSize = true;
            Option9_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Option9_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Option9_Button.Location = new System.Drawing.Point(149, 314);
            Option9_Button.Name = "Option9_Button";
            Option9_Button.Size = new System.Drawing.Size(136, 42);
            Option9_Button.TabIndex = 46;
            Option9_Button.Text = "Вариант";
            Option9_Button.UseVisualStyleBackColor = true;
            Option9_Button.Visible = false;
            // 
            // Option10_Button
            // 
            Option10_Button.AutoSize = true;
            Option10_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Option10_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Option10_Button.Location = new System.Drawing.Point(408, 314);
            Option10_Button.Name = "Option10_Button";
            Option10_Button.Size = new System.Drawing.Size(136, 42);
            Option10_Button.TabIndex = 47;
            Option10_Button.Text = "Вариант";
            Option10_Button.UseVisualStyleBackColor = true;
            Option10_Button.Visible = false;
            // 
            // BackFromChoosingAnswersMenu_Button
            // 
            BackFromChoosingAnswersMenu_Button.AutoSize = true;
            BackFromChoosingAnswersMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackFromChoosingAnswersMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackFromChoosingAnswersMenu_Button.Location = new System.Drawing.Point(295, 401);
            BackFromChoosingAnswersMenu_Button.Name = "BackFromChoosingAnswersMenu_Button";
            BackFromChoosingAnswersMenu_Button.Size = new System.Drawing.Size(106, 42);
            BackFromChoosingAnswersMenu_Button.TabIndex = 48;
            BackFromChoosingAnswersMenu_Button.Text = "Назад";
            BackFromChoosingAnswersMenu_Button.UseVisualStyleBackColor = true;
            BackFromChoosingAnswersMenu_Button.Visible = false;

            Answers.Add(Option1_Button);
            Answers.Add(Option2_Button);
            Answers.Add(Option3_Button);
            Answers.Add(Option4_Button);
            Answers.Add(Option5_Button);
            Answers.Add(Option6_Button);
            Answers.Add(Option7_Button);
            Answers.Add(Option8_Button);
            Answers.Add(Option9_Button);
            Answers.Add(Option10_Button);

            Elements.Add(new Element(WordToTranslate_Label));
            Elements.Add(new Element(new List<Control>() { Option1_Button, Option2_Button }));
            Elements.Add(new Element(new List<Control>() { Option3_Button, Option4_Button }));
            Elements.Add(new Element(new List<Control>() { Option5_Button, Option6_Button }));
            Elements.Add(new Element(new List<Control>() { Option7_Button, Option8_Button }));
            Elements.Add(new Element(new List<Control>() { Option9_Button, Option10_Button }));
            Elements.Add(new Element(BackFromChoosingAnswersMenu_Button));

            controlToSelect = Option1_Button;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }

        public void FixAnswersLocations()
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                for (int c = 1; c < Elements[i].Controls.Count; c++)
                {
                    Elements[i].Controls[c].Left = Elements[i].Controls[c - 1].Left + Elements[i].Controls[c - 1].Width + spaceBeetweenButtons;
                }
            }
        }
    }
}