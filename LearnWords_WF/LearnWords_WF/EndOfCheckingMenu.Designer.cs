namespace LearnWords_WF
{
    partial class EndOfCheckingMenu
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
            this.Congratulations_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Continue_Button
            // 
            this.Continue_Button.AutoSize = true;
            this.Continue_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Continue_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Continue_Button.Location = new System.Drawing.Point(62, 107);
            this.Continue_Button.Name = "Continue_Button";
            this.Continue_Button.Size = new System.Drawing.Size(188, 42);
            this.Continue_Button.TabIndex = 46;
            this.Continue_Button.Text = "Продолжить";
            this.Continue_Button.UseVisualStyleBackColor = true;
            this.Continue_Button.Visible = false;
            this.Continue_Button.Click += new System.EventHandler(this.button9_Click);
            // 
            // Congratulations_Label
            // 
            this.Congratulations_Label.AutoSize = true;
            this.Congratulations_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Congratulations_Label.Location = new System.Drawing.Point(26, 27);
            this.Congratulations_Label.Name = "Congratulations_Label";
            this.Congratulations_Label.Size = new System.Drawing.Size(272, 64);
            this.Congratulations_Label.TabIndex = 45;
            this.Congratulations_Label.Text = "Поздравляю\r\nСлова закончились";
            this.Congratulations_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Congratulations_Label.Visible = false;
            // 
            // EndOfCheckingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 177);
            this.Controls.Add(this.Continue_Button);
            this.Controls.Add(this.Congratulations_Label);
            this.Name = "EndOfCheckingMenu";
            this.Text = "EndOfCheckingMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Continue_Button;
        private System.Windows.Forms.Label Congratulations_Label;
    }
}