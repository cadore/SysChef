using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS_CHEF.Utils
{
    public class Centraliza
    {
        private static Point centralizaUserControl(PanelControl p, Control u)
        {
            Point point = new Point((p.ClientSize.Width - u.Width) / 2, (p.ClientSize.Height - u.Height) / 2);
            return point;
        }

        public static void centralizaControlsPainel(PanelControl p)
        {
            foreach (Control cp in p.Controls)
            {
                cp.Location = centralizaUserControl(p, cp);
            }
        }
    }
}
