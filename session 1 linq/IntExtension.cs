using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_1_linq
{
    public static class IntExtension
    {
        public static int Reverse( this int value)
        {

            int RevrseNumber = 0;
            int LastDigit;
            while (value > 0)
            {
               LastDigit = value%10;

                RevrseNumber=RevrseNumber*10+LastDigit;

                value/=10;

            }
            return RevrseNumber;
        }
    }
}
