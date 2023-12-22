using System.Windows.Forms;
using WF_Settings_Library;

namespace LearnWords_WF
{
    public partial class MainMenu : Form
    {
        CollectionOfMenu menus;
        public MainMenu()
        {
            InitializeComponent();

            menus = new CollectionOfMenu(this);
            menus.Create_And_Add_Menu("MainMenu", new Element[]{
                new Element(TestingMenu_Button), new Element(DictionariesMenu_Button), new Element(SettingsMenu_Button)
            }, true);

            menus.GoToMenu("MainMenu", TestingMenu_Button);
        }

        private void TestingMenu_Button_Click(object sender, System.EventArgs e)
        {
            //StreamWriter streamWriter = new StreamWriter("C:\\Users\\kovtu\\Downloads\\Locations\\MainMenu.txt");
            //streamWriter.WriteLine($"{this.Size.ToString()}");
            //for (int i = 0; i < menus.menuList["MainMenu"].Elements.Count; i++)
            //{
            //    streamWriter.WriteLine($"{menus.menuList["MainMenu"].Elements[i].Left}; {menus.menuList["MainMenu"].Elements[i].Top}");
            //}
            //streamWriter.Close();
        }

        public ControlMenu Create()
        {
            Element[] elements = new Element[3];

            elements[0] = new Element(TestingMenu_Button);
            elements[1] = new Element(DictionariesMenu_Button);
            elements[2] = new Element(SettingsMenu_Button);

            ControlMenu controlMenu = new ControlMenu(elements);
            controlMenu.controlToSelect = TestingMenu_Button;

            return controlMenu;
        }
    }
}