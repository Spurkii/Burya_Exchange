using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burya_Exchange
{
    class ExchangeMonitor
    {
        //this counts the exchanges attempted
        public static int Num_Exchanges(int exchanges) 
        {
            exchanges += 1;
            return exchanges;
        }

        // this counts the amount of money exchanges so far
        public static double Num_Money_Exchanged(double Total_Money, double US_Dollars)
        {
            Total_Money += US_Dollars;
            return Total_Money;
        }
    }
}
