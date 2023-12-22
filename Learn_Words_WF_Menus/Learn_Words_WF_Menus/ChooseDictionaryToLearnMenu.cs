using System;
//using System.Drawing.Text;
using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class ChooseDictionaryToLearnMenu : ControlMenu
    {
        public Button BackFromChooseDictionaryToLearn_Button;
        private ComboBox ChooseDictionaryToLearn_ComboBox;
        public Button ChooseDictionaryToLearn_Button;

        public ChooseDictionaryToLearnMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            BackFromChooseDictionaryToLearn_Button = new System.Windows.Forms.Button();
            ChooseDictionaryToLearn_Button = new System.Windows.Forms.Button();
            ChooseDictionaryToLearn_ComboBox = new System.Windows.Forms.ComboBox();
            Label ChooseDictionaryToLearn_Label = new System.Windows.Forms.Label();
            
            // 
            // BackFromChooseDictionaryToLearn_Button
            // 
            BackFromChooseDictionaryToLearn_Button.AutoSize = true;
            BackFromChooseDictionaryToLearn_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackFromChooseDictionaryToLearn_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackFromChooseDictionaryToLearn_Button.Location = new System.Drawing.Point(113, 183);
            BackFromChooseDictionaryToLearn_Button.Name = "BackFromChooseDictionaryToLearn_Button";
            BackFromChooseDictionaryToLearn_Button.Size = new System.Drawing.Size(106, 42);
            BackFromChooseDictionaryToLearn_Button.TabIndex = 30;
            BackFromChooseDictionaryToLearn_Button.Text = "Назад";
            BackFromChooseDictionaryToLearn_Button.UseVisualStyleBackColor = true;
            BackFromChooseDictionaryToLearn_Button.Visible = false;
            // 
            // ChooseDictionaryToLearn_Button
            // 
            ChooseDictionaryToLearn_Button.AutoSize = true;
            ChooseDictionaryToLearn_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ChooseDictionaryToLearn_Button.Enabled = false;
            ChooseDictionaryToLearn_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseDictionaryToLearn_Button.Location = new System.Drawing.Point(69, 127);
            ChooseDictionaryToLearn_Button.Name = "ChooseDictionaryToLearn_Button";
            ChooseDictionaryToLearn_Button.Size = new System.Drawing.Size(196, 42);
            ChooseDictionaryToLearn_Button.TabIndex = 29;
            ChooseDictionaryToLearn_Button.Text = "Подтвердить";
            ChooseDictionaryToLearn_Button.UseVisualStyleBackColor = true;
            ChooseDictionaryToLearn_Button.Visible = false;
            // 
            // ChooseDictionaryToLearn_ComboBox
            // 
            ChooseDictionaryToLearn_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ChooseDictionaryToLearn_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseDictionaryToLearn_ComboBox.FormattingEnabled = true;
            ChooseDictionaryToLearn_ComboBox.Location = new System.Drawing.Point(69, 73);
            ChooseDictionaryToLearn_ComboBox.Name = "ChooseDictionaryToLearn_ComboBox";
            ChooseDictionaryToLearn_ComboBox.Size = new System.Drawing.Size(189, 39);
            ChooseDictionaryToLearn_ComboBox.TabIndex = 28;
            ChooseDictionaryToLearn_ComboBox.Visible = false;
            ChooseDictionaryToLearn_ComboBox.SelectedIndexChanged += ChooseDictionaryToLearn_ComboBox_SelectedIndexChanged;
            // 
            // ChooseDictionaryToLearn_Label
            // 
            ChooseDictionaryToLearn_Label.AutoSize = true;
            ChooseDictionaryToLearn_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseDictionaryToLearn_Label.Location = new System.Drawing.Point(36, 28);
            ChooseDictionaryToLearn_Label.Name = "ChooseDictionaryToLearn_Label";
            ChooseDictionaryToLearn_Label.Size = new System.Drawing.Size(261, 32);
            ChooseDictionaryToLearn_Label.TabIndex = 27;
            ChooseDictionaryToLearn_Label.Text = "Выберите словарь";
            ChooseDictionaryToLearn_Label.Visible = false;

            Elements.Add(new Element(ChooseDictionaryToLearn_Label));
            Elements.Add(new Element(ChooseDictionaryToLearn_ComboBox));
            Elements.Add(new Element(ChooseDictionaryToLearn_Button));
            Elements.Add(new Element(BackFromChooseDictionaryToLearn_Button));

            controlToSelect = ChooseDictionaryToLearn_ComboBox;
        }

        private void ChooseDictionaryToLearn_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ChooseDictionaryToLearn_ComboBox.SelectedIndex == -1)
            {
                ChooseDictionaryToLearn_Button.Enabled = false;
            }
            else
            {
                ChooseDictionaryToLearn_Button.Enabled = true;
            }
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }

        public override void Clear()
        {
            ChooseDictionaryToLearn_ComboBox.Items.Clear();
            ChooseDictionaryToLearn_Button.Enabled = false;
        }
    }
}