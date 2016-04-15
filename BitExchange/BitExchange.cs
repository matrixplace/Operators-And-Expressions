using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint firstBits = (n >> 3) & 7;
            uint secondBits = (n >> 24) & 7;
            uint maskFirstBits = 7 << 3;
            uint maskSecondBits = 7 << 24;
            n = n & ~maskFirstBits | (secondBits << 3);
            n = n & ~maskSecondBits | (firstBits << 24);
            Console.WriteLine(n);
        }
    }
}
