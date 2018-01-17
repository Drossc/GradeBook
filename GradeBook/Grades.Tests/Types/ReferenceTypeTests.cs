//add needed namespace
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    //Give attribute
    [TestClass]

    //Make this public
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f,grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "someone";
            //Does not show code error but does fail test due to not reassigning value
            name.ToUpper();
            //Reassigns value to pass test
            name = name.ToUpper();
            Assert.AreEqual("SOMEONE", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 01, 01);
            //Causes the test to fail as the value is not assigned to date with an increase
            //date.AddDays(1);
            //Will allow the test to pass with expected increase due to reassigning
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            //Initialize variable
            int x = 46;
            //Calls private method to increase value
            IncrementNumber(x);

            Assert.AreEqual(46, x);
            //Test passes due to x value passes into IncrementNumber but does not return any value or change x
        }

        private void IncrementNumber(int number)
        {
            //number = number + 1;
            //alternate way to same increment
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            //Without GiveBookAName below, book1 will not have a name
            //During GiveBookAName all three variables are pointed to the same object of
            //GradeBook and any changes made are then made for all variables
            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);
            Assert.AreEqual("A GradeBook",book2.Name);
            //If more than one Assert entered, all test will fail.  Results will specify which assert failed though
            //Assert.AreNotEqual("A GradeBook",book1.Name);
        }

        //Create private method to use in test method
        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            //Initialize Value Types
            string name1 = "Someone";
            string name2 = "someone";

            //Compares the two strings into a boolean result
            bool result = String.Equals(name1,name2,StringComparison.InvariantCultureIgnoreCase);

            //Confirms if the comparison result is true to pass the test
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }
        //Write a test method
        [TestMethod]
        public void GradeBookVariablesHoldAReferenceO()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Someone's grade book.";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
