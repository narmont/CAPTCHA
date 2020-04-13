using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CAPTCHA
{
    public abstract class ToolsClass
    {
        protected PictureBox forma;
        protected ToolStrip toolBar;
        public static object SelectedItem { get; set; }
        public static int SelectedValue { get; set; }

        public static MouseButtons mouseDown = MouseButtons.None;
        public static Color mainColor { get; set; }
        public static Color backColor { get; set; }
        public static Color MainPict { get; set; }
        public static Color AnotherPict { get; set; }

        public ToolsClass(PictureBox forma) {

            this.forma = forma;
        }

        public abstract void Draw(List<TwoPoints> m_list, Point point1, Point point2, Graphics e = null); 
 
    }
}
