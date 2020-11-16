using System;
using System.Text;

namespace CodingTest.Star
{
    class Program
    {
        
        static void Main()
        {
            
            int count = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i = 1; i < count + 1; i++)
            {
                sb.Append('*');
                Console.WriteLine(sb);
            }
           
            Console.ReadLine();
        }
    }
}
