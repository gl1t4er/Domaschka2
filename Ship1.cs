using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classsi
{
    public class Ship1 : BaseShip
    {
        public Ship1 (string name2, int l1, int w1) : base(name2, l1, w1)
        {
            Name2 = name2;
            W1 = w1;
            L1 = l1;
            string j = "Ширина судна " + name2 + " - " + w1 + ". Длина - " + l1;
            Console.WriteLine(j);
        }
        public virtual string PrintInforamtion()
        {
            int s1 = L1 * W1;
            string res = "Название корабля - " + Name2 + " Ширина - " + W1 + " Длина - " + L1;
            return res;
        }
        public string Name2 { get; private set;}
        public int W1 { get; private set;}
        public int L1 { get; private set;}
    }
}
