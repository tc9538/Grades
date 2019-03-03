using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook gb = new GradeBook();
            gb.AddGrade(10);
            gb.AddGrade(90);

            GradeStatistics result = gb.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook gb = new GradeBook();
            gb.AddGrade(10);
            gb.AddGrade(90);

            GradeStatistics result = gb.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook gb = new GradeBook();
            gb.AddGrade(91);
            gb.AddGrade(89.5f);
            gb.AddGrade(75);

            GradeStatistics result = gb.ComputeStatistics();
            Assert.AreEqual(85.16, result.AverageGrade, 0.01);
        }

    }
}
