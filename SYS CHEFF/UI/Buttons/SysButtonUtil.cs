using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS_CHEF.UI.Buttons
{
    public class SysButtonUtil : Button
    {
    
        public SysButtonUtil()
        {
            this.Size = new Size(95, 30);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                      ControlStyles.Opaque |
                      ControlStyles.ResizeRedraw |
                      ControlStyles.OptimizedDoubleBuffer |
                      ControlStyles.CacheText, // We gain about 2% in painting by avoiding extra GetWindowText calls
                      true);
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.TextAlign = ContentAlignment.MiddleRight;
            this.ForeColor = Color.Black;
            this.BackColor = Color.Transparent;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
