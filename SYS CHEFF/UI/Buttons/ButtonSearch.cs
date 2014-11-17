using System;
using System.Drawing;

namespace SYS_CHEF.UI.Buttons
{
    public class ButtonSearch : SysButtonUtil
    {
        public ButtonSearch()
        {
            this.Text = "Pesquisar";
            this.Image = (Image)SYS_CHEF.Properties.Resources.Find_16x16;
        }
    }
}
