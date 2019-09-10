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

            ImplementMultithreading.CreateThread();
            ImplementMultithreading.StoppingAThread(false);
            ImplementMultithreading.UsingThreadStaticAttribute();
        }


    }
}
