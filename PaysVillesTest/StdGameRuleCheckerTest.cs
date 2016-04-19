using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaysVilles;
using Moq;



namespace PaysVillesTest
{
    [TestClass]
    public class StdGameRuleCheckerTest
    {
        Mock<AlphaChecker> alphaCheck;

        [TestInitialize]
        public void Setup() 
        {
           alphaCheck = new Mock<AlphaChecker>();
        
        }

        [TestMethod]
        public void Test_StdGameRuleChecker_ReturnsFalse_WhenCheckWordMethodIsCalled_GivenThegameLetterAAndAStringNotBeginningWithLetterA()
        {
            //Arrange
            
            alphaCheck.Setup(x => x.IsALetter('A')).Returns(true);
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker(alphaCheck.Object);
            char gameLetter = 'A';
            //Act
            bool testValue = ruleChecker.CheckLetter(gameLetter,"Bonjour");
            //Assert
            Assert.AreEqual(false, testValue);

        }

        [TestMethod]
        public void Test_StdGameRuleChecker_ReturnsTrue_WhenCheckWordMethodIsCalled_GivenThegameLetterAAndAStringBeginningWithLetterA()
        {
            //Arrange
            alphaCheck.Setup(x => x.IsALetter('A')).Returns(true);
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker(alphaCheck.Object);
            char gameLetter = 'A';
            //Act
            bool testValue = ruleChecker.CheckLetter(gameLetter, "Allo");
            //Assert
            Assert.AreEqual(true, testValue);

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidArgumentException))]
        public void Test_StdGameRuleChecker_ThrowsAnInvalidArgumentException_WhenCheckWordMethodIsCalled_GivenASpaceChargameLetter()
        {
            //Arrange
            alphaCheck.Setup(x => x.IsALetter(' ')).Returns(false);
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker(alphaCheck.Object);
            char gameLetter = ' ';
            //Act
            bool testValue = ruleChecker.CheckLetter(gameLetter, "Allo");
            //Assert
           

        }


        
    }
}
