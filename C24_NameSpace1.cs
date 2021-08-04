using System;
namespace RiderCSharp2021
{
    namespace first_space
    {
        class namespace_cl
        {
            public void func()
            {
                Console.WriteLine("Inside first_space");
            }
        }
    }
    namespace second_space
    {
        class namespace_cl
        {
            public void func()
            {
                Console.WriteLine("Inside second_space");
            }
        }
    }  


    public class C24_NameSpace1
    {
        public void show()
        {
            first_space.namespace_cl fc = new first_space.namespace_cl();
            second_space.namespace_cl sc = new second_space.namespace_cl();
            fc.func();
            sc.func();
            Console.ReadKey();
        }
    }
}