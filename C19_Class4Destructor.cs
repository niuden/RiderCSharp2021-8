using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class Line02
    {
        private double length;   // 线条的长度
        public Line02()  // 构造函数
        {
            Console.WriteLine("对象已创建");
        }
        ~Line02() //析构函数
        {
            Console.WriteLine("对象已删除");
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
    class C19_Class4Destructor
    {
        public void show()
        {
            Line02 line = new Line02();
            // 设置线条长度
            line.setLength(6.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());
        }
    }
}
