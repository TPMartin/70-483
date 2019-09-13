using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

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



      
        public void UsingThreadLocal()
        {
            var _field = new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
            });

            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();

            Console.ReadKey();
        }



        public void ThreadPooling()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("*Working on a thread from threadpool*");
            });
        }



        public void CreatingATaskAndWaitingForitToFinish()
        {
            Task t = Task.Run(() =>
            {
                for (int x = 1; x <= 100; x++)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(150);
                }
            });
            t.Wait();
        }



        public void AddingAContinuationTask()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });

            Console.WriteLine(t.Result); //displays 84
        }



        public void MultipleContinuationTasks()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Cancelled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
        }



        public void attachingChildTasksToParentTask()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                new Task(() => results[0] = 0,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2,
                    TaskCreationOptions.AttachedToParent).Start();

                return results;
            });

            var finalTask = parent.ContinueWith((parentTask) => 
            {
                foreach (int i in parent.Result)
                    Console.WriteLine(i);
            });
            finalTask.Wait();
        }



        public void CreatingATaskFactory()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];

                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);
                return results;
            });

            var finalTask = parent.ContinueWith((parentTask) =>
            {
                foreach (int i in parentTask.Result)
                    Console.WriteLine(i);
            });

            finalTask.Wait();
        }

        public void ParallelForAndForeachLoop()
        {
            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
            });
        }

        public void BreakingParallelLoopUsingParallelLoopState()
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                if (i == 500)
                {
                    Console.WriteLine("Breaking loop");
                    loopState.Break();
                }
                return;
            });
        }


        public void UsingAsycAndAwait()
        {
            string result = UsingAsyncAndAwaitDownloadContentMethod().Result;
            Console.WriteLine(result);
        }

        public static async Task<string> UsingAsyncAndAwaitDownloadContentMethod()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.streets-heaver.com");
                return result;
            }
        }
    }
}
