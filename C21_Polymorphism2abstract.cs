using System;
namespace RiderCSharp2021
{
    abstract class Shape2p
    {
        abstract public int area();
    }
    class Rectangle2p:  Shape2p
    {
        private int length;
        private int width;
        public Rectangle2p( int a=0, int b=0)
        {
            length = a;
            width = b;
        }
        public override int area ()
        {
            Console.WriteLine("Rectangle2p 类的面积：");
            return (width * length);
        }
    }


    public class C21_Polymorphism2abstract
    {
        public void show()
        {
            Rectangle2p r = new Rectangle2p(10, 7);
            double a = r.area();
            Console.WriteLine("面积： {0}",a);
            Console.ReadKey();
        }
    }
}