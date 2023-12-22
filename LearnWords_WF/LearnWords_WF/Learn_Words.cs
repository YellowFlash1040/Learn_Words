using System;
using System.IO;
using System.Windows.Forms;
using Learn_Words_Library;
using Learn_Words_WF_Menus;

namespace LearnWords_WF
{
    public partial class Learn_Words : Form
    {
        CollectionOfMenu menus;
        WorkingWithForm workingWithForm;

        IWordsCheckingSystem wordsCheckingSystem;
        string DataFilePath;
        Dictionaries_List dictionaries;

        ModeOfChecking modeOfChecking;

        public Learn_Words()
        {
            InitializeComponent();

            DataFilePath = "Dictionaries.txt";
            IDataReaderWriter dataReaderWriter = new TXTDataReaderWriter(DataFilePath);
            dictionaries = new Dictionaries_List(dataReaderWriter);

            menus = new CollectionOfMenu(this);
            
            workingWithForm = new WorkingWithForm(this);
            workingWithForm.WidthFromWall = 50;
            workingWithForm.HeightFromWall = 50;

            CreateAllMenus();
            OpenMainMenu();
        }

        private void OpenMainMenu()
        {
            ControlMenu menu = menus.List[MenuNames.MainMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void CreateAllMenus()
        {
            //Main Menu
            Learn_Words_WF_Menus.MainMenu mainMenu = new Learn_Words_WF_Menus.MainMenu(this);
            menus.Add(mainMenu, MenuNames.MainMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.MainMenu.ToString());
            mainMenu.TestingMenu_Button.Click += TestingMenu_Button_Click;
            mainMenu.DictionariesMenu_Button.Click += DictionariesMenu_Button_Click;

            //Add Dictionary Menu
            Learn_Words_WF_Menus.AddDictionaryMenu addDictionaryMenu = new Learn_Words_WF_Menus.AddDictionaryMenu(this);
            menus.Add(addDictionaryMenu, MenuNames.AddDictionaryMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.AddDictionaryMenu.ToString());
            addDictionaryMenu.BackFromAddDictionaryMenu_Button.Click += BackFromAddDictionaryMenu_Button_Click;
            addDictionaryMenu.AddDictionary_Button.Click += AddDictionary_Button_Click;

            //Dictionaries Menu
            Learn_Words_WF_Menus.DictionariesMenu dictionariesMenu = new Learn_Words_WF_Menus.DictionariesMenu(this);
            menus.Add(dictionariesMenu, MenuNames.DictionariesMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.DictionariesMenu.ToString());
            dictionariesMenu.BackFromDictionariesMenu_Button.Click += BackFromDictionariesMenu_Button_Click;
            dictionariesMenu.AddDictionaryMenu_Button.Click += AddDictionaryMenu_Button_Click;
            dictionariesMenu.DeleteDictionaryMenu_Button.Click += DeleteDictionaryMenu_Button_Click;
            dictionariesMenu.ShowAddedDictionaries_Button.Click += ShowAddedDictionaries_Button_Click;
            dictionariesMenu.EditDictionary_Button.Click += EditDictionary_Button_Click;

            //Delete dictionary Menu
            Learn_Words_WF_Menus.DeleteDictionaryMenu deleteDictionaryMenu = new Learn_Words_WF_Menus.DeleteDictionaryMenu(this);
            menus.Add(deleteDictionaryMenu, MenuNames.DeleteDictionaryMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.DeleteDictionaryMenu.ToString());
            deleteDictionaryMenu.BackFromDeleteDictionariesMenu_Button.Click += BackFromDeleteDictionariesMenu_Button_Click;
            deleteDictionaryMenu.ChooseDictionaryToDelete_ListBox.DoubleClick += ChooseDictionaryToDelete_ListBox_DoubleClick;
            deleteDictionaryMenu.ChooseDictionaryToDelete_ListBox.KeyUp += ChooseDictionaryToDelete_ListBox_KeyUp;
            deleteDictionaryMenu.ChooseDictionaryToDelete_ListBox.GotFocus += ChooseDictionaryToDelete_ListBox_GotFocus;
            deleteDictionaryMenu.ChooseDictionaryToDelete_ListBox.LostFocus += ChooseDictionaryToDelete_ListBox_LostFocus;

            //Checking word menu
            Learn_Words_WF_Menus.CheckingWordMenu checkingWordMenu = new Learn_Words_WF_Menus.CheckingWordMenu(this);
            menus.Add(checkingWordMenu, MenuNames.CheckingWord_Menu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.CheckingWord_Menu.ToString());
            checkingWordMenu.BackFromCheckingWordMenu_Button.Click += BackFromCheckingWordMenu_Button_Click;
            checkingWordMenu.CheckUsersInput_Button.Click += CheckUsersInput_Button_Click;

            //Choose dictionary to learn menu
            Learn_Words_WF_Menus.ChooseDictionaryToLearnMenu chooseDictionaryToLearnMenu = new Learn_Words_WF_Menus.ChooseDictionaryToLearnMenu(this);
            menus.Add(chooseDictionaryToLearnMenu, MenuNames.ChooseDictionaryToLearn_Menu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.ChooseDictionaryToLearn_Menu.ToString());
            chooseDictionaryToLearnMenu.BackFromChooseDictionaryToLearn_Button.Click += BackFromChooseDictionaryToLearn_Button_Click;
            chooseDictionaryToLearnMenu.ChooseDictionaryToLearn_Button.Click += ChooseDictionaryToLearn_Button_Click;

            //Choose mode of checking Menu
            Learn_Words_WF_Menus.ChooseHowYouWouldLikeToEnterAnswersMenu chooseHowYouWouldLikeToEnterAnswersMenu = new Learn_Words_WF_Menus.ChooseHowYouWouldLikeToEnterAnswersMenu(this);
            menus.Add(chooseHowYouWouldLikeToEnterAnswersMenu, MenuNames.ChooseHowYouWouldLikeToEnterAnswersMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.ChooseHowYouWouldLikeToEnterAnswersMenu.ToString());
            chooseHowYouWouldLikeToEnterAnswersMenu.BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button.Click += BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button_Click;
            chooseHowYouWouldLikeToEnterAnswersMenu.EnterByMySelf_Button.Click += EnterByMySelf_Button_Click;
            chooseHowYouWouldLikeToEnterAnswersMenu.ChooseFromOptions_Button.Click += ChooseFromOptions_Button_Click;

            //Choose Language to generate word Menu
            Learn_Words_WF_Menus.ChooseModeOfGeneratingWordMenu chooseModeOfGeneratingWordMenu = new Learn_Words_WF_Menus.ChooseModeOfGeneratingWordMenu(this);
            menus.Add(chooseModeOfGeneratingWordMenu, MenuNames.ChooseModeOfGeneratingWord_Menu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.ChooseModeOfGeneratingWord_Menu.ToString());
            chooseModeOfGeneratingWordMenu.BackFrom_ChooseModeOfGeneratingMenu_Button.Click += BackFrom_ChooseModeOfGeneratingMenu_Button_Click;
            chooseModeOfGeneratingWordMenu.ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button.Click += ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button_Click;

            //Confirm deleting Menu
            Learn_Words_WF_Menus.ConfirmDeletingMenu confirmDeletingMenu = new Learn_Words_WF_Menus.ConfirmDeletingMenu(this);
            menus.Add(confirmDeletingMenu, MenuNames.ConfirmDeletingMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.ConfirmDeletingMenu.ToString());
            confirmDeletingMenu.CancelDeleting_Button.Click += CancelDeleting_Button_Click;
            confirmDeletingMenu.DeleteDictionary_Button.Click += DeleteDictionary_Button_Click;

            //End of checking Menu
            Learn_Words_WF_Menus.EndOfCheckingMenu endOfCheckingMenu = new Learn_Words_WF_Menus.EndOfCheckingMenu(this);
            menus.Add(endOfCheckingMenu, MenuNames.EndOfCheckingMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.EndOfCheckingMenu.ToString());
            endOfCheckingMenu.Continue_Button.Click += Continue_Button_In_EndOfCheckingMenu_Click;

            //Right Answer Menu
            Learn_Words_WF_Menus.RightAnswerMenu rightAnswerMenu = new Learn_Words_WF_Menus.RightAnswerMenu(this);
            menus.Add(rightAnswerMenu, MenuNames.RightAnswerMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.RightAnswerMenu.ToString());
            rightAnswerMenu.Continue_Button.Click += Continue_Button_In_RightAnswerMenu_Click;

            //Show Dictionaries Menu
            Learn_Words_WF_Menus.ShowDictionariesListMenu showDictionariesListMenu = new Learn_Words_WF_Menus.ShowDictionariesListMenu(this);
            menus.Add(showDictionariesListMenu, MenuNames.ShowDictionariesListMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.ShowDictionariesListMenu.ToString());
            showDictionariesListMenu.BackFromShowAddedDictionariesMenu_Button.Click += BackFromShowAddedDictionariesMenu_Button_Click;
            showDictionariesListMenu.EnterDictionaryName_ListBox.DoubleClick += EnterDictionaryName_ListBox_DoubleClick;
            showDictionariesListMenu.EnterDictionaryName_ListBox.KeyUp += EnterDictionaryName_ListBox_KeyPress;
            showDictionariesListMenu.EnterDictionaryName_ListBox.GotFocus += EnterDictionaryName_ListBox_GotFocus;
            showDictionariesListMenu.EnterDictionaryName_ListBox.LostFocus += EnterDictionaryName_ListBox_LostFocus;

            //Wrong Answer Menu
            Learn_Words_WF_Menus.WrongAnswerMenu wrongAnswerMenu = new Learn_Words_WF_Menus.WrongAnswerMenu(this);
            menus.Add(wrongAnswerMenu, MenuNames.WrongAnswerMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.WrongAnswerMenu.ToString());
            wrongAnswerMenu.Continue_Button.Click += Continue_Button_In_WrongAnswerMenu_Click;

            //Choosing Answer from options Menu
            Learn_Words_WF_Menus.ChoosingAnswersMenu choosingAnswersMenu = new Learn_Words_WF_Menus.ChoosingAnswersMenu(this);
            menus.Add(choosingAnswersMenu, MenuNames.ChoosingAnswersMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.ChoosingAnswersMenu.ToString());
            foreach (var button in choosingAnswersMenu.Answers)
            {
                button.Click += AnswerButton_In_ChoosingAnswerMenu_Button_Click;
            }
            choosingAnswersMenu.BackFromChoosingAnswersMenu_Button.Click += BackFromChoosingAnswersMenu_Button_Click;

            //Show content of the dictionary Menu
            Learn_Words_WF_Menus.ShowContentOfTheDictionaryMenu showContentOfTheDictionaryMenu = new Learn_Words_WF_Menus.ShowContentOfTheDictionaryMenu(this);
            menus.Add(showContentOfTheDictionaryMenu, MenuNames.ShowContentOfTheDictionaryMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.ShowContentOfTheDictionaryMenu.ToString());
            showContentOfTheDictionaryMenu.CenterElementsOfMenu();
            showContentOfTheDictionaryMenu.BackFromShowContentOfTheDictionary_Button.Click += BackFromShowContentOfTheDictionary_Button_Click;

            //CreateNewDictionaryMenu
            CreateNewDictionaryMenu createNewDictionaryMenu = new CreateNewDictionaryMenu(this);
            menus.Add(createNewDictionaryMenu, MenuNames.CreateNewDictionaryMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.CreateNewDictionaryMenu.ToString());
            createNewDictionaryMenu.CreateNewDictionary_Button.Click += CreateNewDictionary_Button_Click;
            createNewDictionaryMenu.ChooseNameForTheNewDictionary_TextBox.TextChanged += TextBoxesInCreateNewDictionaryMenu_TextChanged;
            createNewDictionaryMenu.ChoosePlaceWhereNeedToCreateNewDictionary_TextBox.TextChanged += TextBoxesInCreateNewDictionaryMenu_TextChanged;
            createNewDictionaryMenu.WriteNameOfTheNewDictionaryTXTFile_TextBox.TextChanged += TextBoxesInCreateNewDictionaryMenu_TextChanged;
            createNewDictionaryMenu.BackFromCreateDictionaryMenu_Button.Click += BackFromCreateDictionaryMenu_Button_Click;

            //ChooseHowToAddDictionaryMenu
            ChooseHowToAddDictionaryMenu chooseHowToAddDictionaryMenu = new ChooseHowToAddDictionaryMenu(this);
            menus.Add(chooseHowToAddDictionaryMenu, MenuNames.ChooseHowToAddDictionaryMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.ChooseHowToAddDictionaryMenu.ToString());
            chooseHowToAddDictionaryMenu.CreateNewDictionaryMenu_Button.Click += CreateNewDictionaryMenu_Button_Click;
            chooseHowToAddDictionaryMenu.AddDictionaryMenu_Button.Click += AddAddDictionaryMenu_Button_Click;
            chooseHowToAddDictionaryMenu.BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button.Click +=
                BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button_Click;

            //Edit Dictionary Menu
            Learn_Words_WF_Menus.EditDictionaryMenu editDictionary_Menu = new Learn_Words_WF_Menus.EditDictionaryMenu(this);
            menus.Add(editDictionary_Menu, MenuNames.EditDictionaryMenu.ToString());
            menus.LoadControlsOfMenuToTheForm(MenuNames.EditDictionaryMenu.ToString());
            editDictionary_Menu.BackFromEditDictionariesMenu_Button.Click += BackFromEditDictionariesMenu_Button_Click;
            editDictionary_Menu.ChooseDictionaryToEdit_ListBox.DoubleClick += ChooseDictionaryToEdit_ListBox_DoubleClick;
            editDictionary_Menu.ChooseDictionaryToEdit_ListBox.KeyUp += ChooseDictionaryToEdit_ListBox_KeyUp;
            editDictionary_Menu.ChooseDictionaryToEdit_ListBox.GotFocus += ChooseDictionaryToEdit_ListBox_GotFocus;
            editDictionary_Menu.ChooseDictionaryToEdit_ListBox.LostFocus += ChooseDictionaryToEdit_ListBox_LostFocus;
        }

        private void BackFromChooseHowYouWouldLikeToAddDictionaryMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ChooseHowToAddDictionaryMenu.ToString()];
            menu.Hide();

            menu = menus.List[MenuNames.DictionariesMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            //menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void ChooseDictionaryToEdit_ListBox_DoubleClick(object sender, EventArgs e)
        {
            Learn_Words_WF_Menus.EditDictionaryMenu menu = (Learn_Words_WF_Menus.EditDictionaryMenu)menus.List[MenuNames.EditDictionaryMenu.ToString()];
            int index = menu.ChooseDictionaryToEdit_ListBox.SelectedIndex;
            if (index != -1)
            {
                string dictionaryName = menu.ChooseDictionaryToEdit_ListBox.SelectedItem.ToString();

                string dictionaryFilePath = dictionaries.GetAdressOfDictionaryFileWithName(dictionaryName);
                dictionaryFilePath = dictionaryFilePath.Replace("\r", "");
                menu.ChooseDictionaryToEdit_ListBox.SetSelected(index, false);

                System.Diagnostics.Process.Start("notepad.exe", dictionaryFilePath);
            }
        }

        private void ChooseDictionaryToEdit_ListBox_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                ChooseDictionaryToEdit_ListBox_DoubleClick(sender, e);
            }
        }

