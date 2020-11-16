using System;

namespace CodingTest.Sum
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            string numArray = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += (int)char.GetNumericValue(numArray[i]);
            }
            Console.WriteLine(sum);

            Console.Read();
        }
    }
}
