using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class DictionariesMenu : ControlMenu
    {
        public Button BackFromDictionariesMenu_Button;
        public Button DeleteDictionaryMenu_Button;
        public Button AddDictionaryMenu_Button;
        public Button ShowAddedDictionaries_Button;
        public Button EditDictionary_Button;

        public DictionariesMenu(Form form):base(form)
        {
            CreateControls();
        }

        protected override void CreateControls()
        {
            BackFromDictionariesMenu_Button = new System.Windows.Forms.Button();
            DeleteDictionaryMenu_Button = new System.Windows.Forms.Button();
            AddDictionaryMenu_Button = new System.Windows.Forms.Button();
            ShowAddedDictionaries_Button = new System.Windows.Forms.Button();
            EditDictionary_Button = new System.Windows.Forms.Button();

            // 
            // BackFromDictionariesMenu_Button
            // 
            this.BackFromDictionariesMenu_Button.AutoSize = true;
            this.BackFromDictionariesMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackFromDictionariesMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackFromDictionariesMenu_Button.Location = new System.Drawing.Point(166, 242);
            this.BackFromDictionariesMenu_Button.Name = "BackFromDictionariesMenu_Button";
            this.BackFromDictionariesMenu_Button.Size = new System.Drawing.Size(106, 42);
            this.BackFromDictionariesMenu_Button.TabIndex = 4;
            this.BackFromDictionariesMenu_Button.Text = "Назад";
            this.BackFromDictionariesMenu_Button.UseVisualStyleBackColor = true;
            this.BackFromDictionariesMenu_Button.Visible = false;
            // 
            // DeleteDictionaryMenu_Button
            // 
            this.DeleteDictionaryMenu_Button.AutoSize = true;
            this.DeleteDictionaryMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteDictionaryMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDictionaryMenu_Button.Location = new System.Drawing.Point(109, 138);
            this.DeleteDictionaryMenu_Button.Name = "DeleteDictionaryMenu_Button";
            this.DeleteDictionaryMenu_Button.Size = new System.Drawing.Size(249, 42);
            this.DeleteDictionaryMenu_Button.TabIndex = 2;
            this.DeleteDictionaryMenu_Button.Text = "Удалить словарь";
            this.DeleteDictionaryMenu_Button.UseVisualStyleBackColor = true;
            this.DeleteDictionaryMenu_Button.Visible = false;
            // 
            // AddDictionaryMenu_Button
            // 
            this.AddDictionaryMenu_Button.AutoSize = true;
            this.AddDictionaryMenu_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddDictionaryMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDictionaryMenu_Button.Location = new System.Drawing.Point(47, 90);
            this.AddDictionaryMenu_Button.Name = "AddDictionaryMenu_Button";
            this.AddDictionaryMenu_Button.Size = new System.Drawing.Size(358, 42);
            this.AddDictionaryMenu_Button.TabIndex = 1;
            this.AddDictionaryMenu_Button.Text = "Добавить новый словарь";
            this.AddDictionaryMenu_Button.UseVisualStyleBackColor = true;
            this.AddDictionaryMenu_Button.Visible = false;
            // 
            // ShowAddedDictionaries_Button
            // 
            this.ShowAddedDictionaries_Button.AutoSize = true;
            this.ShowAddedDictionaries_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowAddedDictionaries_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAddedDictionaries_Button.Location = new System.Drawing.Point(32, 40);
            this.ShowAddedDictionaries_Button.Name = "ShowAddedDictionaries_Button";
            this.ShowAddedDictionaries_Button.Size = new System.Drawing.Size(385, 42);
            this.ShowAddedDictionaries_Button.TabIndex = 0;
            this.ShowAddedDictionaries_Button.Text = "Просмотреть добавленные";
            this.ShowAddedDictionaries_Button.UseVisualStyleBackColor = true;
            this.ShowAddedDictionaries_Button.Visible = false;
            // 
            // EditDictionary_Button
            // 
            this.EditDictionary_Button.AutoSize = true;
            this.EditDictionary_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditDictionary_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditDictionary_Button.Location = new System.Drawing.Point(65, 186);
            this.EditDictionary_Button.Name = "EditDictionary_Button";
            this.EditDictionary_Button.Size = new System.Drawing.Size(340, 42);
            this.EditDictionary_Button.TabIndex = 3;
            this.EditDictionary_Button.Text = "Редактировать словарь";
            this.EditDictionary_Button.UseVisualStyleBackColor = true;
            this.EditDictionary_Button.Visible = false;

            Elements.Add(new Element(ShowAddedDictionaries_Button));
            Elements.Add(new Element(AddDictionaryMenu_Button));
            Elements.Add(new Element(DeleteDictionaryMenu_Button));
            Elements.Add(new Element(EditDictionary_Button));
            Elements.Add(new Element(BackFromDictionariesMenu_Button));

            controlToSelect = ShowAddedDictionaries_Button;
        }

        public override void Show()
        {
            base.Show();
            controlToSelect.Select();
        }
    }
}