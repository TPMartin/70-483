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

        public void ForLoop()
        {
            int[] values = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }

        public void WhileDoLoop()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            int x = 0;
            while (x < values.Length) 
            {
                Console.WriteLine(values[x]);
                x++;
            }
        }


        public void DoWhileLoop()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            int x = 0;
            do //do while loops execute at least once
            {
                Console.WriteLine(values[x]);
                x++;
            }
            while (x < values.Length);

        }

        public void ForeachLoop()
        {
            int[] values = { 1, 2, 3, 4, 5 };

            foreach (int i in values)
            {
                Console.WriteLine(i);
            }
        }


        public void JumpStatement()
        {
            int x = 3;
            if (x == 3) goto customLabel;

            x = 5;

        customLabel:
            Console.WriteLine(x);
            //will output 3
        }

    }
}
