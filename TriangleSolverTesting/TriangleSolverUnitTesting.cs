using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TriangleSolverTesting
{
    public class TriangleSolverUnitTesting
    {
        // Test Case For Equilateral Triangle Validation
        [Test]
        public void ValidEquilateralTriangle_Input60and60and60_OutputEquilateralTriangle()
        {
            // Arrange
            int firstSide = 60;
            int secondSide = 60;
            int thirdSide = 60;

            string expected = "Equilateral triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Case For Isosceles Triangle Validation For 1st and 2nd Side
        [Test]
        public void ValidIsoscelesTriangle_Input60and60and70_OutputIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 60;
            int secondSide = 60;
            int thirdSide = 70;

            string expected = "Isosceles triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Case For Isosceles Triangle Validation For 1st and 3rd Side
        [Test]
        public void ValidIsoscelesTriangle_Input60and70and60_OutputIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 60;
            int secondSide = 70;
            int thirdSide = 60;

            string expected = "Isosceles triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Case For Isosceles Triangle Validation For 2nd and 3rd Side
        [Test]
        public void ValidIsoscelesTriangle_Input70and60and60_OutputIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 70;
            int secondSide = 60;
            int thirdSide = 60;

            string expected = "Isosceles triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}

