using System;
using System.Drawing;

namespace SYS_CHEF.UI.Buttons
{
    public class ButtonAdd : SysButtonUtil
    {
        public ButtonAdd()
        {
            this.Text = "Adicionar";
            this.Image = (Image)SYS_CHEF.Properties.Resources.Add_16x16;
        }
    }
}
