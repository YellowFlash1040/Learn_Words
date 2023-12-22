using System.Drawing;
using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class WorkingWithForm
    {
        private Point currentCenterPointOfForm;
        private Form form;

        private int heightFromWall;

        public int HeightFromWall
        {
            get
            {
                return heightFromWall;
            }
            set
            {
                heightFromWall = value;
            }
        }

        private int widthFromWall;

        public int WidthFromWall
        {
            get
            {
                return widthFromWall;
            }
            set
            {
                widthFromWall = value;
            }
        }

        public WorkingWithForm(Form form)
        {
            this.form = form;
        }

        private void ChangeLocatinOfForm()
        {
            int newLeft = currentCenterPointOfForm.X - form.Width / 2;
            int newTop = currentCenterPointOfForm.Y - form.Height / 2;
            form.Location = new Point(newLeft, newTop);
        }

        public void ChangeSizeAndLocationOfFormForMenu(ControlMenu newActiveMenu)
        {
            SetCurrentCenterPointOfForm();

            ChangeSizeOfFormForMenu(newActiveMenu);
            ChangeLocatinOfForm();
        }

        private void SetCurrentCenterPointOfForm()
        {
            currentCenterPointOfForm = new Point(form.Left + form.Width / 2, form.Top + form.Height / 2);
        }

        private void ChangeSizeOfFormForMenu(ControlMenu newActiveMenu)
        {
            int Width = FindRightWidthOfFormForMenu(newActiveMenu);
            int Height = FindRightHightOfFormForMenu(newActiveMenu);

            form.Size = new Size(Width, Height);
        }

        private int FindRightHightOfFormForMenu(ControlMenu menu)
        {
            int lastIndex = menu.CountOfElements - 1;

            int height = (menu.Elements[lastIndex].Top + menu.Elements[lastIndex].Height - menu.Elements[0].Top) +
                (form.Height - form.ClientSize.Height) + heightFromWall * 2;

            return height;
        }

        private int FindRightWidthOfFormForMenu(ControlMenu menu)
        {
            int indexOfControlWithBiggestWidth = 0;

            for (int i = 1; i < menu.CountOfElements; i++)
            {
                if (menu.Elements[i].Width > menu.Elements[indexOfControlWithBiggestWidth].Width)
                {
                    indexOfControlWithBiggestWidth = i;
                }
            }

            int widthOfForm = menu.Elements[indexOfControlWithBiggestWidth].Width + widthFromWall * 2;

            return widthOfForm;
        }

        public Size GetSizeOfScreen()
        {
            return Screen.PrimaryScreen.Bounds.Size;
        }
    }
}