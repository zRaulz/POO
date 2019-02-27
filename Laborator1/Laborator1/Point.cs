using System;

namespace Laborator1
{
    internal class Point
    {

        double x, y;

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get { return x; }

        }
        public double Y
        {
            get
            { return y; }
        }



        public void Rotate(double teta)
        {
            teta = (teta * Math.PI) / 180;


            double x1 = X * Math.Cos(teta) - Y * Math.Sin(teta);
            double y1 = Y * Math.Cos(teta) + X * Math.Cos(teta);
        }

    }

    class Triangle
    {
        Point p, p2, p3;
        double Distance(Point p, Point p2)
        {
            return Math.Sqrt((p2.Y - p.Y) * (p2.Y - p.Y) + (p2.X - p.X) * (p2.X - p.X));
        }

        public Triangle(Point p, Point p2, Point p3)
        {
            double l1, l2, l3;
            l1 = Distance(p, p2);
            l2 = Distance(p2, p3);
            l3 = Distance(p, p3);
            if (l1 + l2 >= l3 && l3 + l2 >= l1 && l1 + l3 >= l2)
            {
                this.p = p;
                this.p2 = p2;
                this.p3 = p3;
                
            }
            else
                Console.WriteLine("Asta nu e triunghi!");

            
           




        }
        public double Perimetru()
        {
            double l1, l2, l3;
            l1 = Distance(p, p2);
            l2 = Distance(p2, p3);
            l3 = Distance(p, p3);
            return l1 + l2 + l3;

        }
        public double Arie()
        {

            double l1, l2, l3;
            l1 = Distance(p, p2);
            l2 = Distance(p2, p3);
            l3 = Distance(p, p3);
            double semiperimetru = (l1 + l2 + l3) / 2;
            return Math.Sqrt(semiperimetru * (semiperimetru - l1) * (semiperimetru - l2) * (semiperimetru - l3));
           
        }
    }
}
