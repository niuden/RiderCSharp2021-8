using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{


    class Line
    {
        private double length;   // 线条的长度
        public Line(double len)  // 参数化构造函数
        {
            Console.WriteLine("对象已创建，length = {0}", len);
            length = len;
        }

        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        } 
    }

    class C19_Class3Constructor
    {
        public void show()
        {
            Line line = new Line(10.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());
            // 设置线条长度
            line.setLength(6.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());
        }
    }
}
