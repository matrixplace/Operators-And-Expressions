using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mask = n >> 3;
            int thirdBit = (mask & 1);

            Console.WriteLine(thirdBit);
            
        }
    }
}
