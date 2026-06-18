using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Prgrams.Programs
{
    internal class Prime
    {

        public static void prime()
        {
            Console.WriteLine("Enter number to check Prime Or Not");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
