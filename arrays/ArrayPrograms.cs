using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Prgrams.Arrays
{
    internal class ArrayPrograms
    {
        public static void Display()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            arr[2] = 99;
            Console.WriteLine(arr[2]);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("=== After Sorting ===");
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("=== After Sorting && Reverse===");
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }

        public static void MaxMin()
        {
            int[] arr = { 10, 50, 70, 99, 420, 33, 99, 9, 1 };
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
        }
        public static void SecondMaxMin()
        {
            int[] arr = { 10, 50, 70, 99, 4200, 33, 999, 9, 1, 4 };
            int max = arr[0];
            int min = arr[0];
            int secondMax = arr[0];
            int secondMin = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];

                }
                else if (arr[i] > secondMax && max > secondMax)
                {
                    secondMax = arr[i];
                }
                else if (arr[i] < min)
                {
                    secondMin = min;
                    min = arr[i];

                }
                else if (arr[i] < secondMin && min < secondMin)
                {
                    secondMin = arr[i];
                }
            }

            Console.WriteLine("Max = " + max);
            Console.WriteLine("SecondMax = " + secondMax);
            Console.WriteLine("Min = " + min);
            Console.WriteLine("SecondMin = " + secondMin);

        }

        public static void Reverse()
        {
            int[] arr = { 10, 50, 70, 99, 4200, 33, 999, 9, 1, 4 };
            int sum = 0;
            Console.WriteLine();
            Console.WriteLine("== Before == ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                sum += arr[i];
            }

            Console.WriteLine();
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("== After reverse==");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void Sort()
        {
            Console.WriteLine();
            Console.WriteLine("== After Sorting ==");
            int[] arr = { 10, 50, 70, 99, 4200, 33, 999, 9, 1, 4 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }

        }

        public static void print()
        {
            Console.WriteLine();
            Console.WriteLine("Method Started");

            int[,] a = { { 10, 20, 30 },{ 40, 40, 60 } };
            Console.WriteLine(a[0,1]);
        }
    }
}

