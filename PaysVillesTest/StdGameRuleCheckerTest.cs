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
            
            alphaCheck.Setup(x => x.IsALetter("A")).Returns(true);
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker(alphaCheck.Object);
            string gameLetter = "A";
            //Act
            bool testValue = ruleChecker.CheckWord(gameLetter,"Bonjour");
            //Assert
            Assert.AreEqual(false, testValue);

        }

        [TestMethod]
        public void Test_StdGameRuleChecker_ReturnsTrue_WhenCheckWordMethodIsCalled_GivenThegameLetterAAndAStringBeginningWithLetterA()
        {
            //Arrange
            alphaCheck.Setup(x => x.IsALetter("A")).Returns(true);
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker(alphaCheck.Object);
            string gameLetter = "A";
            //Act
            bool testValue = ruleChecker.CheckWord(gameLetter, "Allo");
            //Assert
            Assert.AreEqual(true, testValue);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidArgumentException))]
        public void Test_StdGameRuleChecker_ThrowsAnInValidArgumentException_WhenCheckWordMethodIsCalled_GivenAgameLetterArgumentWithMoreThanOneLetter()
        {
            //Arrange
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker();
            string gameLetter = "Averoes";
            //Act
            ruleChecker.CheckWord(gameLetter, "Allo");

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidArgumentException))]
        public void Test_StdGameRuleChecker_ThrowsAnInValidArgumentException_WhenCheckWordMethodIsCalled_GivenAnEmptyGameLetterArgument()
        {
            //Arrange
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker();
            string gameLetter = "";
            //Act
            ruleChecker.CheckWord(gameLetter, "Allo");

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidArgumentException))]
        public void Test_StdGameRuleChecker_ThrowsAnInValidArgumentException_WhenCheckWordMethodIsCalled_GivenAGameLetterWhichIsnotALetter()
        {
            //Arrange
            alphaCheck.Setup(x => x.IsALetter("8")).Returns(false);

            StdGameRuleChecker ruleChecker = new StdGameRuleChecker(alphaCheck.Object);
            string gameLetter = "8";
            //Act
            ruleChecker.CheckWord(gameLetter, "Allo");

        }
    }
}
