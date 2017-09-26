using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            List<List<int>> mas1 = new List<List<int>>();
            List<List<int>> mas2 = new List<List<int>>();
            List<List<int>> mas3 = new List<List<int>>();


            Console.WriteLine("Введите размер матриц: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            for (int i = 0; i < m1; i++)
            {
                var t = new List<int>();
                for (int j = 0; j < m1; j++)
                {
                    t.Add(rand.Next(1, 99));
                }
                mas1.Add(t);
            }

            for (int i = 0; i < m1; i++)
            {
                var v = new List<int>();
                for (int j = 0; j < m1; j++)
                {
                    v.Add(rand.Next(1, 99));
                }
                mas2.Add(v);
            }

            foreach (var t in mas1)
                Console.WriteLine(t.Aggregate("", (e, n) => e + " " + n));

            Console.WriteLine(Environment.NewLine);

            foreach (var t in mas2)
                Console.WriteLine(t.Aggregate("", (e, n) => e + " " + n));

            for (int i = 0; i < m1; i++)
                for (int j = 0; j < m1; j++)
                    for (int k = 0; k < m1; k++)
                        mas3[i, j] += (mas1[i, k] * mas2[k, j];

            foreach (var t in mas3)
                Console.WriteLine(t.Aggregate("", (e, n) => e + " " + n));

     

        }
    }
}
