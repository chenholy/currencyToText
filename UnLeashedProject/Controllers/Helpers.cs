using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnLeashPorject.Controllers
{
    public class Helpers
    {
        public static string singleDigit(int num)
        {
            string name = "";
            switch (num)
            {

                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }
            return name;
        }

        public static string doubleDigit(int num)
        {
            string name = "";
            switch (num)
            {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                default:
                    if (num > 0)
                    {
                        name = doubleDigit(num - num % 10) + " " + singleDigit(num % 10);
                    }
                    break;
            }
            return name;
        }

        public static string convertDollarString(int num, int numLength)
        {
            string name = "";
            int divider = (int)Math.Pow(10, numLength - 1);
            switch (numLength)
            {
                case 1:
                    name = singleDigit(num);
                    break;
                case 2:
                    name = doubleDigit(num);
                    break;
                case 3:
                    name = singleDigit(num / divider) + " Hundred ";
                    if (num % divider != 0)
                    {
                        name = name + "and ";
                    }
                    name = name + convertDollarString(num % divider, (num % divider).ToString().Length);
                    break;
                case 4:
                    name = singleDigit(num / divider) + " Thousand ";
                    name = name + convertDollarString(num % divider, (num % divider).ToString().Length);
                    break;
                case 5:
                    divider = divider / 10;
                    name = doubleDigit(num / divider) + " Thousand ";
                    name = name + convertDollarString(num % divider, (num % divider).ToString().Length);
                    break;
                case 6:
                    name = singleDigit(num / divider) + " Hundred ";
                    if ((num - num % 1000) % divider != 0)
                    {
                        name = name + "and " + convertDollarString(num % divider, (num % divider).ToString().Length);
                    }
                    else
                    {
                        name = name + " thousand " + convertDollarString(num % divider, (num % divider).ToString().Length); ;
                    }
                    break;
                case 7:
                    name = singleDigit(num / divider) + " Million ";
                    name = name + convertDollarString(num % divider, (num % divider).ToString().Length);
                    break;
                case 8:
                    divider = divider / 10;
                    name = doubleDigit(num / divider) + " Million ";
                    name = name + convertDollarString(num % divider, (num % divider).ToString().Length);
                    break;
                case 9:
                    name = singleDigit(num / divider) + " Hundred ";
                    if ((num - num % 1000000) % divider != 0)
                    {
                        name = name + "and " + convertDollarString(num % divider, (num % divider).ToString().Length);
                    }
                    else
                    {
                        name = name + " Million " + convertDollarString(num % divider, (num % divider).ToString().Length); ;
                    }
                    break;
                case 10:
                    name = singleDigit(num / divider) + " Billion ";
                    name = name + convertDollarString(num % divider, (num % divider).ToString().Length);
                    break;
                case 11:
                    divider = divider / 10;
                    name = doubleDigit(num / divider) + " Billion ";
                    name = name + convertDollarString(num % divider, (num % divider).ToString().Length);
                    break;
                case 12:
                    name = singleDigit(num / divider) + " Hundred ";
                    if ((num - num % 1000000000) % divider != 0)
                    {
                        name = name + "and " + convertDollarString(num % divider, (num % divider).ToString().Length);
                    }
                    else
                    {
                        name = name + " Billion " + convertDollarString(num % divider, (num % divider).ToString().Length); ;
                    }
                    break;
            }
            return name.Trim();
        }
    }
}