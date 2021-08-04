using System;
namespace RiderCSharp2021
{
    interface IMyInterface
    {
        // 接口成员
        void MethodToImplement();
    }

    class InterfaceImplementer : IMyInterface
    {


        public void MethodToImplement()
        {
            Console.WriteLine("MethodToImplement() called.");
        }
    }
    public class C23_Interface1
    {
        public void show()
        {
            InterfaceImplementer iImp = new InterfaceImplementer();
            iImp.MethodToImplement();
        }
    }
}
    