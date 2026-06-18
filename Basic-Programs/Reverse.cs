using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Prgrams.Programs
{
    internal class Reverse
    {
        public static void reverse()
        {
            Console.WriteLine("Emter the number");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int rev = n % 10;
                Console.Write(rev);
                n = n / 10;
            }
        }
    }
}

