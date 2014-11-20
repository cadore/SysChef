using System;
using System.Drawing;

namespace SYS_CHEF.UI.Buttons.Win8.LoginButtons
{
    public class ButtonLogin : SysButtonUtil
    {
        public ButtonLogin()
        {
            this.Text = "Login";
            this.Image = (Image)SYS_CHEF.Properties.Resources.Win8Next;
            this.BackColor = Color.FromArgb(0, 117, 199);
            this.ForeColor = Color.White;
        }
    }
}
