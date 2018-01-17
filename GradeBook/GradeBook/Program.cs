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
            /* Move to Types.ReferenceTypeTests.cs
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1 = new GradeBook();
            g1.Name = "Someone's grade book.";
            */
           //Console.WriteLine(g2.Name);
            
          
            //Instantiate Speech Synthesizer
            SpeechSynthesizer synth = new SpeechSynthesizer();
            //What to have system speek
            synth.Speak("Hello! This is the grade book program");

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            //GradeBook book2 = new GradeBook();

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            // GradeBook book2 = book;
            //book2.AddGrade(75);
        
        }
    }
}
