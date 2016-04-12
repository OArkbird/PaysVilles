using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaysVilles;

namespace PaysVillesTest
{
    [TestClass]
    public class AlphaCheckerTest
    {
        [TestMethod]
        public void Test_AlphaChecher_ReturnsTrue_WhenIsALetterIsCalled_GivenThecharAInArgument()
        {
            //Arrange
            AlphaChecker alphaCheck = new AlphaChecker();
            //Act

            bool testValue = alphaCheck.IsALetter('A');
            //Assert
            Assert.AreEqual(true, testValue);
        }

        [TestMethod]
        public void Test_AlphaChecher_ReturnsTrue_WhenIsALetterIsCalled_GivenThecharALowerCaseInArgument()
        {
            //Arrange
            AlphaChecker alphaCheck = new AlphaChecker();
            //Act

            bool testValue = alphaCheck.IsALetter('a');
            //Assert
            Assert.AreEqual(true, testValue);
        }

        [TestMethod]
        public void Test_AlphaChecher_ReturnsFalse_WhenIsALetterIsCalled_GivenThechar9InArgument()
        {
            //Arrange
            AlphaChecker alphaCheck = new AlphaChecker();
            //Act

            bool testValue = alphaCheck.IsALetter('9');
            //Assert
            Assert.AreEqual(false, testValue);
        }

        [TestMethod]
        public void Test_AlphaChecher_ReturnsFalse_WhenIsALetterIsCalled_GivenASpecialcharInArgument()
        {
            //Arrange
            AlphaChecker alphaCheck = new AlphaChecker();
            //Act

            bool testValue = alphaCheck.IsALetter('#');
            //Assert
            Assert.AreEqual(false, testValue);
        }

        [TestMethod]
        public void Test_AlphaChecher_ReturnsFalse_WhenIsALetterIsCalled_GivenAnotherSpecialcharInArgument()
        {
            //Arrange
            AlphaChecker alphaCheck = new AlphaChecker();
            //Act

            bool testValue = alphaCheck.IsALetter('/');
            //Assert
            Assert.AreEqual(false, testValue);
        }

    }
}