        private void ChooseDictionaryToEdit_ListBox_GotFocus(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            listBox.SelectedIndex = 0;
        }

        private void ChooseDictionaryToEdit_ListBox_LostFocus(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            listBox.SelectedIndex = -1;
        }

        private void EditDictionary_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.DictionariesMenu.ToString()];
            menu.Hide();
            
            FillListBoxInEditDictionaryMenu();
            menu = menus.List[MenuNames.EditDictionaryMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void FillListBoxInEditDictionaryMenu()
        {
            Learn_Words_WF_Menus.EditDictionaryMenu editDictionaryMenu = (Learn_Words_WF_Menus.EditDictionaryMenu)menus.List[MenuNames.EditDictionaryMenu.ToString()];
            string[] dictionariesNames = dictionaries.GetDictionariesNames();
            for (int i = 0; i < dictionariesNames.Length; i++)
            {
                editDictionaryMenu.ChooseDictionaryToEdit_ListBox.Items.Add(dictionariesNames[i]);
            }
        }

        private void BackFromEditDictionariesMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.EditDictionaryMenu.ToString()];
            menu.Hide();

            menu = menus.List[MenuNames.DictionariesMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            //menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void BackFromCreateDictionaryMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.CreateNewDictionaryMenu.ToString()];
            menu.Hide();

            menu = menus.List[MenuNames.ChooseHowToAddDictionaryMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void AddAddDictionaryMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ChooseHowToAddDictionaryMenu.ToString()];
            menu.Hide();

            menu = menus.List[MenuNames.AddDictionaryMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void CreateNewDictionaryMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ChooseHowToAddDictionaryMenu.ToString()];
            menu.Hide();

            menu = menus.List[MenuNames.CreateNewDictionaryMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void TextBoxesInCreateNewDictionaryMenu_TextChanged(object sender, EventArgs e)
        {
            CreateNewDictionaryMenu menu = (CreateNewDictionaryMenu)menus.List[MenuNames.CreateNewDictionaryMenu.ToString()];
            if(menu.ChooseNameForTheNewDictionary_TextBox.Text == "" || 
                menu.ChoosePlaceWhereNeedToCreateNewDictionary_TextBox.Text == ""||
                menu.WriteNameOfTheNewDictionaryTXTFile_TextBox.Text == "")
            {
                menu.CreateNewDictionary_Button.Enabled = false;
            }
            else
            {
                menu.CreateNewDictionary_Button.Enabled = true;
            }
        }

        private void CreateNewDictionary_Button_Click(object sender, EventArgs e)
        {
            CreateNewDictionaryMenu menu = (CreateNewDictionaryMenu)menus.List[MenuNames.CreateNewDictionaryMenu.ToString()];
            string filePath = menu.ChoosePlaceWhereNeedToCreateNewDictionary_TextBox.Text + "\\" +
                menu.WriteNameOfTheNewDictionaryTXTFile_TextBox.Text + ".txt";
            string dictionaryName = menu.ChooseNameForTheNewDictionary_TextBox.Text;
            File.Create(filePath).Close();
            dictionaries.AddDictionary(filePath, dictionaryName);

            menu.Hide();

            ControlMenu menuToGo = menus.List[MenuNames.DictionariesMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menuToGo);
            menuToGo.CenterElementsOfMenu();
            menuToGo.Show();

            MessageBox.Show("Словарь был успешно создан");
        }

        private void BackFromShowContentOfTheDictionary_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ShowContentOfTheDictionaryMenu.ToString()];
            menu.Hide();
            menu = menus.List[MenuNames.ShowDictionariesListMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.Show();
        }

        private void EnterDictionaryName_ListBox_DoubleClick(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ShowDictionariesListMenu.ToString()];
            Learn_Words_WF_Menus.ShowDictionariesListMenu showDictionariesListMenu = (Learn_Words_WF_Menus.ShowDictionariesListMenu)menu;
            int index = showDictionariesListMenu.EnterDictionaryName_ListBox.SelectedIndex;
            if (index != -1)
            {
                string dictionaryName = showDictionariesListMenu.EnterDictionaryName_ListBox.SelectedItem.ToString();
                showDictionariesListMenu.EnterDictionaryName_ListBox.SetSelected(index, false);
                menu.Hide();
                Fill_ListBoxIn_ShowContentOfTheDictionaryMenu(dictionaryName);
                menu = menus.List[MenuNames.ShowContentOfTheDictionaryMenu.ToString()];
                workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
                menu.CenterElementsOfMenu();
                menu.Show();
            }
            else
            {
                showDictionariesListMenu.EnterDictionaryName_TextBox.Select();
            }
        }

