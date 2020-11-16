using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
