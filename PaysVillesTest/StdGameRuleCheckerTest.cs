using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaysVilles;
using Moq;
using PVRepositories;



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

        [TestMethod]
        public void Test_StdGameRuleChecker_ReturnsTrue_WhenCheckIfWordExistMethodIsCalled_GivenAnExistingWordForGeneralTheme()
        {
            //Arrange
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker();
            Thema theme = new Thema() { Name = "General" };
            string myWord = "Bonjour";
            //Act
            bool testValue = ruleChecker.CheckIfWordExist(myWord,theme);
            //Assert
            Assert.AreEqual(true, testValue);

        }

        [TestMethod]
        public void Test_StdGameRuleChecker_ReturnsFalse_WhenCheckIfWordExistMethodIsCalled_GivenAnNonExistingWordForGeneralTheme()
        {
            //Arrange
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker();
            Thema theme = new Thema() { Name = "General" };
            string myWord = "poulouipzza";
            //Act
            bool testValue = ruleChecker.CheckIfWordExist(myWord,theme);
            //Assert
            Assert.AreEqual(false, testValue);

        }

        [TestMethod]
        public void Test_StdGameRuleChecker_ReturnsTrue_WhenCheckIfWordExistMethodIsCalled_GivenAnExistingWordForCountryTheme()
        {
            //Arrange
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker();
            string myWord = "Albania";
            Thema theme = new Thema() { Name = "Country" };
            //Act
            bool testValue = ruleChecker.CheckIfWordExist(myWord, theme);
            //Assert
            Assert.AreEqual(true, testValue);

        }

        [TestMethod]
        public void Test_StdGameRuleChecker_ReturnsFalse_WhenCheckIfWordExistMethodIsCalled_GivenAnNonExistingWordForCountryTheme()
        {
            //Arrange
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker();
            string myWord = "Indianstan";
            Thema theme = new Thema() { Name = "Country" };
            //Act
            bool testValue = ruleChecker.CheckIfWordExist(myWord, theme);
            //Assert
            Assert.AreEqual(false, testValue);

        }

        [TestMethod]
        public void Test_StdGameRuleChecker_ReturnsTrue_WhenCheckIfWordExistMethodIsCalled_GivenAnExistingWordForPokemonTheme()
        {
            //Arrange
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker();
            string myWord = "Charizard";
            Thema theme = new Thema() { Name = "Pokemon" };
            //Act
            bool testValue = ruleChecker.CheckIfWordExist(myWord, theme);
            //Assert
            Assert.AreEqual(true, testValue);

        }

        [TestMethod]
        public void Test_StdGameRuleChecker_ReturnsFalse_WhenCheckIfWordExistMethodIsCalled_GivenAnNonExistingWordForPokemonTheme()
        {
            //Arrange
            StdGameRuleChecker ruleChecker = new StdGameRuleChecker();
            string myWord = "Agumon";
            Thema theme = new Thema() { Name = "Pokemon" };
            //Act
            bool testValue = ruleChecker.CheckIfWordExist(myWord, theme);
            //Assert
            Assert.AreEqual(false, testValue);

        }

        //[TestMethod]
        //public void Test_StdGameRuleChecker_ReturnsTrue_WhenCheckThemeMethodIsCalled_GivenAthemeAndAWordRespectingTheTheme()
        //{
        //    //Arrange
        //    StdGameRuleChecker ruleChecker = new StdGameRuleChecker(alphaCheck.Object);
        //    Thema myTheme = new Thema() { Name = "Pokemon" };
        //    //Act
        //    bool testValue = ruleChecker.CheckTheme(myTheme, "Pikachu");
        //    //Assert
        //    Assert.AreEqual(true, testValue);

        //}

        //[TestMethod]
        //public void Test_StdGameRuleChecker_ReturnsFalse_WhenCheckThemeMethodIsCalled_GivenAthemeAndAWordNotRespectingTheTheme()
        //{
        //    //Arrange
        //    StdGameRuleChecker ruleChecker = new StdGameRuleChecker(alphaCheck.Object);
        //    Thema myTheme = new Thema() { Name = "Pokemon" };
        //    //Act
        //    bool testValue = ruleChecker.CheckTheme(myTheme, "Agumon");
        //    //Assert
        //    Assert.AreEqual(false, testValue);

        //}




        
    }
}
