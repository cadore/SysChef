using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SYS_CHEF.UI.Customers
{
    public partial class SelectCliForForm : DevExpress.XtraEditors.XtraForm
    {
        public SelectCliForForm()
        {
            InitializeComponent();
            XtraMessageBox.Show("Função de clientes e fornecedor ainda em implantação!");
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}