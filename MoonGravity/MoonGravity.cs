using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {

            double w = double.Parse(Console.ReadLine());

            double gravityOfMoon = 0.17;
            Console.WriteLine("{0:F3}", w * gravityOfMoon);

        
            
 
        }
    }
}
