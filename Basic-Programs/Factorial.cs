using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Prgrams.Programs
{
    internal class Factorial
    {
        public static void factorial()
        {
            Console.WriteLine("Enter the digit");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= n; i++) 
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
