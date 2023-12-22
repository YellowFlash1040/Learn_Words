namespace LearnWords_WF
{
    partial class ShowContentOfTheDictionaryMenu
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
            this.DictionaryName_Label = new System.Windows.Forms.Label();
            this.BackFromShowContentOfTheDictionary_Button = new System.Windows.Forms.Button();
            this.DictionaryContent_ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DictionaryName_Label
            // 
            this.DictionaryName_Label.AutoSize = true;
            this.DictionaryName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DictionaryName_Label.Location = new System.Drawing.Point(243, 35);
            this.DictionaryName_Label.Name = "DictionaryName_Label";
            this.DictionaryName_Label.Size = new System.Drawing.Size(298, 36);
            this.DictionaryName_Label.TabIndex = 39;
            this.DictionaryName_Label.Text = "Название словаря";
            this.DictionaryName_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DictionaryName_Label.Visible = false;
            // 
            // BackFromShowContentOfTheDictionary_Button
            // 
            this.BackFromShowContentOfTheDictionary_Button.AutoSize = true;
            this.BackFromShowContentOfTheDictionary_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackFromShowContentOfTheDictionary_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackFromShowContentOfTheDictionary_Button.Location = new System.Drawing.Point(333, 386);
            this.BackFromShowContentOfTheDictionary_Button.Name = "BackFromShowContentOfTheDictionary_Button";
            this.BackFromShowContentOfTheDictionary_Button.Size = new System.Drawing.Size(106, 42);
            this.BackFromShowContentOfTheDictionary_Button.TabIndex = 40;
            this.BackFromShowContentOfTheDictionary_Button.Text = "Назад";
            this.BackFromShowContentOfTheDictionary_Button.UseVisualStyleBackColor = true;
            this.BackFromShowContentOfTheDictionary_Button.Visible = false;
            // 
            // DictionaryContent_ListBox
            // 
            this.DictionaryContent_ListBox.BackColor = System.Drawing.SystemColors.Control;
            this.DictionaryContent_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DictionaryContent_ListBox.FormattingEnabled = true;
            this.DictionaryContent_ListBox.ItemHeight = 20;
            this.DictionaryContent_ListBox.Location = new System.Drawing.Point(127, 95);
            this.DictionaryContent_ListBox.Name = "DictionaryContent_ListBox";
            this.DictionaryContent_ListBox.Size = new System.Drawing.Size(524, 264);
            this.DictionaryContent_ListBox.TabIndex = 41;
            // 
            // ShowContentOfTheDictionaryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DictionaryContent_ListBox);
            this.Controls.Add(this.BackFromShowContentOfTheDictionary_Button);
            this.Controls.Add(this.DictionaryName_Label);
            this.Name = "ShowContentOfTheDictionaryMenu";
            this.Text = "ShowContentOfTheDictionaryMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DictionaryName_Label;
        private System.Windows.Forms.Button BackFromShowContentOfTheDictionary_Button;
        private System.Windows.Forms.ListBox DictionaryContent_ListBox;
    }
}