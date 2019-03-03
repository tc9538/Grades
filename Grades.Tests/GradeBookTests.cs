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

    }
}
