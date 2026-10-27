using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTDDApp
{
    public class Functions
    {
        // Funciones a implementar.
        public static long CalculateFactorial (int number)
        {
            if (number < 0) return -1;
            if (number == 0) return 1;

            return number * CalculateFactorial(number - 1);
        }

        public static bool IsValidPassword (string? a)
        {
            if (string.IsNullOrEmpty(a))
            {
                return false;
            }
            if (a.Length < 8)
            {
                return false;
            }
            if (!a.Contains("#"))
            {
                return false;
            }

            return true;
        }
    }
}
