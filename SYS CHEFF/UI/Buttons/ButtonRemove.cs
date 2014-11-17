using System;
using System.Drawing;

namespace SYS_CHEF.UI.Buttons
{
    public class ButtonRemove : SysButtonUtil
    {
        public ButtonRemove()
        {
            this.Text = "Remover";
            this.Image = (Image)SYS_CHEF.Properties.Resources.Remove_16x16;
        }
    }
}
