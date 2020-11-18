using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.FindingWord
{
    class Program
    {
        static char[] alpabets = {'a','b','c','d','e','f','g','h','i','j',
        'k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            string word = Console.ReadLine();

            foreach (char alpabet in alpabets)
            {
                if (word.Contains(alpabet))
                {
                    sb.Append(word.IndexOf(alpabet));
                }
                else
                {
                    sb.Append(-1);
                }
                sb.Append(' ');
            }
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
