namespace LearnWords_WF
{
    partial class ShowDictionariesListMenu
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
            this.EnterDictionaryName_TextBox = new System.Windows.Forms.TextBox();
            this.EnterDictionaryName_ListBox = new System.Windows.Forms.ListBox();
            this.BackFromShowAddedDictionariesMenu_Button = new System.Windows.Forms.Button();
            this.EnterDictionaryName_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterDictionaryName_TextBox
            // 
            this.EnterDictionaryName_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnterDictionaryName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterDictionaryName_TextBox.Location = new System.Drawing.Point(57, 67);
            this.EnterDictionaryName_TextBox.Name = "EnterDictionaryName_TextBox";
            this.EnterDictionaryName_TextBox.Size = new System.Drawing.Size(290, 38);
            this.EnterDictionaryName_TextBox.TabIndex = 23;
            this.EnterDictionaryName_TextBox.Visible = false;
            // 
            // EnterDictionaryName_ListBox
            // 
            this.EnterDictionaryName_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterDictionaryName_ListBox.FormattingEnabled = true;
            this.EnterDictionaryName_ListBox.ItemHeight = 29;
            this.EnterDictionaryName_ListBox.Location = new System.Drawing.Point(21, 147);
            this.EnterDictionaryName_ListBox.Name = "EnterDictionaryName_ListBox";
            this.EnterDictionaryName_ListBox.Size = new System.Drawing.Size(378, 207);
            this.EnterDictionaryName_ListBox.TabIndex = 24;
            this.EnterDictionaryName_ListBox.Visible = false;
            // 
            // BackFromShowAddedDictionariesMenu_Button
            // 
            this.BackFromShowAddedDictionariesMenu_Button.AutoSize = true;
            this.BackFromShowAddedDictionariesMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackFromShowAddedDictionariesMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackFromShowAddedDictionariesMenu_Button.Location = new System.Drawing.Point(149, 380);
            this.BackFromShowAddedDictionariesMenu_Button.Name = "BackFromShowAddedDictionariesMenu_Button";
            this.BackFromShowAddedDictionariesMenu_Button.Size = new System.Drawing.Size(106, 42);
            this.BackFromShowAddedDictionariesMenu_Button.TabIndex = 25;
            this.BackFromShowAddedDictionariesMenu_Button.Text = "Назад";
            this.BackFromShowAddedDictionariesMenu_Button.UseVisualStyleBackColor = true;
            this.BackFromShowAddedDictionariesMenu_Button.Visible = false;
            // 
            // EnterDictionaryName_Label
            // 
            this.EnterDictionaryName_Label.AutoSize = true;
            this.EnterDictionaryName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterDictionaryName_Label.Location = new System.Drawing.Point(51, 19);
            this.EnterDictionaryName_Label.Name = "EnterDictionaryName_Label";
            this.EnterDictionaryName_Label.Size = new System.Drawing.Size(298, 32);
            this.EnterDictionaryName_Label.TabIndex = 26;
            this.EnterDictionaryName_Label.Text = "Введите имя словаря";
            this.EnterDictionaryName_Label.Visible = false;
            // 
            // ShowDictionariesListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 447);
            this.Controls.Add(this.EnterDictionaryName_TextBox);
            this.Controls.Add(this.EnterDictionaryName_ListBox);
            this.Controls.Add(this.BackFromShowAddedDictionariesMenu_Button);
            this.Controls.Add(this.EnterDictionaryName_Label);
            this.Name = "ShowDictionariesListMenu";
            this.Text = "ShowDictionariesListMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterDictionaryName_TextBox;
        private System.Windows.Forms.ListBox EnterDictionaryName_ListBox;
        private System.Windows.Forms.Button BackFromShowAddedDictionariesMenu_Button;
        private System.Windows.Forms.Label EnterDictionaryName_Label;
    }
}