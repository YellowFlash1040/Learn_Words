namespace LearnWords_WF
{
    partial class RightAnswerMenu
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
            this.Continue_Button = new System.Windows.Forms.Button();
            this.RightLabel_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Continue_Button
            // 
            this.Continue_Button.AutoSize = true;
            this.Continue_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Continue_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Continue_Button.Location = new System.Drawing.Point(49, 99);
            this.Continue_Button.Name = "Continue_Button";
            this.Continue_Button.Size = new System.Drawing.Size(188, 42);
            this.Continue_Button.TabIndex = 38;
            this.Continue_Button.Text = "Продолжить";
            this.Continue_Button.UseVisualStyleBackColor = true;
            this.Continue_Button.Visible = false;
            // 
            // RightLabel_Label
            // 
            this.RightLabel_Label.AutoSize = true;
            this.RightLabel_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightLabel_Label.Location = new System.Drawing.Point(51, 45);
            this.RightLabel_Label.Name = "RightLabel_Label";
            this.RightLabel_Label.Size = new System.Drawing.Size(186, 36);
            this.RightLabel_Label.TabIndex = 37;
            this.RightLabel_Label.Text = "Правильно";
            this.RightLabel_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RightLabel_Label.Visible = false;
            // 
            // RightAnswerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 200);
            this.Controls.Add(this.Continue_Button);
            this.Controls.Add(this.RightLabel_Label);
            this.Name = "RightAnswerMenu";
            this.Text = "RightAnswerMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Continue_Button;
        private System.Windows.Forms.Label RightLabel_Label;
    }
}