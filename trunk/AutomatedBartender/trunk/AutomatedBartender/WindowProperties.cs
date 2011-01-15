using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutomatedBartender
{
    public class WindowProperties
    {
        public static void resizeScreen(Form Window)
        {
            Window.Width = Screen.PrimaryScreen.Bounds.Width;
            Window.Height = Screen.PrimaryScreen.Bounds.Height;
            Window.FormBorderStyle = FormBorderStyle.None;
            Window.WindowState = FormWindowState.Maximized;
        }
    
    }
}
