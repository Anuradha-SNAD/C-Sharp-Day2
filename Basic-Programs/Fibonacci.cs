using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Prgrams.Programs
{
    public class Fibonacci
    {
        public static void fibonacci()
        {
            int first = 0;
            int second = 1;
            Console.Write(first + " " + second + " ");
            for (int i =1; i <= 8; i++)
            {
                int third = first + second;
                Console.Write(third + " " );
                first = second;
                second = third;
            }
        }
    }
}
