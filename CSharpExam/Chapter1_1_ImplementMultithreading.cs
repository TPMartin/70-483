using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExam
{
    class Chapter1_1_ImplementMultithreading
    {

        //Creating a thread
        public void CreateThread()
        {
            Thread t = new Thread(new ThreadStart(CreateThread_ThreadMethod));
            t.Start(); //creates a new thread called t and then starts it and moves onto the "do some work" for loop
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do Some Work.");
                Thread.Sleep(0);
            }
            t.Join(); //joins the CreateThread thread with the t thread, so program waits for both to finish executing before continuing
        }
        public void CreateThread_ThreadMethod() //threadmethod() is the method run in the new thread created, this runs parrallel to the createthread code
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }


        //stopping a thread using a bool to be monitored
        public void StoppingAThread(bool stopped)
        {
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));
            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }
        public void StoppingAThread_ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }



        [ThreadStatic] int _field;
        public void UsingThreadStaticAttribute()
        {

        }
    }
}
