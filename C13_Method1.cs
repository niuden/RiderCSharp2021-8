using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class NumberManipulator1
    {
        public int FindMax(int num1, int num2)
        {
            /* 局部变量声明 */
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }
    }
}
