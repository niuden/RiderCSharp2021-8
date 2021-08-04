using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class ConstTest
    {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public ConstTest(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
}

