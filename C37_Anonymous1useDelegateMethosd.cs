using System;
namespace RiderCSharp2021
{
    public class C37_Anonymous1useDelegateMethosd
    {
        delegate void NumberMethods(int n);

        private static int num = 100;
        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method: {0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method: {0}", num);
        }
        public void show()
        {
            NumberMethods nm = delegate(int x)
            {
                Console.WriteLine(x);
            };
            nm(num); // num = 100
            nm = new NumberMethods(AddNum); // += 操作
            nm(10);  // num = 110
            nm = new NumberMethods(MultNum); // *= 操作
            nm(10);  // num = 1100
        }
    }
}