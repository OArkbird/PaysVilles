using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaysVilles;
using Moq;
using PVRepositories;
using System.Collections.Generic;



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
        public void Test_StdGameRuleChecker_ReturnsFalse_WhenCheckLetterMethodIsCalled_GivenThegameLetterAAndAStringNotBeginningWithLetterA()
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
        public void Test_StdGameRuleChecker_ReturnsTrue_WhenCheckLetterMethodIsCalled_GivenThegameLetterAAndAStringBeginningWithLetterA()
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
        public void Test_StdGameRuleChecker_ThrowsAnInvalidArgumentException_WhenCheckLetterMethodIsCalled_GivenASpaceChargameLetter()
        {
            //Arrange
            alphaCheck.Setup(x => x.IsALetter(' ')).Returns(false);
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker(alphaCheck.Object);
            char gameLetter = ' ';
            //Act
            bool testValue = ruleChecker.CheckLetter(gameLetter, "Allo");
            //Assert
           

        }

        [TestMethod]
        public void Test_StdGameRuleChecker_CallsGetAllMethodFromWordRepoClass_WhenCheckIfWordExistMethodIsCalled_GivenAGeneralThemeInArgument()
        {
            //Arrange
            Mock<IRepository> repo = new Mock<IRepository>();
            repo.Setup(x => x.GetAll()).Returns(new List<object>());
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker((WordRepo)repo.Object);
            
            //Act
            ruleChecker.CheckIfWordExist("anything");
            //Assert
            repo.Verify(x => x.GetAll());

        }

        [TestMethod]
        public void Test_StdGameRuleChecker_ReturnsTrue_WhenCheckIfWordExistMethodIsCalled_GivenAnExistingWord()
        {
            //Arrange
            List<object> wordList = new List<object>() {"pikachu", "reptincel","Raichu","Arbok","Tauros" };

            Mock<IRepository> repo = new Mock<IRepository>();
            repo.Setup(x => x.GetAll()).Returns(wordList);
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker((WordRepo)repo.Object);
            string myWord = "Raichu";
            //Act
            bool testValue = ruleChecker.CheckIfWordExist(myWord);
            //Assert
            Assert.AreEqual(true, testValue);

        }

        [TestMethod]
        public void Test_StdGameRuleChecker_ReturnsFalse_WhenCheckIfWordExistMethodIsCalled_GivenANonExistingWord()
        {
            //Arrange
            List<object> wordList = new List<object>() { "pikachu", "reptincel", "Raichu", "Arbok", "Tauros" };

            Mock<IRepository> repo = new Mock<IRepository>();
            repo.Setup(x => x.GetAll()).Returns(wordList);
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker((WordRepo)repo.Object);
            string myWord = "Gabumon";
            //Act
            bool testValue = ruleChecker.CheckIfWordExist(myWord);
            //Assert
            Assert.AreEqual(false, testValue);

        }

        [TestMethod]
        public void Test_StdGameRuleChecker_CallsGetAllMethodFromThemeRepoClass_WhenCheckThemeMethodIsCalled()
        {
            //Arrange
            Mock<IRepository> repo = new Mock<IRepository>();
            repo.Setup(x => x.GetAll()).Returns(new List<object>());
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker((ThemeRepo)repo.Object);
            Thema theme = new Thema();
            //Act
            ruleChecker.CheckTheme(theme,"Anything");
            //Assert
            repo.Verify(x => x.GetAll());

        }

        
    }
}
