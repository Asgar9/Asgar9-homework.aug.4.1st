using System;

namespace min.method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("minimum value of array");
            int[] arr = { 52, 43, 85, 21, 11, 2, 90 };
            Console.WriteLine(MinArray(arr));
        }
        static int MinArray(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min < arr[i])
                {

                }
                else
                {
                    min = arr[i];
                }
               
            }
                  return min;
        }
    }
    }

