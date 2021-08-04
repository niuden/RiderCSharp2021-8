#define PI  
using System;

namespace RiderCSharp2021
{
    public class C25_Preprocessor1define
    {
        public void show()
        {
          
#if (PI)
            Console.WriteLine("PI is defined");
#else
            Console.WriteLine("PI is not defined");
#endif
            Console.ReadKey();
        }
    }
}