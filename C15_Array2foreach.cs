using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class C15_Array2foreach
    {
    }
    class MyArray2
    {
        public static void show()
        {
            double[] n = new double[10];
            
            for (int i = 0; i < 10; i++)
            {
                double pow_result = (Math.Pow((i + 1), (i + 1)));
                n[i] = pow_result;
                Console.WriteLine("n[{0}]: {1}", i, n[i]);
            }

            foreach (double j in n)
            {
                double i = j + 0.01;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
            
        }
        
    }
}
