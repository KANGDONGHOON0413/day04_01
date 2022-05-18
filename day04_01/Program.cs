using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = submain01();
            foreach(var i in p)
            {
                Console.WriteLine(i);
            }

            foreach (var i in submain02())
            {
                Console.WriteLine(i);
            }
        }

        static int[] submain01() {
           int[] p = new int[] { 10, 20, 30 };
            return p;
        }
        static IEnumerable<int> submain02()
        {
            int[] p = new int[] { 10, 20, 30,40,50 };
            for(int i = 0; i < p.Length; i++)
            {
                if (p[i] == 50) yield break;
                yield return p[i];
                Console.WriteLine((i+1) + "번째 종료");
            }
            
        }

    }
}
