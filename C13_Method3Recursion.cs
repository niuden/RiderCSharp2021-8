using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class C13_Method3Recursion
    {
    }
    class NumberManipulator3
    {
        public int factorial(int num)
        {
            /* 局部变量定义 */
            int result;

            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        //static void Main(string[] args)
        //{
        //    NumberManipulator3 n = new NumberManipulator3();
        //    //调用 factorial 方法
        //    Console.WriteLine("6 的阶乘是： {0}", n.factorial(6));
        //    Console.WriteLine("7 的阶乘是： {0}", n.factorial(7));
        //    Console.WriteLine("8 的阶乘是： {0}", n.factorial(8));
        //    Console.ReadLine();

        //}
    }
}
