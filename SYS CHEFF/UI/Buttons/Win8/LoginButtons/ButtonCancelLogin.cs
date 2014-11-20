using System;
using System.Drawing;

namespace SYS_CHEF.UI.Buttons.Win8.LoginButtons
{
    public class ButtonCancelLogin : SysButtonUtil
    {
        public ButtonCancelLogin()
        {
            this.Text = "Cancelar";
            this.Image = (Image)SYS_CHEF.Properties.Resources.Win8Cancel;
            this.BackColor = Color.FromArgb(0, 117, 199);
            this.ForeColor = Color.White;
        }
    }
}
