using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class Rectangle3
    {
        //成员变量
        internal double length;
        internal double width;

        double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }//end class Rectangle    
    //class ExecuteRectangle
    //{
    //    static void Main(string[] args)
    //    {
    //        Rectangle3 r = new Rectangle3();
    //        r.length = 4.5;
    //        r.width = 3.5;
    //        r.Display();
    //        Console.ReadLine();
    //    }
    //}
}
