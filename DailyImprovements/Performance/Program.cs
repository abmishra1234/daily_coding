using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Performance;


namespace Performance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------
            // Do the Practice for CSharp Coding here
            Console.WriteLine("1st Performance Optimization");
            const int size = 10000;
            List<int> li = new List<int>();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < size; i++) li.Add(i);
            sw.Stop();

            Console.WriteLine(" without capacity init" + sw.ElapsedTicks);

            List<int> newli = new List<int>(size + 5);
            sw.Restart();
            for (int i = 0; i < size; i++) newli.Add(i);
            sw.Stop();

            Console.WriteLine("with capacity init" + sw.ElapsedTicks);

            //-----------------------------
            // 2X Improvement here
            Console.WriteLine("2nd Optimization Code");

            // Use Structs instead of Classes (sometimes)

            int COUNT = 100000;
            VectorClass[] vec1 = new VectorClass[COUNT + 5];
            sw.Restart();
            for (int i = 0; i < COUNT; ++i)
            {
                vec1[i] = new VectorClass();
                vec1[i].x = 5;
                vec1[i].y = 10;
            }
            sw.Stop();
            Console.WriteLine("With Class Vector" + sw.ElapsedTicks);

            VectorStruct[] vec2 = new VectorStruct[COUNT + 5];
            sw.Restart();
            for (int i = 0; i < COUNT; ++i)
            {
                vec2[i] = new VectorStruct();
                vec2[i].x = 5;
                vec2[i].y = 10;
            }
            sw.Stop();
            Console.WriteLine("With Struct Vector" + sw.ElapsedTicks);
        }
    }
}
