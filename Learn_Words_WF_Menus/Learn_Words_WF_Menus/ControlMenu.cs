using System.Collections.Generic;
using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class ControlMenu
    {
        protected Control controlToSelect;

        Form forma;

        private List<Element> elements;
        public List<Element> Elements
        {
            get
            {
                return elements;
            }
            set
            {
                elements = value;
            }
        }

        public int CountOfElements
        {
            get
            {
                return Elements.Count;
            }
        }

        public ControlMenu(Form form)
        {
            forma = form;
            Elements = new List<Element>();
        }

        public virtual void Clear()
        {

        }

        protected virtual void CreateControls()
        {

        }

        public void CenterElementsOfMenu()
        {
            CenterElementsByLeft();
            CenterElementsByTop();
        }

        int differenceBetweenOldPositionAndNewPosition;
        private void CenterElementsByTop()
        {
            SetDifferenceBetweenOldPositionAndNewPosition();

            for (int i = 0; i < CountOfElements; i++)
            {
                Elements[i].Top = Elements[i].Top - differenceBetweenOldPositionAndNewPosition;
            }
        }

        private void SetDifferenceBetweenOldPositionAndNewPosition()
        {
            int WidthOfSumOfElements = Elements[Elements.Count - 1].Top + Elements[Elements.Count - 1].Height - Elements[0].Top;
            int newTop = forma.ClientSize.Height / 2 - WidthOfSumOfElements / 2;
            differenceBetweenOldPositionAndNewPosition = Elements[0].Top - newTop;
        }

        private void CenterElementsByLeft()
        {
            Element element = Elements[0];
            LocateControlCenterToForm(element);
            CenterOtherElementsByLeft();
        }

        private void CenterOtherElementsByLeft()
        {
            for (int i = 1; i < CountOfElements; i++)
            {
                Elements[i].Left = Elements[0].Left + (Elements[0].Width - Elements[i].Width) / 2;
            }
        }

        private void LocateControlCenterToForm(Element element)
        {
            element.Left = forma.ClientSize.Width / 2 - element.Width / 2;
        }

        public virtual void Hide()
        {
            for (int i = 0; i < CountOfElements; i++)
            {
                Elements[i].Visible = false;
            }
        }

        public virtual void Show()
        {
            for (int i = 0; i < CountOfElements; i++)
            {
                Elements[i].Visible = true;
            }
        }
    }
}