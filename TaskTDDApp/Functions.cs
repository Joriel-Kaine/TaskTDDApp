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
    }
}
