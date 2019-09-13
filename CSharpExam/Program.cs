using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExam
{
    class Program
    {
        static void Main()
        {
            var ImplementMultithreading = new Chapter1_1_ImplementMultithreading();
            var ManageMultithreading = new Chapter1_2_ManageMultithreading();
            var ImplementProgramFlow = new Chapter1_3_ImplementProgramFlow();
            var CreateAndImplementEventsAndCallbacks = new Chapter1_4_CreateAndImplementEventsAndCallbacks();
            var ImplementExceptionHandling = new Chapter1_5_ImplementExceptionHandling();

            //Chapter 1

            //1.1 Implement Multithreading

            //ImplementMultithreading.CreateThread();

            //ImplementMultithreading.StoppingAThread(false);

            //ImplementMultithreading.UsingThreadLocal();

            //ImplementMultithreading.ThreadPooling();

            //ImplementMultithreading.CreatingATaskAndWaitingForitToFinish();

            //ImplementMultithreading.AddingAContinuationTask();

            //ImplementMultithreading.MultipleContinuationTasks();

            //ImplementMultithreading.attachingChildTasksToParentTask();

            //ImplementMultithreading.CreatingATaskFactory();

            //ImplementMultithreading.ParallelForAndForeachLoop();

            //ImplementMultithreading.BreakingParallelLoopUsingParallelLoopState();

            ImplementMultithreading.UsingAsycAndAwait();
        }


    }
}
