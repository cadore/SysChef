using System;
using System.Drawing;

namespace SYS_CHEF.UI.Buttons
{
    public class ButtonExit : SysButtonUtil
    {
        public ButtonExit()
        {
            this.Text = "Sair";
            this.Image = (Image)SYS_CHEF.Properties.Resources.Close_16x16;
        }
    }
}
