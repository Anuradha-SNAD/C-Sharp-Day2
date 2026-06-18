using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Basic_Prgrams.Strings
{
    internal class StringPrograms
    {
        public static void Demo()
        {
            string s = "Strings";
            for(int i = 0;i<s.Length; i++)
            {
                Console.WriteLine(s[i]+" ");
            }
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.Contains("ing"));
            Console.WriteLine(s.StartsWith("A"));
            Console.WriteLine(s.EndsWith("s"));
            Console.WriteLine(s.Replace("n", "m"));
            Console.WriteLine(s.Substring(3));
        }
        public static void Reverse()
        {
            String s = "hello";
            for(int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
        }

        public static void Polindrome()
        {
            Console.WriteLine("Enter the String to check polindrome or not");
            string str = Console.ReadLine();
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            if(str == rev)
            {
                Console.WriteLine("Polindrome");
            }
            else
            {
                Console.WriteLine("Not Polindrome");
            }
        }
        public static void Vowels()
        {
            string s = "hello";
            int count = 0;
            for(int i =0;i<s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(s.Length);
        }

        public static void CountWords()
        {
            string s = "I am learning C Sharp classes";
            string[] words = s.Split(' ');
            Console.WriteLine(words.Length);
            Console.WriteLine(s.Replace(" ", ""));
        }

        public static void PrintDuplicates()
        {
            string str = "programming";
            Console.WriteLine("== Duplicate Characters ==");
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        Console.WriteLine(str[i]);
                        break;
                    }
                }
            }
        }
    }
    
}
