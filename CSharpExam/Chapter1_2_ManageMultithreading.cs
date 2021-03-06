﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Concurrent;

namespace CSharpExam
{
    class Chapter1_2_ManageMultithreading
    {
        public void AccessingSharedData()
        {
            int n = 0;

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    n++;
                }
            });

            var down = Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    n--;
                }
            });
            up.Wait();
            Console.WriteLine(n);
        }


        public void UsingLockKeyword()
        {
            int n = 0;

            object _lock = new object();

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    lock (_lock)
                    n++;
                }
            });

            var down = Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    lock (_lock)
                        n--;
                }
            });
            up.Wait();
            Console.WriteLine(n);
        }

        public void CreatingADeadlock()
        {
            object lockA = new object();
            object lockB = new object();

            var up = Task.Run(() =>
            {
                lock (lockA)
                {
                    Thread.Sleep(1000);
                    lock (lockB)
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });

            lock (lockB)
            {
                lock (lockA)
                {
                    Console.WriteLine("Locked B and A");
                }
            }
            up.Wait();
        }

        public void IncrementDecrement()
        {
            int n = 0;

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Interlocked.Increment(ref n);
                }
            });

            for (int i = 0; i < 10000; i ++)
            {
                Interlocked.Decrement(ref n);
            }

            up.Wait();
            Console.WriteLine(n);
        }

        public void CancellingATask()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(500);
                }

            }, token);

            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();
            cancellationTokenSource.Cancel();

            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
            cancellationTokenSource.Dispose();
        }

        public void ThrowingOperationCancelledException()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(500);
                }

                token.ThrowIfCancellationRequested();

            }, token);

            try
            {
                Console.WriteLine("Press enter to stop the task");
                Console.ReadLine();
                cancellationTokenSource.Cancel();
                task.Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions[0].Message);
            }
            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
            cancellationTokenSource.Dispose();
        }


        public void AddingContinuationForCancelledTsks()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Console.WriteLine("Press enter to stop the task");

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(500);
                }
                token.ThrowIfCancellationRequested();
            }, token).ContinueWith((t) =>
            {
                Console.WriteLine("You have cancelled the task.");
            }, TaskContinuationOptions.OnlyOnCanceled);

            Console.ReadLine();
            cancellationTokenSource.Cancel();
            task.Wait();
            cancellationTokenSource.Dispose();
        }

        public void SettingaTimeoutOnATsk()
        {
            Console.WriteLine("This task will timeout in 10 seconds.");
            int x = 0;
            Task longRunning = Task.Run(() =>
            {
                while (x == 0)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(500);
                }
            });

            int index = Task.WaitAny(new[] { longRunning }, 10000);

            if (index == -1)
            {
                Console.WriteLine("Task timed out.");
            }
        }



    }
}

