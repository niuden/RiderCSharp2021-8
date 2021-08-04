using System;
namespace RiderCSharp2021
{
    
    public class Printdata
    {
        public void print(int i)
        {
            Console.WriteLine("输出整型: {0}", i );
        }

        public void print(double f)
        {
            Console.WriteLine("输出浮点型: {0}" , f);
        }

        public void print(string s)
        {
            Console.WriteLine("输出字符串: {0}", s);
        }

    }
    public class C21_Polymophism1Print
    {
        public void show()
        {
            Printdata p = new Printdata();
            // 调用 print 来打印整数
            p.print(1);
            // 调用 print 来打印浮点数
            p.print(1.23);
            // 调用 print 来打印字符串
            p.print("Hello Runoob");
            // Console.ReadKey();
        }
    }
    
    
}