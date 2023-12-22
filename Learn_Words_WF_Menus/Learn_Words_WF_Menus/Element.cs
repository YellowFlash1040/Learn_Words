using System.Collections.Generic;
using System.Windows.Forms;

namespace Learn_Words_WF_Menus
{
    public class Element
    {
        public List<Control> Controls;

        private int width;
        public int Width
        {
            get
            {
                //return width;
                return Controls[Controls.Count - 1].Left + Controls[Controls.Count - 1].Width - Controls[0].Left;
            }
        }

        private bool visible;
        public bool Visible
        {
            get
            {
                return visible;
            }

            set
            {
                visible = value;

                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].Visible = visible;
                }
            }
        }

        private int left;
        public int Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;

                int widthToMove = Controls[0].Left - value;

                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].Left -= widthToMove;
                }
            }
        }

        private int top;
        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;

                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].Top -= Controls[i].Top - value;
                }
            }
        }

        private int height;
        public int Height
        {
            get
            {
                return height;
            }
        }


        public Element(List<Control> controls)
        {
            Controls = controls;
            SetWidth();
            SetHeight();
            SetLeft();
            SetTop();
        }

        public Element(Control control) : this(new List<Control>() { control })
        {

        }

        private void SetHeight()
        {
            int maxHeight = Controls[0].Height;
            for (int i = 1; i < Controls.Count; i++)
            {
                if (Controls[i].Height > maxHeight)
                {
                    maxHeight = Controls[i].Height;
                }
            }

            height = maxHeight;
        }

        private void SetTop()
        {
            Top = Controls[0].Top;
        }

        private void SetLeft()
        {
            left = Controls[0].Left;
        }

        private void SetWidth()
        {
            width = Controls[Controls.Count - 1].Left + Controls[Controls.Count - 1].Width - Controls[0].Left;
        }
    }
}