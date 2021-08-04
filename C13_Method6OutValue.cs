using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class C13_Method6OutValue
    {
    }
    class NumberManipulator6
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }

        //static void Main(string[] args)
        //{
        //    NumberManipulator6 n = new NumberManipulator6();
        //    /* 局部变量定义 */
        //    int a = 100;

        //    Console.WriteLine("在方法调用之前，a 的值： {0}", a);

        //    /* 调用函数来获取值 */
        //    n.getValue(out a);

        //    Console.WriteLine("在方法调用之后，a 的值： {0}", a);

        //}
    }


}
