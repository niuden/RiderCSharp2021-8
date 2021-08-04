using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class StaticVar2
    {
        public static int num;
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }

    class C19_Class5Static2
    {
        public void show()
        {
            StaticVar2 s1 = new StaticVar2();
            StaticVar2 s2 = new StaticVar2();
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("s1 的变量 num： {0}", s1.getNum());
            Console.WriteLine("s2 的变量 num： {0}", s2.getNum());
        }
    }
}

namespace TestStatic
{
    class StaticVar2
    {
        public static int num = 666;
    }
}
