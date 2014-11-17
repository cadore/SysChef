using System;
using System.Drawing;

namespace SYS_CHEF.UI.Buttons
{
    public class ButtonEdit : SysButtonUtil
    {
        public ButtonEdit()
        {            
            this.Image = (Image)SYS_CHEF.Properties.Resources.Edit_16x16;
            this.Text = "Editar";
        }
    }
}
