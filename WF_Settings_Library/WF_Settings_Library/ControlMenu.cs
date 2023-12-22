using System.Collections.Generic;
using System.Windows.Forms;

namespace WF_Settings_Library
{
    public class ControlMenu
    {
        private string name;
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

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
                countOfElements = value.Count;
            }
        }

        private int countOfElements;
        public int CountOfElements
        {
            get
            {
                return countOfElements;
            }
        }

        public Control controlToSelect;

        public ControlMenu():this(new List<Element>())
        {
            
        }

        public ControlMenu(Element[] elements)
        {
            Elements = new List<Element>(elements);
        }

        public ControlMenu(List<Element> elements)
        {
            Elements = elements;
            countOfElements = 0;
        }

        public void Add(Element element)
        {
            Elements.Add(element);
            countOfElements++;
        }

        public void Hide()
        {
            for (int i = 0; i < CountOfElements; i++)
            {
                Elements[i].Visible = false;
            }
        }

        public void Show()
        {
            for (int i = 0; i < CountOfElements; i++)
            {
                Elements[i].Visible = true;
            }
        }

        public void CenterElements()
        {
            for (int i = 1; i < CountOfElements; i++)
            {
                Elements[i].Left = Elements[0].Left + (Elements[0].Width - Elements[i].Width) / 2;
            }
        }
    }
}