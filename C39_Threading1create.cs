using System;
using System.Threading;
namespace RiderCSharp2021
{
    class ThreadCreationProgram
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
        }

    }

    public class C39_Threading1create
    {
        public void show()
        {
            // ThreadStart childref = new ThreadStart(CallToChildThread);
            ThreadStart childref = new ThreadStart(ThreadCreationProgram.CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }
    }
}