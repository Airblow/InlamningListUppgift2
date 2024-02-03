using System;
using System.Collections.Generic;

namespace InlamningListUppift2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {3, 15, 6, 11, 54, 19, 22, 57};
            Console.WriteLine(Max(numbers));

            Console.ReadKey();

        }

        static int Max(List<int> numbers)
        {
            int largestNumber = 0;
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > largestNumber)
                {
                    largestNumber = numbers[i];
                }

            }

            return largestNumber;

        }

    }

}
