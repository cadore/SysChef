using DevExpress.XtraEditors;
using System;

namespace SYS_CHEF.Utils
{
    public class CashierInit
    {
        public static cashier getOpenCashier()
        {
            cashier c;
            try
            {
                c = cashier.SingleOrDefault("WHERE opened = TRUE");
            }
            catch (Exception ex)
            {
                c = null;
                XtraMessageBox.Show(String.Format("Ocorreu um erro ao recuperar o caixa aberto.\n{0}\n\n{1}",
                    ex.Message, ex.InnerException));               
            }
            return c;
        }
    }
}
