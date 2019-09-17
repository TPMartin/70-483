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

        public int ConditionalOperator(bool p)
        {
            if (p)
            {
                return 1;
            }
            else
            {
                return 0;
            }

            //above if statement could be replaced with: return p ? 1 : 0;
            //as using conditional operator will return the left value if the expression is true, or the right if false
        }

        public void SwitchStatement()
        {
            char input = 'a';

            switch (input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    {
                        Console.WriteLine("Vowel");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Consonant");
                        break;
                    }
            }
        }


        public void GoToSwitchStatement()
        {
            int i = 1;
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("Case 1");
                        goto case 2;
                    }
                case 2:
                    {
                        Console.WriteLine("Case 2");
                        break;
                    }
            }
        }

    }
}
