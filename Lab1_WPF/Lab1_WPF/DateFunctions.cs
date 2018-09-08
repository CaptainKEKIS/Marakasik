using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_WPF
{
    class DateFunctions
    {
        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 400 != 0 && year % 100 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

    }
}
