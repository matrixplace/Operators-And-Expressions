using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double area = (width * hight);
            double perimeter = ((width * 2) + (hight * 2));

            Console.Write("{0:0.00} {1:0.00}", area, perimeter);


        }
    }
}
