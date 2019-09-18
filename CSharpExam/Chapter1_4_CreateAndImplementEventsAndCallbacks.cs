using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Concurrent;

namespace CSharpExam
{
    class Chapter1_4_CreateAndImplementEventsAndCallbacks
    {
        public delegate int Calculate(int x, int y);
        public int Add(int x, int y) { return x + y; }
        public int Multiply(int x, int y) { return x * y; }

        public delegate void Del();

        public void UsingADelegate()
        {

            Calculate calc = Add;
            Console.WriteLine(calc(3, 4)); //displays 7

            calc = Multiply;
            Console.WriteLine(calc(3, 4)); //displays 12
        }

        public void MulticastingDelegates()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();

            int invocationCount = d.GetInvocationList().GetLength(0);
            Console.WriteLine("Methods invoked by delegate: {0}", invocationCount);
        }

        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public void LambdaExpression()
        {
            Calculate calc = (x, y) => x + y;

            //lambda "=>" means "goes to"

            Console.WriteLine(calc(3, 4));

            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4));
        }
    }
}
