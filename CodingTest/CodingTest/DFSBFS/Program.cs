using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.DFSBFS
{

    class Program
    {
        static int n, m, v, s, e;
        static ArrayList[] list;
        static Boolean[] visit;
        static Queue que;
        static StringBuilder sb;

        static void Main()
        {
            string[] splited = Console.ReadLine()
                .Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

            n = int.Parse(splited[0]);
            m = int.Parse(splited[1]);
            v = int.Parse(splited[2]);
            list = new ArrayList[n + 1];

            for(int i=1; i < n + 1; i++)
            {
                list[i] = new ArrayList();
            }

            for(int i = 1; i < m+1; i++)
            {
                splited = Console.ReadLine()
                    .Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                s = int.Parse(splited[0]);
                e = int.Parse(splited[1]);
                list[s].Add(e);
                list[e].Add(s);
            }

            for(int i=1;i<n+1; i++)
            {
                list[i].Sort();
            }
            
            
            sb = new StringBuilder();
            visit = new Boolean[n + 1];
            
            dfs(v, sb);
            Console.WriteLine(sb);

            sb = new StringBuilder();
            visit = new Boolean[n + 1];
            
            bfs(v, sb);
            Console.WriteLine(sb);
           
            Console.ReadLine();
        }

        private static void bfs(int v, StringBuilder sb)
        {
            int b = v;
            que = new Queue();
            que.Enqueue(b);
            visit[b] = true;
            while (que.Count != 0)
            {
                int temp = (int)que.Dequeue();
                sb.Append(temp).Append(" ");
                for(int i = 0; i < list[temp].Count; i++)
                {
                    int next = (int)list[temp][i];
                    if (!visit[next])
                    {
                        que.Enqueue(next);
                        visit[next] = true;
                    }
                }
            }
        }

        private static void dfs(int v, StringBuilder sb)
        {
            int a = v;
            visit[a] = true;
            sb.Append(a).Append(" ");
            for (int i = 0; i < list[a].Count; i++)
            {
                int next = (int)list[a][i];
                if (!visit[next])
                {
                    dfs(next, sb);
                }
            }
        }
    }
}
