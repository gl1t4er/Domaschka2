using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classsi
{
    public class BaseShip
    {
        public BaseShip(string name1, int l, int w)
        {
            Name1 = name1;
            L = l;
            W = w;
        }
        public string PrintInformation()
        {
            int s = W * L;
            string res = "Имя = " + Name1 + " Длина = " + L + " Ширина = " + W + " Площадь = " + s;
            return res;
        }
        public string Name1 { get; private set; }
        public int L { get; private set; }
        public int W { get; private set; }
    }
}
