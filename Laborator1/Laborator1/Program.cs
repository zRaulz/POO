using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    class Program
    {
        static void Main(string[] args)
        {Point p=new Point(3, 0);
            //Console.WriteLine("({0},{1})", p.X, p.Y);
            //p.Rotate(90);
            //Console.WriteLine("({0},{1}", p.X, p.Y);

            Point p2 = new Point(4, 0);
            Point p3 = new Point(5, 0);
            Triangle t = new Triangle(p, p2, p3);
            
            

        }
    }

   
}
