using System;
using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class ChooseModeOfGeneratingWordMenu : ControlMenu
    {
        private ComboBox ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox;
        public Button ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button;
        public Button BackFrom_ChooseModeOfGeneratingMenu_Button;

        public ChooseModeOfGeneratingWordMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            BackFrom_ChooseModeOfGeneratingMenu_Button = new System.Windows.Forms.Button();
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button = new System.Windows.Forms.Button();
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox = new System.Windows.Forms.ComboBox();
            Label ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Label = new System.Windows.Forms.Label();
            
            // 
            // BackFrom_ChooseModeOfGeneratingMenu_Button
            // 
            BackFrom_ChooseModeOfGeneratingMenu_Button.AutoSize = true;
            BackFrom_ChooseModeOfGeneratingMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackFrom_ChooseModeOfGeneratingMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackFrom_ChooseModeOfGeneratingMenu_Button.Location = new System.Drawing.Point(125, 206);
            BackFrom_ChooseModeOfGeneratingMenu_Button.Name = "BackFrom_ChooseModeOfGeneratingMenu_Button";
            BackFrom_ChooseModeOfGeneratingMenu_Button.Size = new System.Drawing.Size(106, 42);
            BackFrom_ChooseModeOfGeneratingMenu_Button.TabIndex = 34;
            BackFrom_ChooseModeOfGeneratingMenu_Button.Text = "Назад";
            BackFrom_ChooseModeOfGeneratingMenu_Button.UseVisualStyleBackColor = true;
            BackFrom_ChooseModeOfGeneratingMenu_Button.Visible = false;
            // 
            // ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button
            // 
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.AutoSize = true;
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.Enabled = false;
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.Location = new System.Drawing.Point(86, 145);
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.Name = "ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button";
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.Size = new System.Drawing.Size(196, 42);
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.TabIndex = 33;
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.Text = "Подтвердить";
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.UseVisualStyleBackColor = true;
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.Visible = false;
            // 
            // ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox
            // 
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox.FormattingEnabled = true;
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox.Location = new System.Drawing.Point(86, 100);
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox.Name = "ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox";
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox.Size = new System.Drawing.Size(189, 39);
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox.TabIndex = 32;
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox.Visible = false;
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox.SelectedIndexChanged += ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox_SelectedIndexChanged;
            // 
            // ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Label
            // 
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Label.AutoSize = true;
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Label.Location = new System.Drawing.Point(12, 22);
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Label.Name = "ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Label";
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Label.Size = new System.Drawing.Size(363, 64);
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Label.TabIndex = 31;
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Label.Text = "Выберите из какого языка\r\nгенерировать слово";
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Label.Visible = false;

            Elements.Add(new Element(ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Label));
            Elements.Add(new Element(ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox));
            Elements.Add(new Element(ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button));
            Elements.Add(new Element(BackFrom_ChooseModeOfGeneratingMenu_Button));

            controlToSelect = ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }

        private void ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox.SelectedIndex == -1)
            {
                ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.Enabled = false;
            }
            else
            {
                ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.Enabled = true;
            }
        }

        public override void Clear()
        {
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_ComboBox.Items.Clear();
            ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.Enabled = false;
        }
    }
}