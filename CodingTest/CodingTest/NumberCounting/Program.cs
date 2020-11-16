using System;
using System.Collections.Generic;

namespace CodingTest.NumberCounting
{
    class Program
    {
        static void Main()
        {
            
            //0~9까지 갯수 기록
            int[] array = new int[10];
            
            //각 자릿수
            List<int> list = new List<int>();

            double num = 1;
            for(int i = 0; i < 3; i++)
            {
                num *= Double.Parse(Console.ReadLine());
            }
           
            int log = (int)Math.Log10(num);
            int temp = (int)Math.Pow(10, log);
            int next = (int)num;

            for (int i = log; i > -1; i--)
            {
                list.Add(next / temp);
                next = (int)num % temp;
                temp /= 10;    
            }
            
            foreach(int a in list)
            {
                array[a] += 1;
            }

            foreach (int b in array)
            {
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
    }
}
