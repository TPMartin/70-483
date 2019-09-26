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
    class Chapter1_5_ImplementExceptionHandling
    {
        public void CatchingAFormatException()
        {
            while (true)
            {
                Console.WriteLine("Please enter an integer:\n");
                string s = Console.ReadLine();
                Console.WriteLine();

                if (string.IsNullOrWhiteSpace(s)) break;

                try
                {
                    int i = int.Parse(s);
                    Console.WriteLine("Your number is: {0}.", i);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("'{0}' is not a valid number. Please try again.\n", s);
                    Console.WriteLine("-----------------\n");
                }
            }
        }

        public void CatchingDifferentExceptionTypes()
        {
            while (true)
            {
                Console.WriteLine("Please enter an integer:\n");
                string s = null;
                Console.WriteLine();


                try
                {
                    int i = int.Parse(s);
                    Console.WriteLine("Your number is: {0}.", i);
                    break;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You need to enter a value.\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("'{0}' is not a valid number. Please try again.\n", s);
                    Console.WriteLine("-----------------\n");
                }
            }
        }

        public void UsingFinallyBlock()
        {
            string s = Console.ReadLine();

            try
            {
                int i = int.Parse(s);
                
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You need to enter a value.");
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not a valid number. Please try again.\n", s);
            }
            finally
            {
                Console.WriteLine("-Program complete-");
            }
        }

        public void UsingEnvironmentFailFast()
        {
            string s = Console.ReadLine();

            try
            {
                int i = int.Parse(s);
                if (i == 42) Environment.FailFast("Special number entered");
            }
            finally
            {
                Console.WriteLine("Program complete");
            }
        }

        public void InspectingAnException()
        {
            try
            {
                int i = ReadAndParse();
                Console.WriteLine("Parsed: {0}", i);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("StackTrace: {0}", e.StackTrace);
                Console.WriteLine("Helplink: {0}", e.HelpLink);
                Console.WriteLine("InnerException: {0}", e.InnerException);
                Console.WriteLine("TargetSite: {0}", e.TargetSite);
                Console.WriteLine("Source: {0}", e.Source);
            }
        }

        public int ReadAndParse()
        {
            string s = Console.ReadLine();
            int i = int.Parse(s);
            return i;
        }

        public void ThrowingAnArgumentNullException()
        {

        }
    }
}
