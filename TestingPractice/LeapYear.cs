using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace TestingPractice
{
    public  class LeapYear
    {
       
        
        public static string CheckLeapYearOrNot(int year)
        {
            //output.WriteLine("year"+year);
            int num = year;// Convert.ToInt32(Console.ReadLine());
            if (num % 4 == 0)
            {
                if (num % 100 == 0)
                {
                    if (num % 400 == 0)
                    {
                       return num + " is a leap year";
                    }
                    else
                    {
                        return num + "  is a not an leap year";
                    }
                }
                else
                {
                    if (num % 400 == 0)
                    {
                        return  num + " is a NA";
                    }
                    else
                    {
                        return num + " is a leap year";
                    }
                }
            }
            else
            {
                if (num % 100 == 0)
                {
                    if (num % 400 == 0)
                    {
                        return num + "  is a  NA";
                    }
                    else
                    {
                        return num + " is a  NA";
                    }
                }
                else
                {
                    if (num % 400 == 0)
                    {
                        return num + " is a  NA";
                    }
                    else
                    {
                        return num + "  is a  Not an leap year";
                    }
                }
            }
        }
    }
}
