using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    class GradeBookTests
    {
        public void ComputeHighestGrade()
        {
            GradeBook gb = new GradeBook();
            gb.AddGrade(10);
            gb.AddGrade(90);

            GradeStatistics result = gb.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);

        }
        
    }
}
