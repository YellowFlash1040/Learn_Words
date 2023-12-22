using System.Windows.Forms;
using System;

namespace Learn_Words_WF_Menus
{
    public class ConfirmDeletingMenu : ControlMenu
    {
        public Button CancelDeleting_Button;
        public Button DeleteDictionary_Button;

        public ConfirmDeletingMenu(Form form) : base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            CancelDeleting_Button = new System.Windows.Forms.Button();
            Label YouWantToDeleteDictionary_Label = new System.Windows.Forms.Label();
            Label NameOfDictionaryToDelete_Label = new System.Windows.Forms.Label();
            DeleteDictionary_Button = new System.Windows.Forms.Button();

            // 
            // CancelDeleting_Button
            // 
            CancelDeleting_Button.AutoSize = true;
            CancelDeleting_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CancelDeleting_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            CancelDeleting_Button.Location = new System.Drawing.Point(129, 219);
            CancelDeleting_Button.Name = "CancelDeleting_Button";
            CancelDeleting_Button.Size = new System.Drawing.Size(127, 42);
            CancelDeleting_Button.TabIndex = 21;
            CancelDeleting_Button.Text = "Отмена";
            CancelDeleting_Button.UseVisualStyleBackColor = true;
            CancelDeleting_Button.Visible = false;
            // 
            // YouWantToDeleteDictionary_Label
            // 
            YouWantToDeleteDictionary_Label.AutoSize = true;
            YouWantToDeleteDictionary_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            YouWantToDeleteDictionary_Label.Location = new System.Drawing.Point(12, 36);
            YouWantToDeleteDictionary_Label.Name = "YouWantToDeleteDictionary_Label";
            YouWantToDeleteDictionary_Label.Size = new System.Drawing.Size(384, 32);
            YouWantToDeleteDictionary_Label.TabIndex = 22;
            YouWantToDeleteDictionary_Label.Text = "Вы хотите удалить словарь:";
            YouWantToDeleteDictionary_Label.Visible = false;
            // 
            // NameOfDictionaryToDelete_Label
            // 
            NameOfDictionaryToDelete_Label.AutoSize = true;
            NameOfDictionaryToDelete_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            NameOfDictionaryToDelete_Label.Location = new System.Drawing.Point(123, 89);
            NameOfDictionaryToDelete_Label.Name = "NameOfDictionaryToDelete_Label";
            NameOfDictionaryToDelete_Label.Size = new System.Drawing.Size(128, 32);
            NameOfDictionaryToDelete_Label.TabIndex = 23;
            NameOfDictionaryToDelete_Label.Text = "Словарь";
            NameOfDictionaryToDelete_Label.Visible = false;
            // 
            // DeleteDictionary_Button
            // 
            DeleteDictionary_Button.AutoSize = true;
            DeleteDictionary_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            DeleteDictionary_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            DeleteDictionary_Button.Location = new System.Drawing.Point(129, 157);
            DeleteDictionary_Button.Name = "DeleteDictionary_Button";
            DeleteDictionary_Button.Size = new System.Drawing.Size(134, 42);
            DeleteDictionary_Button.TabIndex = 20;
            DeleteDictionary_Button.Text = "Удалить";
            DeleteDictionary_Button.UseVisualStyleBackColor = true;
            DeleteDictionary_Button.Visible = false;

            Elements.Add(new Element(YouWantToDeleteDictionary_Label));
            Elements.Add(new Element(NameOfDictionaryToDelete_Label));
            Elements.Add(new Element(DeleteDictionary_Button));
            Elements.Add(new Element(CancelDeleting_Button));

            controlToSelect = DeleteDictionary_Button;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }
    }
}