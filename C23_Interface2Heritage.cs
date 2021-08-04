using System;
namespace RiderCSharp2021
{
    interface IParentInterface
    {
        void ParentInterfaceMethod();
    }

    interface IMyInterface2 : IParentInterface
    {
        void MethodToImplement();
    }

    class InterfaceImplementer2 : IMyInterface2
    {

        public void MethodToImplement()
        {
            Console.WriteLine("MethodToImplement() called.");
        }

        public void ParentInterfaceMethod()
        {
            Console.WriteLine("ParentInterfaceMethod() called.");
        }
    }
    public class C23_Interface2Heritage
    {
        public void show()
        {
            InterfaceImplementer2 iImp = new InterfaceImplementer2();
            iImp.MethodToImplement();
            iImp.ParentInterfaceMethod();
        }
    }
}