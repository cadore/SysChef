using System;
using System.Net;

namespace SYS_CHEF.Utils
{
    public class Util
    {
        public static string keyCrypto = "cadore";

        public static string getIpHost()
        {
            try
            {
                IPHostEntry ipEntry = Dns.GetHostByName(getHostName());
                IPAddress[] addr = ipEntry.AddressList;
                return addr[0].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public static string getHostName()
        {
            try
            {
                return Dns.GetHostName();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }           
        }
    }
}
