using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classsi
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Black Pearl";
            string name2 = "Piligrimm";
            string name3 = "Eclipse";
            int w2 = 22;
            int w = 44;
            int l = 162;
            int l1 = 56;
            int w1 = 25;
            BaseShip z = new BaseShip(name1, l, w);
            Ship1 p = new Ship1(name2, l1, w1);
            Ship2 x = new Ship2(name3, l, w2);
            string toPrint = z.PrintInformation();
            Console.WriteLine(toPrint);
            string toPrint1 = p.PrintInformation();
            Console.WriteLine(toPrint1);
            string toPrint2 = x.PrintInformation();
            Console.WriteLine(toPrint2);

        }
    }
}
