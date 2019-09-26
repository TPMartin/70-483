using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExam
{
    class Program
    {
        static void Main()
        {
            Chapter1_1_ImplementMultithreading ImplementMultithreading = new Chapter1_1_ImplementMultithreading();
            Chapter1_2_ManageMultithreading ManageMultithreading = new Chapter1_2_ManageMultithreading();
            Chapter1_3_ImplementProgramFlow ImplementProgramFlow = new Chapter1_3_ImplementProgramFlow();
            Chapter1_4_CreateAndImplementEventsAndCallbacks EventsAndCallbacks = new Chapter1_4_CreateAndImplementEventsAndCallbacks();
            Chapter1_5_ImplementExceptionHandling ImplementExceptionHandling = new Chapter1_5_ImplementExceptionHandling();
            //Chapter2_1_CreateTypes. = new Chapter2_1_CreateTypes();

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

            //ImplementMultithreading.UsingAsycAndAwait();

            //ImplementMultithreading.UsingAsParallel();

            //ImplementMultithreading.UsingAsParallelOrdered();

            //ImplementMultithreading.CatchingAggregateException();

            //ImplementMultithreading.usingBlockingCollection();

            //ImplementMultithreading.enumeratingAConcurrentBag();

            //ImplementMultithreading.usingAConcurrentStack();

            //ImplementMultithreading.usingConcurrentQueue();

            //ImplementMultithreading.usingConcurrentDictionary();



            //------------------------------------------



            //ManageMultithreading.AccessingSharedData();

            //ManageMultithreading.UsingLockKeyword();

            //ManageMultithreading.CreatingADeadlock();

            //ManageMultithreading.IncrementDecrement();

            //ManageMultithreading.CancellingATask();

            //ManageMultithreading.ThrowingOperationCancelledException();

            //ManageMultithreading.AddingContinuationForCancelledTsks();

            //ManageMultithreading.SettingaTimeoutOnATsk();



            //------------------------------------------



            //ImplementProgramFlow.StandardIfStatement();

            //ImplementProgramFlow.NullCoalaescingOperator();

            //ImplementProgramFlow.ConditionalOperator(true);

            //ImplementProgramFlow.SwitchStatement();

            //ImplementProgramFlow.GoToSwitchStatement();

            //ImplementProgramFlow.ForLoop();

            //ImplementProgramFlow.WhileDoLoop();

            //ImplementProgramFlow.DoWhileLoop();

            //ImplementProgramFlow.ForeachLoop();

            //ImplementProgramFlow.JumpStatement();



            //------------------------------------------



            //EventsAndCallbacks.UsingADelegate();

            //EventsAndCallbacks.MulticastingDelegates();

            //EventsAndCallbacks.LambdaExpression();




            //------------------------------------------




            //ImplementExceptionHandling.CatchingAFormatException();

            //ImplementExceptionHandling.CatchingDifferentExceptionTypes();

            ImplementExceptionHandling.UsingFinallyBlock();

            ImplementExceptionHandling.UsingEnvironmentFailFast();

            ImplementExceptionHandling.InspectingAnException();

            ImplementExceptionHandling.ThrowingAnArgumentNullException();
            
        }
    }
}
