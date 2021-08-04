using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class C16_String2Methods
    {
    }
    class StringProg
    {
        public void show()
        {
            string str1 = "This is test";
            string str2 = "This is text";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
            //Console.ReadKey();
        }
    }
}
