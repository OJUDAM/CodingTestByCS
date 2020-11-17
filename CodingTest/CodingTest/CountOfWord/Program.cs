using System;

namespace CodingTest.CountOfWord
{
    class Program
    {
        static int Main()
        {
            string str = Console.ReadLine();
            if(str ==" " || str == "")
            {
                Console.WriteLine(0);
                Console.ReadLine();
                return 0;
            }
            Console.WriteLine(str);
            string[] words = str.Trim().Split();

            Console.WriteLine(words.Length);
            Console.ReadLine();
            return 0;
        }
    }
}
