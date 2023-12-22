namespace LearnWords_WF
{
    partial class CheckingWord_Menu
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
            this.BackFromCheckingWordMenu_Button = new System.Windows.Forms.Button();
            this.CheckUsersInput_Button = new System.Windows.Forms.Button();
            this.WordToTranslate_Label = new System.Windows.Forms.Label();
            this.UsersInput_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackFromCheckingWordMenu_Button
            // 
            this.BackFromCheckingWordMenu_Button.AutoSize = true;
            this.BackFromCheckingWordMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackFromCheckingWordMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackFromCheckingWordMenu_Button.Location = new System.Drawing.Point(114, 188);
            this.BackFromCheckingWordMenu_Button.Name = "BackFromCheckingWordMenu_Button";
            this.BackFromCheckingWordMenu_Button.Size = new System.Drawing.Size(106, 42);
            this.BackFromCheckingWordMenu_Button.TabIndex = 38;
            this.BackFromCheckingWordMenu_Button.Text = "Назад";
            this.BackFromCheckingWordMenu_Button.UseVisualStyleBackColor = true;
            this.BackFromCheckingWordMenu_Button.Visible = false;
            // 
            // CheckUsersInput_Button
            // 
            this.CheckUsersInput_Button.AutoSize = true;
            this.CheckUsersInput_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CheckUsersInput_Button.Enabled = false;
            this.CheckUsersInput_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckUsersInput_Button.Location = new System.Drawing.Point(88, 131);
            this.CheckUsersInput_Button.Name = "CheckUsersInput_Button";
            this.CheckUsersInput_Button.Size = new System.Drawing.Size(167, 42);
            this.CheckUsersInput_Button.TabIndex = 37;
            this.CheckUsersInput_Button.Text = "Проверить";
            this.CheckUsersInput_Button.UseVisualStyleBackColor = true;
            this.CheckUsersInput_Button.Visible = false;
            // 
            // WordToTranslate_Label
            // 
            this.WordToTranslate_Label.AutoSize = true;
            this.WordToTranslate_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordToTranslate_Label.Location = new System.Drawing.Point(32, 42);
            this.WordToTranslate_Label.Name = "WordToTranslate_Label";
            this.WordToTranslate_Label.Size = new System.Drawing.Size(285, 32);
            this.WordToTranslate_Label.TabIndex = 36;
            this.WordToTranslate_Label.Text = "Слово для перевода";
            this.WordToTranslate_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WordToTranslate_Label.Visible = false;
            // 
            // UsersInput_TextBox
            // 
            this.UsersInput_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UsersInput_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.UsersInput_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersInput_TextBox.Location = new System.Drawing.Point(38, 87);
            this.UsersInput_TextBox.Name = "UsersInput_TextBox";
            this.UsersInput_TextBox.Size = new System.Drawing.Size(264, 38);
            this.UsersInput_TextBox.TabIndex = 35;
            this.UsersInput_TextBox.Visible = false;
            // 
            // CheckingWord_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 291);
            this.Controls.Add(this.BackFromCheckingWordMenu_Button);
            this.Controls.Add(this.CheckUsersInput_Button);
            this.Controls.Add(this.WordToTranslate_Label);
            this.Controls.Add(this.UsersInput_TextBox);
            this.Name = "CheckingWord_Menu";
            this.Text = "CheckingWord_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackFromCheckingWordMenu_Button;
        private System.Windows.Forms.Button CheckUsersInput_Button;
        private System.Windows.Forms.Label WordToTranslate_Label;
        private System.Windows.Forms.TextBox UsersInput_TextBox;
    }
}