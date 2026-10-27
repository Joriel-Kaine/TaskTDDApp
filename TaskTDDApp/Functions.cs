using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

        public static bool IsValidPassword (string? password)
        {
            return !string.IsNullOrEmpty(password) &&
                   password.Length >= 8 &&
                   password.Contains("#");
        }
    }
}
