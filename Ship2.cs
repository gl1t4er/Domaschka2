using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classsi
{
    public class Ship2 : BaseShip
    {
       public Ship2(string name3, int l, int w2) : base(name3, l, w2)
        {
            Name3 = name3;
            W2 = w2;
            L = l;
            string k = "Ширина судна " + name3 + " - " + w2 + ". Длина - " + l;
            Console.WriteLine(k);
        }
        public virtual string PrintInformation()
        {
            int S = L * W2;
            string res = "Имя - " + Name3 + " Длина - " + L + " Ширина - " + W2 + " Площадь = " + S;
            return res;
        }
        public string Name3 { get; private set;}
        public int L { get; private set;}
        public int W2 { get; private set;} 
    }
}
