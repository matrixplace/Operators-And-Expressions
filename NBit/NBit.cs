using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBit
{
    class NBit
    {
        static void Main(string[] args)
        {
            long p = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());


            if ((p & ((long)1 << n)) != 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
  
        }
    }
}
