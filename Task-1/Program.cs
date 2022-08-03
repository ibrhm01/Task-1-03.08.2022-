using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 63, 89, 190, 56, 25, 61, 7, 3, 2910 };
            int min = arr[0], indexOfMin = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i]) 
                { 
                    min = arr[i];
                    indexOfMin = i;
                }
            }
            
            Console.WriteLine($"Minimum value of the array is {min} on the index {indexOfMin}");
        }
    }
}
