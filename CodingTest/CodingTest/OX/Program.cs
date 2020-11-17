using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.OX
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < number; i++)
            {
                string testCase = Console.ReadLine();
                int temp = 0;
                int result = 0;
                foreach(char answer in testCase)
                {
                    if(answer == 'O')
                    {
                        temp += 1;
                    }
                    else
                    {
                        result += sum(temp);
                        temp = 0;
                    }
                }
                if(temp > 0)
                {
                    result += sum(temp);
                }
                sb.Append(result).Append("\n");
            }
            Console.WriteLine(sb);
            Console.ReadLine();
        }

        private static int sum(int temp)
        {
            int result = 0;
            for(int i = 1; i < temp + 1; i++)
            {
                result += i;
            }

            return result;
        }
    }
}
