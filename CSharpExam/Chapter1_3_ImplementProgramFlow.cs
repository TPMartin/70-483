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
    class Chapter1_3_ImplementProgramFlow
    {
        public void StandardIfStatement()
        {
            bool b = true;

            if (b)
            {
                Console.WriteLine("B is True");
            }
        }

        public void NullCoalaescingOperator()
        {
            int? x = null;
            int y = x ?? -1;

            if (y == -1)
            {
                Console.WriteLine("Y is equal to -1.");
            }

            //the ?? operator is called the null-coalescing operator, it returns the left value if its not null, otherwise it returns the right operator.

            //in this case, the value of y will be -1 because x is null
        }


    }
}
