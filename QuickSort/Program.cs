﻿using System;

namespace QuickSort
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

        static int Partition (int[] numbers, int left, int right, int pivotIndex)
        {
            int pivotValue = numbers[pivotIndex];
            //move pivot element to the end
            int temp = numbers[right];
            numbers[right] = numbers[pivotIndex];
            numbers[pivotIndex] = temp;

            //newPivot stores the index of the first
            //number bigger than pivot
            int newPivot = left;
            for (int i = left; i < right; i++)
            {
                if (numbers[i] <= pivotValue)
                {
                    temp = numbers[newPivot];
                    numbers[newPivot] = numbers[i];
                    numbers[i] = temp;
                    newPivot++;
                }
            }
            //move pivot element to its sorted position
            temp = numbers[right];
            numbers[right] = numbers[newPivot];
            numbers[newPivot] = temp;
            return newPivot;
        }

        static int[] QuickSort(int[] numbers, int left, int right)
        {
            if (right > left)
            {
                int pivotIndex = left + (right - left) / 2;
                // partition the array
                pivotIndex = Partition(numbers, left, right, pivotIndex);
                //sort the left partition
                QuickSort(numbers, left, pivotIndex - 1);
                //sort the right partition
                QuickSort(numbers, pivotIndex + 1, right);
            }
            return numbers;
        }

        static void Main(string[] args)
        {
            int[] numbers = new[] { 3, 0, 37, 2, 3, 9, 8, -5, 4, 2, 1, 0 };
            PrintValues(numbers);
            numbers = QuickSort(numbers, 0, numbers.Length - 1);
            PrintValues(numbers);
        }
    }
}
