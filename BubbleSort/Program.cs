using System;

namespace BubbleSort
{
    class Program
    {
        public static void PrintValues(Object[] myArr)
        {
            foreach (Object i in myArr)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine();
        }

        public static void PrintValues(int[] myArr)
        {
            foreach (int i in myArr)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine();
        }

        static int[] BubbleSort(int[] numbers)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        //swap
                        int temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
            return numbers;
        }


        static void Main(string[] args)
        {
            int[] numbers = new int[] { 37, 2, 8, 5, 3, 10, 11, 2, 2, 17, 1 };
            PrintValues(numbers);
            numbers = BubbleSort(numbers);
            PrintValues(numbers);
        }
    }
}
