using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Prgrams.Programs
{
    internal class Polidrom
    {
        public static void polidrome()
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int rev = 0;
            while(n > 0)
            {
                int digit = n % 10;
                rev = rev *10 + digit;
                n = n/ 10;
            }
            if(temp == rev)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
