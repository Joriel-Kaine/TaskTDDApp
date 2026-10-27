using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTDDApp
{
    public class Functions
    {
        // Funciones a implementar.
        public static long CalculateFactorial (int n)
        {
            long result = 1;

            if (n < 0)
            {
                return -1;
            }
            if (n == 0)
            {
                return 1;
            }
            
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
