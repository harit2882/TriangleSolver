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

        // Test Case For Scalene Triangle Validation For 2nd and 3rd
        [Test]
        public void ValidScaleneTriangle_Input3and4and5_OutputScaleneTriangle()
        {
            //Arrange
            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 5;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Case For Scalene Triangle Validation For Input 5,12,13
        [Test]
        public void ValidScaleneTriangle_Input5and12and13_OutputScaleneTriangle()
        {
            //Arrange
            int firstSide = 5;
            int secondSide = 12;
            int thirdSide = 13;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Case For Scalene Triangle Validation For Input 7,10,5
        [Test]
        public void ValidScaleneTriangle_Input7and10and5_OutputScaleneTriangle()
        {
            //Arrange
            int firstSide = 7;
            int secondSide = 10;
            int thirdSide = 5;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Case For Scalene Triangle Validation For Input 6,8,10
        [Test]
        public void ValidScaleneTriangle_Input6and8and10_OutputScaleneTriangle()
        {
            //Arrange
            int firstSide = 6;
            int secondSide = 8;
            int thirdSide = 10;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Case For Scalene Triangle Validation For Input 9,12,15
        [Test]
        public void ValidScaleneTriangle_Input9and12and15_OutputScaleneTriangle()
        {
            //Arrange
            int firstSide = 9;
            int secondSide = 12;
            int thirdSide = 15;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Case For Zero Length Triangle Validation For One Side
        [Test]
        public void ZeroLengthCheck_Input0and60and60_OutputInvalidTriangle()
        {
            //Arrange
            int firstSide = 0;
            int secondSide = 60;
            int thirdSide = 60;

            string expected = "Invalid Triangle - a zero has been detected";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Case For Zero Length Triangle Validation For Two Side
        [Test]
        public void ZeroLengthCheck_Input0and0and60_OutputInvalidTriangle()
        {
            //Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 60;

            string expected = "Invalid Triangle - a zero has been detected";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Case For Zero Length Triangle Validation For Three Side
        [Test]
        public void ZeroLengthCheck_Input0and0and0_OutputInvalidTriangle()
        {
            //Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 0;

            string expected = "Invalid Triangle - a zero has been detected";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Case For Invalid Response Triangle Validation For Input 1,2,3
        [Test]
        public void InvalidResponse_Input1and2and3_OutputInvalid()
        {
            //Arrange
            int firstSide = 1;
            int secondSide = 2;
            int thirdSide = 3;

            string expected = "INVALID!!";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Case For Invalid Response Triangle Validation For Input 2,4,7
        [Test]
        public void InvalidResponse_Input2and4and7_OutputInvalid()
        {
            //Arrange
            int firstSide = 2;
            int secondSide = 4;
            int thirdSide = 7;

            string expected = "INVALID!!";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Case For Invalid Response Triangle Validation For Input 5,10,5
        [Test]
        public void InvalidResponse_Input5and10and5_OutputInvalid()
        {
            //Arrange
            int firstSide = 5;
            int secondSide = 10;
            int thirdSide = 5;

            string expected = "INVALID!!";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

