using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class Program
    {
        static void Main()
        {
            string[] spiltStr = Console.ReadLine().Split(' '); 
            
            Console.WriteLine(int.Parse(spiltStr[0]) + int.Parse(spiltStr[1]));

            Console.ReadLine();
        }
    }
}
