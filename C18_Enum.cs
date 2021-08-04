using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class C18_Enum
    {
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        public void show()
        {
            int x = (int)Day.Sun;
            int y = (int)Day.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);
        }
    }
    

    
}
