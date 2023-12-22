using System.Collections.Generic;
using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class CollectionOfMenu
    {
        public Dictionary<string, ControlMenu> List;
        Form forma;
        public CollectionOfMenu(Form form)
        {
            List = new Dictionary<string, ControlMenu>();
            forma = form;
        }

        public void Add(ControlMenu menu, string menuName)
        {
            List.Add(menuName, menu);
        }

        public void LoadControlsOfMenuToTheForm(string menuName)
        {
            ControlMenu menu = List[menuName];

            for (int i = 0; i < menu.CountOfElements; i++)
            {
                for (int j = 0; j < menu.Elements[i].Controls.Count; j++)
                {
                    forma.Controls.Add(menu.Elements[i].Controls[j]);
                }
            }
        }
    }
}