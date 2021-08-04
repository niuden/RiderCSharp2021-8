using System;
using System.Diagnostics;

namespace RiderCSharp2021
{
    public class C6_TypeTransform1
    {
        public void show()
        {
            int test = 1028;
            byte[] test3 = new byte [3];
            for (int i = 0;i<3;i++)
            {
                
                test3[i] = (byte) ((test >> i*8) & 0xFF);
                Console.WriteLine("num : " +test3[i].ToString());
            }
        }
    }
}