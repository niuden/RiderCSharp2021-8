﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class Rectangle2
    {
        //成员变量
        private double length;
        private double width;

        public void Acceptdetails()
        {
            Console.WriteLine("请输入长度：");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入宽度：");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
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
    //        Rectangle2 r = new Rectangle2();
    //        r.Acceptdetails();
    //        r.Display();
    //        Console.ReadLine();
    //    }
    //}
}
