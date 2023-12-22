namespace LearnWords_WF
{
    partial class ConfirmDeletingMenu
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
            this.CancelDeleting_Button = new System.Windows.Forms.Button();
            this.YouWantToDeleteDictionary_Label = new System.Windows.Forms.Label();
            this.NameOfDictionaryToDelete_Label = new System.Windows.Forms.Label();
            this.DeleteDictionary_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelDeleting_Button
            // 
            this.CancelDeleting_Button.AutoSize = true;
            this.CancelDeleting_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelDeleting_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelDeleting_Button.Location = new System.Drawing.Point(129, 219);
            this.CancelDeleting_Button.Name = "CancelDeleting_Button";
            this.CancelDeleting_Button.Size = new System.Drawing.Size(127, 42);
            this.CancelDeleting_Button.TabIndex = 21;
            this.CancelDeleting_Button.Text = "Отмена";
            this.CancelDeleting_Button.UseVisualStyleBackColor = true;
            this.CancelDeleting_Button.Visible = false;
            // 
            // YouWantToDeleteDictionary_Label
            // 
            this.YouWantToDeleteDictionary_Label.AutoSize = true;
            this.YouWantToDeleteDictionary_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YouWantToDeleteDictionary_Label.Location = new System.Drawing.Point(12, 36);
            this.YouWantToDeleteDictionary_Label.Name = "YouWantToDeleteDictionary_Label";
            this.YouWantToDeleteDictionary_Label.Size = new System.Drawing.Size(384, 32);
            this.YouWantToDeleteDictionary_Label.TabIndex = 22;
            this.YouWantToDeleteDictionary_Label.Text = "Вы хотите удалить словарь:";
            this.YouWantToDeleteDictionary_Label.Visible = false;
            // 
            // NameOfDictionaryToDelete_Label
            // 
            this.NameOfDictionaryToDelete_Label.AutoSize = true;
            this.NameOfDictionaryToDelete_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfDictionaryToDelete_Label.Location = new System.Drawing.Point(123, 89);
            this.NameOfDictionaryToDelete_Label.Name = "NameOfDictionaryToDelete_Label";
            this.NameOfDictionaryToDelete_Label.Size = new System.Drawing.Size(128, 32);
            this.NameOfDictionaryToDelete_Label.TabIndex = 23;
            this.NameOfDictionaryToDelete_Label.Text = "Словарь";
            this.NameOfDictionaryToDelete_Label.Visible = false;
            // 
            // DeleteDictionary_Button
            // 
            this.DeleteDictionary_Button.AutoSize = true;
            this.DeleteDictionary_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteDictionary_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDictionary_Button.Location = new System.Drawing.Point(129, 157);
            this.DeleteDictionary_Button.Name = "DeleteDictionary_Button";
            this.DeleteDictionary_Button.Size = new System.Drawing.Size(134, 42);
            this.DeleteDictionary_Button.TabIndex = 20;
            this.DeleteDictionary_Button.Text = "Удалить";
            this.DeleteDictionary_Button.UseVisualStyleBackColor = true;
            this.DeleteDictionary_Button.Visible = false;
            // 
            // ConfirmDeletingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 309);
            this.Controls.Add(this.CancelDeleting_Button);
            this.Controls.Add(this.YouWantToDeleteDictionary_Label);
            this.Controls.Add(this.NameOfDictionaryToDelete_Label);
            this.Controls.Add(this.DeleteDictionary_Button);
            this.Name = "ConfirmDeletingMenu";
            this.Text = "ConfirmDeletingMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelDeleting_Button;
        private System.Windows.Forms.Label YouWantToDeleteDictionary_Label;
        private System.Windows.Forms.Label NameOfDictionaryToDelete_Label;
        private System.Windows.Forms.Button DeleteDictionary_Button;
    }
}