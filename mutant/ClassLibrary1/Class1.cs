using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mutant;
using NUnit.Framework;


namespace mutant

{
    [TestFixture]
    class CalcTests
    {
        [Test]
        public void GetAddition_Input5and6point6_Returns11point6()
        {

            //Arrange
            double number1 = 5;
            double number2 = 6.6;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.Addition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Input9point9and6_Returns15point9()
        {

            //Arrange
            double number1 = 9.9;
            double number2 = 6;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.Addition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Input1point1and1point2_Returns2point3()
        {

            //Arrange
            double number1 = 1.1;
            double number2 = 1.2;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.Addition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetSubtraction_Input10and5_Returns5()
        {

            //Arrange
            double number1 = 10;
            double number2 = 5;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.Subtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input6point5and5point5_Returns1()
        {

            //Arrange
            double number1 = 6.5;
            double number2 = 5.5;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.Subtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input9and1_Returns8()
        {

            //Arrange
            double number1 = 9;
            double number2 = 1;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.Subtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetMultiplication_Input10and10_Returns100()
        {

            //Arrange
            double number1 = 10;
            double number2 = 10;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.Multiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input9and11_Returns99()
        {

            //Arrange
            double number1 = 9;
            double number2 = 11;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.Multiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input1and25_Returns25()
        {

            //Arrange
            double number1 = 1;
            double number2 = 25;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.Multiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetDivision_Input14and7_Returns2()
        {

            //Arrange
            double number1 = 14;
            double number2 = 7;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.Division();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input15and3_Returns5()
        {

            //Arrange
            double number1 = 15;
            double number2 = 3;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.Division();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input99and11_Returns9()
        {

            //Arrange
            double number1 = 99;
            double number2 = 11;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.Division();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        //mutant test cases
       [Test]
        public void GetDivision_Input1and3_Returns0point33()
        {

          //  Arrange
            double number1 = 1;
            double number2 = 3;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

           // Act
            double actualResult = testCalc.Division();

           // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetDivision_Input2and1_Returns2()
        {

            //Arrange
            double number1 = 2;
            double number2 = 1;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

           // Act
            double actualResult = testCalc.Division();

           // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetDivision_Input9and3_Returns3()
        {

            //Arrange
            double number1 = 9;
            double number2 = 3;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.Division();

           // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}

