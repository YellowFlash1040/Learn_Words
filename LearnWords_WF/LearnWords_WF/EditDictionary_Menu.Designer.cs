namespace LearnWords_WF
{
    partial class EditDictionary_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseDictionaryToEdit_TextBox = new System.Windows.Forms.TextBox();
            this.ChooseDictionaryToEdit_ListBox = new System.Windows.Forms.ListBox();
            this.BackFromEditDictionariesMenu_Button = new System.Windows.Forms.Button();
            this.ChooseDictionaryToEdit_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseDictionaryToEdit_TextBox
            // 
            this.ChooseDictionaryToEdit_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChooseDictionaryToEdit_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDictionaryToEdit_TextBox.Location = new System.Drawing.Point(247, 71);
            this.ChooseDictionaryToEdit_TextBox.Name = "ChooseDictionaryToEdit_TextBox";
            this.ChooseDictionaryToEdit_TextBox.Size = new System.Drawing.Size(290, 38);
            this.ChooseDictionaryToEdit_TextBox.TabIndex = 20;
            this.ChooseDictionaryToEdit_TextBox.Visible = false;
            // 
            // ChooseDictionaryToEdit_ListBox
            // 
            this.ChooseDictionaryToEdit_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDictionaryToEdit_ListBox.FormattingEnabled = true;
            this.ChooseDictionaryToEdit_ListBox.ItemHeight = 29;
            this.ChooseDictionaryToEdit_ListBox.Location = new System.Drawing.Point(211, 151);
            this.ChooseDictionaryToEdit_ListBox.Name = "ChooseDictionaryToEdit_ListBox";
            this.ChooseDictionaryToEdit_ListBox.Size = new System.Drawing.Size(378, 207);
            this.ChooseDictionaryToEdit_ListBox.TabIndex = 21;
            this.ChooseDictionaryToEdit_ListBox.Visible = false;
            // 
            // BackFromEditDictionariesMenu_Button
            // 
            this.BackFromEditDictionariesMenu_Button.AutoSize = true;
            this.BackFromEditDictionariesMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackFromEditDictionariesMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackFromEditDictionariesMenu_Button.Location = new System.Drawing.Point(335, 385);
            this.BackFromEditDictionariesMenu_Button.Name = "BackFromEditDictionariesMenu_Button";
            this.BackFromEditDictionariesMenu_Button.Size = new System.Drawing.Size(106, 42);
            this.BackFromEditDictionariesMenu_Button.TabIndex = 22;
            this.BackFromEditDictionariesMenu_Button.Text = "Назад";
            this.BackFromEditDictionariesMenu_Button.UseVisualStyleBackColor = true;
            this.BackFromEditDictionariesMenu_Button.Visible = false;
            // 
            // ChooseDictionaryToEdit_Label
            // 
            this.ChooseDictionaryToEdit_Label.AutoSize = true;
            this.ChooseDictionaryToEdit_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDictionaryToEdit_Label.Location = new System.Drawing.Point(267, 24);
            this.ChooseDictionaryToEdit_Label.Name = "ChooseDictionaryToEdit_Label";
            this.ChooseDictionaryToEdit_Label.Size = new System.Drawing.Size(261, 32);
            this.ChooseDictionaryToEdit_Label.TabIndex = 23;
            this.ChooseDictionaryToEdit_Label.Text = "Выберите словарь";
            this.ChooseDictionaryToEdit_Label.Visible = false;
            // 
            // EditDictionary_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChooseDictionaryToEdit_TextBox);
            this.Controls.Add(this.ChooseDictionaryToEdit_ListBox);
            this.Controls.Add(this.BackFromEditDictionariesMenu_Button);
            this.Controls.Add(this.ChooseDictionaryToEdit_Label);
            this.Name = "EditDictionary_Menu";
            this.Text = "EditDictionary_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChooseDictionaryToEdit_TextBox;
        private System.Windows.Forms.ListBox ChooseDictionaryToEdit_ListBox;
        private System.Windows.Forms.Button BackFromEditDictionariesMenu_Button;
        private System.Windows.Forms.Label ChooseDictionaryToEdit_Label;
    }
}