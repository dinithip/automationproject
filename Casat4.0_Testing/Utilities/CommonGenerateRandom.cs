using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.Utilities
{
    class CommonGenerateRandom
    {
        public static string GenarateRandom(string strPrefix)
        {
            string strRandomText = "";

            Random random = new Random();
            int intNumber = random.Next(1000);
            string strNumber = intNumber.ToString();
            strRandomText = strPrefix + strNumber;

            return strRandomText;
        }
    }
}
