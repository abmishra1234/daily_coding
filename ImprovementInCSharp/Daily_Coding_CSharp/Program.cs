using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Coding_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Do the Practice for CSharp Coding here
            const int size = 10000;
            List<int> li = new List<int>();
            Stopwatch sw = new Stopwatch();
            
            sw.Start();
            for(int i=0; i<size; i++)  li.Add(i);
            sw.Stop();

            Console.WriteLine(" without capacity init" + sw.ElapsedTicks);

            List<int> newli = new List<int>(size+5);
            sw.Restart();
            for (int i = 0; i < size; i++) newli.Add(i);
            sw.Stop();

            Console.WriteLine("with capacity init" + sw.ElapsedTicks);



        }
    }
}
