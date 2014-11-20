using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS_CHEF.enums
{
    public enum TypePayment
    {
        Dinheiro = 0,
        CartaoDeDebito = 1,
        CartaoDeCredito = 2, 
        Cheque = 3,
        Boleto = 4
    }

    public enum FormPayment
    {
        Avista = 0, 
        Parcelado = 1
    }

    public enum LicenseType
    {
        Anonymous = 0,

        FreeTest1 = 1,
        FreeTest2 = 2,
        
        Basic = 3, 
        Premium = 4, 
        Professional = 5
    }

    public enum TypeLogin
    {
        Anonymous = 0,
        User = 1,
        Admin = 2
    }
}
