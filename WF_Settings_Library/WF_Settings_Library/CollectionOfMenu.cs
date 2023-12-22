using System.Collections.Generic;
using System.Windows.Forms;

namespace WF_Settings_Library
{
    public class CollectionOfMenu
    {
        WorkingWithForm formSettings;
        Form forma;

        public ControlMenu ActiveMenu;

        public Dictionary<string, ControlMenu> menuList;

        public CollectionOfMenu(Form form)
        {
            forma = form;
            formSettings = new WorkingWithForm(form);
            formSettings.WidthFromWall = 50;
            formSettings.HeightFromWall = 60;

            menuList = new Dictionary<string, ControlMenu>();
        }

        public void Create_And_Add_Menu(string menuName, Element[] elements)
        {
            ControlMenu menu = InitializeMenu();
            menu.Name = menuName;
            AddControlsToMenu(menu, elements);
            AddMenu(menu, menuName);
        }

        public void Create_And_Add_Menu(string menuName, Element[] elements, Control controlToSelect)
        {
            Create_And_Add_Menu(menuName, elements);
            menuList[menuName].controlToSelect = controlToSelect;
        }

        public void Create_And_Add_Menu(string menuName, Element[] elements, bool IsThisMainMenu)
        {
            Create_And_Add_Menu(menuName, elements);
            ActiveMenu = menuList[menuName];
        }

        public void AddMenu(ControlMenu menu, string menuName)
        {
            menuList.Add(menuName, menu);
        }

        private void AddControlsToMenu(ControlMenu menu, Element[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                menu.Add(elements[i]);
            }
        }

        private ControlMenu InitializeMenu()
        {
            return new ControlMenu();
        }

        public void MoveAllControlsOfMenuUpToTheRightTop(ControlMenu menu)
        {
            int widthToMove = menu.Elements[0].Top - formSettings.HeightFromWall;

            for (int i = 0; i < menu.CountOfElements; i++)
            {
                menu.Elements[i].Top -= widthToMove;
            }
        }

        private void CenterControlsOfMenu(ControlMenu menu)
        {
            Element firstElement = menu.Elements[0];
            LocateControlCenterToForm(firstElement);
            menu.CenterElements();
        }

        private void LocateControlCenterToForm(Element element)
        {
            element.Left = forma.ClientSize.Width / 2 - element.Width / 2;
        }                           

        public void GoToMenu(string newActiveMenu, Control controlToSelect)
        {
            ControlMenu menu = menuList[newActiveMenu];

            formSettings.ChangeSizeAndLocationOfFormForMenu(menu);

            CenterControlsOfMenu(menu);
            MoveAllControlsOfMenuUpToTheRightTop(menu);

            ActiveMenu.Hide();
            menu.Show();
            ActiveMenu = menu;

            controlToSelect.Select();
        }

        public void GoToMenu(string newActiveMenu)
        {
            GoToMenu(newActiveMenu, menuList[newActiveMenu].controlToSelect);
        }
    }
}
