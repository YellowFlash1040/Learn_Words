namespace LearnWords_WF
{
    partial class DeleteDictionaryMenu
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
            this.ChooseDictionaryToDelete_TextBox = new System.Windows.Forms.TextBox();
            this.ChooseDictionaryToDelete_ListBox = new System.Windows.Forms.ListBox();
            this.BackFromDeleteDictionariesMenu_Button = new System.Windows.Forms.Button();
            this.ChooseDictionaryToDelete_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseDictionaryToDelete_TextBox
            // 
            this.ChooseDictionaryToDelete_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChooseDictionaryToDelete_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDictionaryToDelete_TextBox.Location = new System.Drawing.Point(69, 66);
            this.ChooseDictionaryToDelete_TextBox.Name = "ChooseDictionaryToDelete_TextBox";
            this.ChooseDictionaryToDelete_TextBox.Size = new System.Drawing.Size(290, 38);
            this.ChooseDictionaryToDelete_TextBox.TabIndex = 15;
            this.ChooseDictionaryToDelete_TextBox.Visible = false;
            // 
            // ChooseDictionaryToDelete_ListBox
            // 
            this.ChooseDictionaryToDelete_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDictionaryToDelete_ListBox.FormattingEnabled = true;
            this.ChooseDictionaryToDelete_ListBox.ItemHeight = 29;
            this.ChooseDictionaryToDelete_ListBox.Location = new System.Drawing.Point(33, 146);
            this.ChooseDictionaryToDelete_ListBox.Name = "ChooseDictionaryToDelete_ListBox";
            this.ChooseDictionaryToDelete_ListBox.Size = new System.Drawing.Size(378, 207);
            this.ChooseDictionaryToDelete_ListBox.TabIndex = 16;
            this.ChooseDictionaryToDelete_ListBox.Visible = false;
            this.ChooseDictionaryToDelete_ListBox.Click += new System.EventHandler(this.ChooseDictionaryToDelete_ListBox_Click);
            this.ChooseDictionaryToDelete_ListBox.DoubleClick += new System.EventHandler(this.ChooseDictionaryToDelete_ListBox_DoubleClick);
            // 
            // BackFromDeleteDictionariesMenu_Button
            // 
            this.BackFromDeleteDictionariesMenu_Button.AutoSize = true;
            this.BackFromDeleteDictionariesMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackFromDeleteDictionariesMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackFromDeleteDictionariesMenu_Button.Location = new System.Drawing.Point(157, 380);
            this.BackFromDeleteDictionariesMenu_Button.Name = "BackFromDeleteDictionariesMenu_Button";
            this.BackFromDeleteDictionariesMenu_Button.Size = new System.Drawing.Size(106, 42);
            this.BackFromDeleteDictionariesMenu_Button.TabIndex = 17;
            this.BackFromDeleteDictionariesMenu_Button.Text = "Назад";
            this.BackFromDeleteDictionariesMenu_Button.UseVisualStyleBackColor = true;
            this.BackFromDeleteDictionariesMenu_Button.Visible = false;
            // 
            // ChooseDictionaryToDelete_Label
            // 
            this.ChooseDictionaryToDelete_Label.AutoSize = true;
            this.ChooseDictionaryToDelete_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDictionaryToDelete_Label.Location = new System.Drawing.Point(89, 19);
            this.ChooseDictionaryToDelete_Label.Name = "ChooseDictionaryToDelete_Label";
            this.ChooseDictionaryToDelete_Label.Size = new System.Drawing.Size(261, 32);
            this.ChooseDictionaryToDelete_Label.TabIndex = 19;
            this.ChooseDictionaryToDelete_Label.Text = "Выберите словарь";
            this.ChooseDictionaryToDelete_Label.Visible = false;
            // 
            // DeleteDictionaryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 462);
            this.Controls.Add(this.ChooseDictionaryToDelete_TextBox);
            this.Controls.Add(this.ChooseDictionaryToDelete_ListBox);
            this.Controls.Add(this.BackFromDeleteDictionariesMenu_Button);
            this.Controls.Add(this.ChooseDictionaryToDelete_Label);
            this.Name = "DeleteDictionaryMenu";
            this.Text = "DeleteDictionaryMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChooseDictionaryToDelete_TextBox;
        private System.Windows.Forms.ListBox ChooseDictionaryToDelete_ListBox;
        private System.Windows.Forms.Button BackFromDeleteDictionariesMenu_Button;
        private System.Windows.Forms.Label ChooseDictionaryToDelete_Label;
    }
}