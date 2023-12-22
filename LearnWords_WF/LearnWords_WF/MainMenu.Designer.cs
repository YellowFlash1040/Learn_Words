namespace LearnWords_WF
{
    partial class MainMenu
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
            this.SettingsMenu_Button = new System.Windows.Forms.Button();
            this.DictionariesMenu_Button = new System.Windows.Forms.Button();
            this.TestingMenu_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SettingsMenu_Button
            // 
            this.SettingsMenu_Button.AutoSize = true;
            this.SettingsMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingsMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsMenu_Button.Location = new System.Drawing.Point(72, 138);
            this.SettingsMenu_Button.Name = "SettingsMenu_Button";
            this.SettingsMenu_Button.Size = new System.Drawing.Size(165, 42);
            this.SettingsMenu_Button.TabIndex = 5;
            this.SettingsMenu_Button.Text = "Настройки";
            this.SettingsMenu_Button.UseVisualStyleBackColor = true;
            // 
            // DictionariesMenu_Button
            // 
            this.DictionariesMenu_Button.AutoSize = true;
            this.DictionariesMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DictionariesMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DictionariesMenu_Button.Location = new System.Drawing.Point(87, 90);
            this.DictionariesMenu_Button.Name = "DictionariesMenu_Button";
            this.DictionariesMenu_Button.Size = new System.Drawing.Size(139, 42);
            this.DictionariesMenu_Button.TabIndex = 4;
            this.DictionariesMenu_Button.Text = "Словари";
            this.DictionariesMenu_Button.UseVisualStyleBackColor = true;
            // 
            // TestingMenu_Button
            // 
            this.TestingMenu_Button.AutoSize = true;
            this.TestingMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TestingMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestingMenu_Button.Location = new System.Drawing.Point(49, 42);
            this.TestingMenu_Button.Name = "TestingMenu_Button";
            this.TestingMenu_Button.Size = new System.Drawing.Size(211, 42);
            this.TestingMenu_Button.TabIndex = 3;
            this.TestingMenu_Button.Text = "Тестирование";
            this.TestingMenu_Button.UseVisualStyleBackColor = true;
            this.TestingMenu_Button.Click += new System.EventHandler(this.TestingMenu_Button_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 226);
            this.Controls.Add(this.SettingsMenu_Button);
            this.Controls.Add(this.DictionariesMenu_Button);
            this.Controls.Add(this.TestingMenu_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SettingsMenu_Button;
        private System.Windows.Forms.Button DictionariesMenu_Button;
        private System.Windows.Forms.Button TestingMenu_Button;
    }
}