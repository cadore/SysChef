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
        FreeTest1 = 0,
        FreeTest2 = 1,
        
        Basic = 2, 
        Premium = 3, 
        Professional = 4
    }
}
