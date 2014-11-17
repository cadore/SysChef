using System;
using System.Drawing;

namespace SYS_CHEF.UI.Buttons
{
    public class ButtonNew : SysButtonUtil
    {
        public ButtonNew()
        {
            this.Text = "Novo";
            this.Image = (Image)SYS_CHEF.Properties.Resources.New_16x16;
        }
    }
}
