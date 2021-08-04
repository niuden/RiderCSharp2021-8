using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class C18_Enum2Accumulate
    {
        enum Day { Sun, Mon, Tue = 19, Wed, Thu, Fri, Sat };  /*列举其中的元素*/
        public void show()
        {
            int x = (int)Day.Sun;
            int y = (int)Day.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);
        }
    }
}
