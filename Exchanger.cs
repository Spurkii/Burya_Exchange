using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burya_Exchange
{
    public static class Exchanger
    {

        // these are all 16 conversions to ensure that the money entered gets multiplied by its conversion #
        // and  is simplified 
        public static double USD_USD_Conversion(double Money)
        {
            Money *= 1;
            Money = Math.Round((double)Money, 2);
            return Money;
        }

        public static double USD_GBP_Conversion(double Money)
        {
            Money *= 0.72523;
            Money = Math.Round((double)Money, 2);
            return Money;
        }

        public static double USD_CAN_Conversion(double Money)
        {
            Money *= 1.25427;
            Money = Math.Round((double)Money, 2);
            return Money;
        }

        public static double USD_EUR_Conversion(double Money)
        {
            Money *= 0.83572;
            Money = Math.Round((double)Money, 2);
            return Money;
        }

        public static double GBP_USD_Conversion(double Money)
        {
            Money *= 1.37887;
            Money = Math.Round((double)Money, 2);
            return Money;
        }

        public static double GBP_GBP_Conversion(double Money)
        {
            Money *= 1;
            Money = Math.Round((double)Money, 2);
            return Money;
        }

        public static double GBP_CAN_Conversion(double Money)
        {
            Money *= 1.72947;
            Money = Math.Round((double)Money, 2);
            return Money;
        }

        public static double GBP_EUR_Conversion(double Money)
        {
            Money *= 1.15195;
            Money = Math.Round((double)Money, 2);
            return Money;
        }

        public static double CAN_USD_Conversion(double Money)
        {
            Money *= 0.79728;
            Money = Math.Round((double)Money, 2);
            return Money;
        }

        public static double CAN_GBP_Conversion(double Money)
        {
            Money *= 0.57848;
            Money = Math.Round((double)Money, 2);
            return Money;
        }
        public static double CAN_CAN_Conversion(double Money)
        {
            Money *= 1;
            Money = Math.Round((double)Money, 2);
            return Money;
        }
        public static double CAN_EUR_Conversion(double Money)
        {
            Money *= 0.66645;
            Money = Math.Round((double)Money, 2);
            return Money;
        }
        public static double EUR_USD_Conversion(double Money)
        {
            Money *= 1.19648;
            Money = Math.Round((double)Money, 2);
            return Money;
        }
        public static double EUR_GBP_Conversion(double Money)
        {
            Money *= 0.86826;
            Money = Math.Round((double)Money, 2);
            return Money;
        }
        public static double EUR_CAN_Conversion(double Money)
        {
            Money *= 1.50040;
            Money = Math.Round((double)Money, 2);
            return Money;
        }
        public static double EUR_EUR_Conversion(double Money)
        {
            Money *= 1;
            Money = Math.Round((double)Money, 2);
            return Money;
        }
    }
}
