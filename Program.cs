using System;
using System.Security.Cryptography.X509Certificates;

namespace Burya_Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            int Exchanges = 0;
            double Total_Money = 0;
            double US_Dollars = 0;
            string User_Input = "";
            do
            {
                
                Console.WriteLine("Please select a currency");
                Console.WriteLine("1. USD");
                Console.WriteLine("2. GBP");
                Console.WriteLine("3. CAN");
                Console.WriteLine("4. EUR");
                Console.Write(":");

                string Currency1 = Console.ReadLine();

                Console.WriteLine("Please enter the currency you would like to exchange to");
                Console.WriteLine("1. USD");
                Console.WriteLine("2. GBP");
                Console.WriteLine("3. CAN");
                Console.WriteLine("4. EUR");
                string Currency2 = Console.ReadLine();
                double Money = 0;
                // I have used a switch to make the User interface a lot easier
                switch (Currency1)
                {
                    case "1":
                        switch (Currency2)
                        {
                            // each case is similar and all ask for the amount of money is being used before
                            // sending the user to the Method for each exchange while also gaining the money used
                            // in USD as well to add to the Total money exchanged
                            case "1":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                US_Dollars = Money;
                                Money = Exchanger.USD_USD_Conversion(Money);
                                Console.WriteLine("Succesfully exchanged USD into " + Money + " USD");
                                break;

                            case "2":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                US_Dollars = Money;
                                Money = Exchanger.USD_GBP_Conversion(Money);
                                Console.WriteLine("Succesfully exchanged USD into " + Money + " GBP");
                                break;

                            case "3":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                US_Dollars = Money;
                                Money = Exchanger.USD_CAN_Conversion(Money);
                                Console.WriteLine("Succesfully exchanged USD into " + Money + " CAN");
                                break;

                            case "4":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                US_Dollars = Money;
                                Money = Exchanger.USD_EUR_Conversion(Money);
                                Console.WriteLine("Succesfully exchanged USD into " + Money + " EUR");
                                break;

                            // each default breaks the current interaction
                            default:
                                Console.WriteLine("Error, please start from the beginning.");
                                break;
                        }
                        break;

                    case "2":
                        switch (Currency2)
                        {
                            case "1":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                Money = Exchanger.GBP_USD_Conversion(Money);
                                US_Dollars = Money;
                                Console.WriteLine("Succesfully exchanged GBP into " + Money + " USD");
                                break;

                            case "2":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                Money = Exchanger.GBP_GBP_Conversion(Money);
                                Console.WriteLine("Succesfully exchanged GBP into " + Money + " GBP");
                                Money = Exchanger.GBP_USD_Conversion(Money);
                                US_Dollars = Money;
                                break;

                            case "3":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                Money = Exchanger.GBP_CAN_Conversion(Money);
                                Console.WriteLine("Succesfully exchanged GBP into " + Money + " CAN");
                                Money = Exchanger.CAN_USD_Conversion(Money);
                                US_Dollars = Money;
                                break;

                            case "4":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                Money = Exchanger.GBP_EUR_Conversion(Money);
                                Console.WriteLine("Succesfully exchanged GBP into " + Money + " EUR");
                                Money = Exchanger.EUR_USD_Conversion(Money);
                                US_Dollars = Money;
                                break;

                            default:
                                Console.WriteLine("Error, please start from the beginning.");
                                break;
                        }
                        break;

                    case "3":
                        switch (Currency2)
                        {
                            case "1":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                Money = Exchanger.CAN_USD_Conversion(Money);
                                US_Dollars = Money;
                                Console.WriteLine("Succesfully exchanged CAN into " + Money + " USD");
                                break;

                            case "2":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                Money = Exchanger.CAN_GBP_Conversion(Money);
                                Console.WriteLine("Succesfully exchanged CAN into " + Money + " GBP");
                                Money = Exchanger.GBP_USD_Conversion(Money);
                                US_Dollars = Money;
                                break;

                            case "3":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                Money = Exchanger.CAN_CAN_Conversion(Money);
                                Console.WriteLine("Succesfully exchanged CAN into " + Money + " CAN");
                                Money = Exchanger.CAN_USD_Conversion(Money);
                                US_Dollars = Money;
                                break;

                            case "4":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                Money = Exchanger.CAN_EUR_Conversion(Money);
                                Console.WriteLine("Succesfully exchanged CAN into " + Money + " EUR");
                                Money = Exchanger.EUR_USD_Conversion(Money);
                                US_Dollars = Money;
                                break;

                            default:
                                Console.WriteLine("Error, please start from the beginning.");
                                break;
                        }
                        break;

                    case "4":
                        switch (Currency2)
                        {
                            case "1":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                Money = Exchanger.EUR_USD_Conversion(Money);
                                US_Dollars = Money;
                                Console.WriteLine("Succesfully exchanged EUR into " + Money + " USD");
                                break;

                            case "2":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                Money = Exchanger.EUR_GBP_Conversion(Money);
                                Console.WriteLine("Succesfully exchanged EUR into " + Money + " GBP");
                                Money = Exchanger.GBP_USD_Conversion(Money);
                                break;

                            case "3":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                Money = Exchanger.EUR_CAN_Conversion(Money);
                                Console.WriteLine("Succesfully exchanged EUR into " + Money + " CAN");
                                Money = Exchanger.CAN_USD_Conversion(Money);
                                US_Dollars = Money;
                                break;

                            case "4":
                                Console.Write("Please enter the amount of money: ");
                                Money = Convert.ToDouble(Console.ReadLine());
                                Money = Exchanger.EUR_EUR_Conversion(Money);
                                Console.WriteLine("Succesfully exchanged EUR into " + Money + " EUR");
                                Money = Exchanger.EUR_USD_Conversion(Money);
                                US_Dollars = Money;
                                break;

                            default:
                                Console.WriteLine("Error, please start from the beginning.");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Error, please start from the beginning.");
                        break;
                }
                //these calculate the amount exchanges
                Exchanges = ExchangeMonitor.Num_Exchanges(Exchanges);
                Console.WriteLine("You have attempted " + Exchanges + " currency exchange(s).");

                // this calculates the amount of money used so far
                Total_Money = ExchangeMonitor.Num_Money_Exchanged(Total_Money, US_Dollars);
                Console.WriteLine("You have exchanged $" + Total_Money + " so far.");

                // this asks the user if they want to quit or continue
                Console.Write("Enter 1 to quit, enter anything else to continue.");
                User_Input = Console.ReadLine();
            } while (User_Input != "1");
        }
            
    }
}