        private void EnterDictionaryName_ListBox_KeyPress(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                EnterDictionaryName_ListBox_DoubleClick(sender, e);
            }
        }

        private void EnterDictionaryName_ListBox_GotFocus(object sender, EventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            listbox.SelectedIndex = 0;
        }

        private void EnterDictionaryName_ListBox_LostFocus(object sender, EventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            listbox.SelectedIndex = -1;
        }

        private void Fill_ListBoxIn_ShowContentOfTheDictionaryMenu(string dictionaryName)
        {
            Learn_Words_WF_Menus.ShowContentOfTheDictionaryMenu menu = (Learn_Words_WF_Menus.ShowContentOfTheDictionaryMenu)menus.List[MenuNames.ShowContentOfTheDictionaryMenu.ToString()];
            menu.DictionaryName_Label.Text = dictionaryName;
            string[] content = dictionaries.LoadDictionary(dictionaryName).ToString().Split('\n');
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i].Contains(" - "))
                {
                    menu.DictionaryContent_ListBox.Items.Add(content[i]);
                }
            }
        }

        private void BackFromChoosingAnswersMenu_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите закончить тестирование?", "Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                ControlMenu menu = menus.List[MenuNames.ChoosingAnswersMenu.ToString()];
                menu.Hide();

                workingWithForm.HeightFromWall = 50;

                menu = menus.List[MenuNames.ChooseModeOfGeneratingWord_Menu.ToString()];
                workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
                menu.Show();
            }
        }

        private void AnswerButton_In_ChoosingAnswerMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ChoosingAnswersMenu.ToString()];
            menu.Hide();

            workingWithForm.HeightFromWall = 50;

            Learn_Words_WF_Menus.ChoosingAnswersMenu choosingAnswersMenu = (Learn_Words_WF_Menus.ChoosingAnswersMenu)menu;
            string generatedWord = choosingAnswersMenu.WordToTranslate_Label.Text;

            if (wordsCheckingSystem.CheckAnswer(((Button)sender).Text))
            {
                menu = menus.List[MenuNames.RightAnswerMenu.ToString()];
            }
            else
            {
                menu = menus.List[MenuNames.WrongAnswerMenu.ToString()];

                menu.Elements[2].Controls[0].Text = generatedWord;
                menu.Elements[4].Controls[0].Text = ((Button)sender).Text;
                menu.Elements[6].Controls[0].Text = wordsCheckingSystem.GetRightAnswer();
            }

            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void ChooseFromOptions_Button_Click(object sender, EventArgs e)
        {
            modeOfChecking = ModeOfChecking.ChooseAnswer;

            wordsCheckingSystem = new ChooseWriteAnswerWordsCheckingSystem(dictionaries);

            FillChooseDictionaryToLearn_ComboBox();
            ControlMenu menu = menus.List[MenuNames.ChooseHowYouWouldLikeToEnterAnswersMenu.ToString()];
            menu.Hide();
            menu = menus.List[MenuNames.ChooseDictionaryToLearn_Menu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void FillAnswersInChoosingAnswersMenu()
        {
            ChooseWriteAnswerWordsCheckingSystem wordsChecking = (ChooseWriteAnswerWordsCheckingSystem)wordsCheckingSystem;
            Learn_Words_WF_Menus.ChoosingAnswersMenu menu = (Learn_Words_WF_Menus.ChoosingAnswersMenu)menus.List[MenuNames.ChoosingAnswersMenu.ToString()];
            
            menu.WordToTranslate_Label.Text = wordsChecking.GenerateWord();
            string[] answers = wordsChecking.GenerateAnswers();
            for (int i = 0; i < menu.Answers.Count; i++)
            {
                menu.Answers[i].Text = answers[i];
            }

            menu.FixAnswersLocations();

            workingWithForm.HeightFromWall = 20;
        }

        private void DeleteDictionary_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ConfirmDeletingMenu.ToString()];
            string dictionaryName = menu.Elements[1].Controls[0].Text;
            dictionaries.RemoveDictionary(dictionaryName);
            menu.Hide();
            menu = menus.List[MenuNames.DeleteDictionaryMenu.ToString()];
            ((ListBox)menu.Elements[2].Controls[0]).Items.Remove(dictionaryName);
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
            ShowMessageThatDictionaryWasSuccessfulDeleted();
        }

        private void ShowMessageThatDictionaryWasSuccessfulDeleted()
        {
            MessageBox.Show("Словарь был успешно удален");
        }

        private void CancelDeleting_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ConfirmDeletingMenu.ToString()];
            menu.Hide();
            menu = menus.List[MenuNames.DeleteDictionaryMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void ChooseDictionaryToDelete_ListBox_DoubleClick(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.DeleteDictionaryMenu.ToString()];
            Learn_Words_WF_Menus.DeleteDictionaryMenu deleteDictionaryMenu = (Learn_Words_WF_Menus.DeleteDictionaryMenu)menu;
            //string dictionaryNameToDelete = ((ListBox)(menu.Elements[2].Controls[0])).SelectedItem.ToString();
            int index = deleteDictionaryMenu.ChooseDictionaryToDelete_ListBox.SelectedIndex;
            if (index != -1)
            {
                string dictionaryNameToDelete = deleteDictionaryMenu.ChooseDictionaryToDelete_ListBox.SelectedItem.ToString();
                deleteDictionaryMenu.ChooseDictionaryToDelete_ListBox.SetSelected(index, false);
                //((ListBox)(menu.Elements[2].Controls[0])).ClearSelected();
                menu.Hide();

                menu = menus.List[MenuNames.ConfirmDeletingMenu.ToString()];
                menu.Elements[1].Controls[0].Text = dictionaryNameToDelete;
                workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
                menu.CenterElementsOfMenu();
                menu.Show();
            }
            else
            {
                deleteDictionaryMenu.Elements[1].Controls[0].Select();
            }
        }

        private void ChooseDictionaryToDelete_ListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ChooseDictionaryToDelete_ListBox_DoubleClick(sender, e);
            }
        }

        private void ChooseDictionaryToDelete_ListBox_GotFocus(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            listBox.SelectedIndex = 0;
        }

        private void ChooseDictionaryToDelete_ListBox_LostFocus(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            listBox.SelectedIndex = -1;
        }

        private void Continue_Button_In_EndOfCheckingMenu_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.EndOfCheckingMenu.ToString()];
            menu.Hide();

            menu = menus.List[MenuNames.ChooseDictionaryToLearn_Menu.ToString()];
            menu.Clear();
            menu = menus.List[MenuNames.ChooseModeOfGeneratingWord_Menu.ToString()];
            menu.Clear();

            menu = menus.List[MenuNames.MainMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void Continue_Button_In_RightAnswerMenu_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.RightAnswerMenu.ToString()];
            menu.Hide();

            if (modeOfChecking == ModeOfChecking.WriteAnswer)
            {
                WordsCheckingSystem wordsChecking = (WordsCheckingSystem)wordsCheckingSystem;
                string generatedWord = wordsChecking.GenerateWord();
                if (generatedWord != "There are no words")
                {
                    menu = menus.List[MenuNames.CheckingWord_Menu.ToString()];

                    menu.Elements[0].Controls[0].Text = generatedWord;

                    workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
                    menu.CenterElementsOfMenu();
                    menu.Show();
                }
                else
                {
                    menu = menus.List[MenuNames.EndOfCheckingMenu.ToString()];
                    workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
                    menu.CenterElementsOfMenu();
                    menu.Show();
                }
            }
            else
            {
                ChooseWriteAnswerWordsCheckingSystem wordsChecking = (ChooseWriteAnswerWordsCheckingSystem)wordsCheckingSystem;
                string generatedWord = wordsChecking.GenerateWord();
                if (generatedWord != "There are no words")
                {
                    menu = menus.List[MenuNames.ChoosingAnswersMenu.ToString()];
                    FillAnswersInChoosingAnswersMenu();
                }
                else
                {
                    menu = menus.List[MenuNames.EndOfCheckingMenu.ToString()];    
                }

                workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
                menu.CenterElementsOfMenu();
                menu.Show();
            }
        }

        private void Continue_Button_In_WrongAnswerMenu_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.WrongAnswerMenu.ToString()];
            menu.Hide();

            if (modeOfChecking == ModeOfChecking.WriteAnswer)
            {
                menu = menus.List[MenuNames.CheckingWord_Menu.ToString()];

                WordsCheckingSystem wordsChecking = (WordsCheckingSystem)wordsCheckingSystem;
                menu.Elements[0].Controls[0].Text = wordsChecking.GenerateWord();
            }
            else
            {
                menu = menus.List[MenuNames.ChoosingAnswersMenu.ToString()];
                FillAnswersInChoosingAnswersMenu();
            }

            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void CheckUsersInput_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.CheckingWord_Menu.ToString()];
            menu.Hide();

            string generatedWord = menu.Elements[0].Controls[0].Text;
            string usersInput = menu.Elements[1].Controls[0].Text;

            menu.Clear();

            if (wordsCheckingSystem.CheckAnswer(usersInput))
            {
                menu = menus.List[MenuNames.RightAnswerMenu.ToString()];
            }
            else
            {
                menu = menus.List[MenuNames.WrongAnswerMenu.ToString()];
                menu.Elements[2].Controls[0].Text = generatedWord;
                menu.Elements[4].Controls[0].Text = usersInput;
                menu.Elements[6].Controls[0].Text = wordsCheckingSystem.GetRightAnswer();
            }

            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void BackFromCheckingWordMenu_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите закончить тестирование?", "Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                ControlMenu menu = menus.List[MenuNames.CheckingWord_Menu.ToString()];
                menu.Clear();
                menu.Hide();

                menu = menus.List[MenuNames.ChooseModeOfGeneratingWord_Menu.ToString()];
                workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
                menu.CenterElementsOfMenu();
                menu.Show();
            }
        }

        private void ChooseFromWhichLanguageWouldYouLikeToGenerateWords_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ChooseModeOfGeneratingWord_Menu.ToString()];

            wordsCheckingSystem.ModeOfGenerating = (Mode)((System.Windows.Forms.ComboBox)menu.Elements[1].Controls[0]).SelectedIndex;

            menu.Hide();

            if (modeOfChecking == ModeOfChecking.WriteAnswer)
            {
                menu = menus.List[MenuNames.CheckingWord_Menu.ToString()];

                WordsCheckingSystem wordsChecking = (WordsCheckingSystem)wordsCheckingSystem;
                menu.Elements[0].Controls[0].Text = wordsChecking.GenerateWord();

                workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
                menu.CenterElementsOfMenu();
                menu.Show();
            }
            else
            {
                menu = menus.List[MenuNames.ChoosingAnswersMenu.ToString()];

                workingWithForm.HeightFromWall = 20;

                Learn_Words_WF_Menus.ChoosingAnswersMenu choosingAnswersMenu = (Learn_Words_WF_Menus.ChoosingAnswersMenu)menu;

                ChooseWriteAnswerWordsCheckingSystem wordsChecking = (ChooseWriteAnswerWordsCheckingSystem)wordsCheckingSystem;

                choosingAnswersMenu.WordToTranslate_Label.Text = wordsChecking.GenerateWord();
                
                string[] answers = wordsChecking.GenerateAnswers();
                for (int i = 0; i < choosingAnswersMenu.Answers.Count; i++)
                {
                    choosingAnswersMenu.Answers[i].Text = answers[i];
                }

                choosingAnswersMenu.FixAnswersLocations();

                workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
                menu.CenterElementsOfMenu();
                menu.Show();
            }
        }

        private void BackFrom_ChooseModeOfGeneratingMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ChooseModeOfGeneratingWord_Menu.ToString()];
            menu.Hide();
            menu.Clear();
            menu = menus.List[MenuNames.ChooseDictionaryToLearn_Menu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void ChooseDictionaryToLearn_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ChooseDictionaryToLearn_Menu.ToString()];
            wordsCheckingSystem.LoadDictionary(((System.Windows.Forms.ComboBox)menu.Elements[1].Controls[0]).SelectedItem.ToString());
            FillChooseModeOfGenerating_ComboBox();
            menu.Hide();
            menu = menus.List[MenuNames.ChooseModeOfGeneratingWord_Menu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void FillChooseModeOfGenerating_ComboBox()
        {
            ControlMenu menu = menus.List[MenuNames.ChooseModeOfGeneratingWord_Menu.ToString()];
            string[] modes = new string[] { "Из первого", "Из второго", "Из обоих" };
            for (int i = 0; i < modes.Length; i++)
            {
                ((System.Windows.Forms.ComboBox)menu.Elements[1].Controls[0]).Items.Add(modes[i]);
            }
        }

        private void BackFromChooseDictionaryToLearn_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ChooseDictionaryToLearn_Menu.ToString()];
            menu.Hide();
            menu.Clear();
            menu = menus.List[MenuNames.ChooseHowYouWouldLikeToEnterAnswersMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void EnterByMySelf_Button_Click(object sender, EventArgs e)
        {
            modeOfChecking = ModeOfChecking.WriteAnswer;

            wordsCheckingSystem = new WordsCheckingSystem(dictionaries);

            FillChooseDictionaryToLearn_ComboBox();
            ControlMenu menu = menus.List[MenuNames.ChooseHowYouWouldLikeToEnterAnswersMenu.ToString()];
            menu.Hide();
            menu = menus.List[MenuNames.ChooseDictionaryToLearn_Menu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void FillChooseDictionaryToLearn_ComboBox()
        {
            ControlMenu menu = menus.List[MenuNames.ChooseDictionaryToLearn_Menu.ToString()];
            string[] names = wordsCheckingSystem.Dictionaries.GetDictionariesNames();
            for (int i = 0; i < names.Length; i++)
            {
                ((System.Windows.Forms.ComboBox)menu.Elements[1].Controls[0]).Items.Add(names[i]);
            }
        }

        private void AddDictionary_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.AddDictionaryMenu.ToString()];

            dictionaries.AddDictionary(menu.Elements[1].Controls[0].Text,
                menu.Elements[3].Controls[0].Text);

            menu.Hide();
            menu.Clear();

            menu = menus.List[MenuNames.DictionariesMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();

            ShowMessageThatDictionaryWasSuccessfulAdded();
        }

        private void ShowMessageThatDictionaryWasSuccessfulAdded()
        {
            MessageBox.Show("Словарь добавлен");
        }

        private void BackFromAddDictionaryMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.AddDictionaryMenu.ToString()];
            menu.Hide();
            menu.Clear();
            menu = menus.List[MenuNames.ChooseHowToAddDictionaryMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void BackFromDeleteDictionariesMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.DeleteDictionaryMenu.ToString()];
            menu.Hide();
            menu.Clear();
            menu = menus.List[MenuNames.DictionariesMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void BackFromShowAddedDictionariesMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ShowDictionariesListMenu.ToString()];
            menu.Hide();
            menu.Clear();
            menu = menus.List[MenuNames.DictionariesMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void TestingMenu_Button_Click(object sender, EventArgs e)
        {
            if (dictionaries.Count > 0)
            {
                ControlMenu menu = menus.List[MenuNames.MainMenu.ToString()];
                menu.Hide();
                menu = menus.List[MenuNames.ChooseHowYouWouldLikeToEnterAnswersMenu.ToString()];
                workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
                menu.CenterElementsOfMenu();
                menu.Show();
            }
            else
            {
                ShowMessageThatCountOfDictionariesIsZero();
            }
        }

        private void ShowMessageThatCountOfDictionariesIsZero()
        {
            MessageBox.Show("У вас нет словарей для изучения\nДобавьте сначала, пожалуйста, словарь");
        }

        private void DictionariesMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.MainMenu.ToString()];
            menu.Hide();
            menu = menus.List[MenuNames.DictionariesMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void BackFromDictionariesMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.DictionariesMenu.ToString()];
            menu.Hide();
            menu = menus.List[MenuNames.MainMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void BackFromChooseHowYouWouldLikeToEnterAnswersMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.ChooseHowYouWouldLikeToEnterAnswersMenu.ToString()];
            menu.Hide();
            menu = menus.List[MenuNames.MainMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void DeleteDictionaryMenu_Button_Click(object sender, EventArgs e)
        {
            if (dictionaries.Count > 0)
            {
                ControlMenu menu = menus.List[MenuNames.DictionariesMenu.ToString()];
                menu.Hide();
                FillListBoxInDeleteDictionaryMenu();
                menu = menus.List[MenuNames.DeleteDictionaryMenu.ToString()];
                workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
                menu.CenterElementsOfMenu();
                menu.Show();
            }
            else
            {
                ShowMessageThatCountOfDictionariesIsZero();
            }
        }

        private void FillListBoxInDeleteDictionaryMenu()
        {
            ControlMenu menu = menus.List[MenuNames.DeleteDictionaryMenu.ToString()];
            string[] names = dictionaries.GetDictionariesNames();
            ListBox listBox = (ListBox)(menu.Elements[2].Controls[0]);
            for (int i = 0; i < names.Length; i++)
            {
                listBox.Items.Add(names[i]);
            }
        }

        private void AddDictionaryMenu_Button_Click(object sender, EventArgs e)
        {
            ControlMenu menu = menus.List[MenuNames.DictionariesMenu.ToString()];
            menu.Hide();
            menu = menus.List[MenuNames.ChooseHowToAddDictionaryMenu.ToString()];
            workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
            menu.CenterElementsOfMenu();
            menu.Show();
        }

        private void ShowAddedDictionaries_Button_Click(object sender, EventArgs e)
        {
            if (dictionaries.Count > 0)
            {
                ControlMenu menu = menus.List[MenuNames.DictionariesMenu.ToString()];
                menu.Hide();
                menu = menus.List[MenuNames.ShowDictionariesListMenu.ToString()];
                FillShowAddedDictionariesListBox();
                workingWithForm.ChangeSizeAndLocationOfFormForMenu(menu);
                menu.CenterElementsOfMenu();
                menu.Show();
            }
            else
            {
                ShowMessageThatCountOfDictionariesIsZero();
            }
        }

        private void FillShowAddedDictionariesListBox()
        {
            ControlMenu menu = menus.List[MenuNames.ShowDictionariesListMenu.ToString()];
            string[] dictionariesNames = dictionaries.GetDictionariesNames();
            ListBox listBox = (ListBox)(menu.Elements[2].Controls[0]);
            for (int i = 0; i < dictionariesNames.Length; i++)
            {
                listBox.Items.Add(dictionariesNames[i]);
            }
        }
    }
}