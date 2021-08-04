using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class C13_Method5TranRefValue
    {
    }
    class NumberManipulator5
    {
        public void swap(ref int x, ref int y)
        {
            int temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        //static void Main(string[] args)
        //{
        //}
    }
}
