using System;
using System.Collections.Generic;
using System.Linq;
//have to state using assembly
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
//Default assemblies may not always be enough to complete a project
//Also may have to reference other projects

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics(); 
            //Console.WriteLine(stats.AverageGrade);
            WriteResult("Average", stats.AverageGrade);
            //Console.WriteLine(stats.HighestGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            //Console.WriteLine(stats.LowestGrade);
            WriteResult("Lowest", stats.LowestGrade);
        }

        //These are examples of helper methods (Method Overloading)
        //Use different signatures due to type of result 
        //VS can use smart logic to determine which one, usually
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            //Both can do a similar result but may be easier to understand 
            //the expected output based on writing
            //Console.WriteLine(description + ": " + result);
            //Console.WriteLine("{0}: {1:F2}", description, result);

            //Formats the result as a float with two decimal places and rounds
            //Console.WriteLine("{0}: {1:F2}", description, result);

            //Formats the result as a currency
            Console.WriteLine("{0}: {1:C}", description, result);
        }
    }
}
