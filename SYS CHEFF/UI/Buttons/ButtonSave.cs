using System;
using System.Drawing;

namespace SYS_CHEF.UI.Buttons
{
    public class ButtonSave : SysButtonUtil
    {
        public ButtonSave()
        {
            this.Text = "Salvar";
            this.Image = (Image)SYS_CHEF.Properties.Resources.Save_16x16;
        }
    }
}
