using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaysVilles;

namespace PaysVillesTest
{
    [TestClass]
    public class StdGameRefereeTest
    {
        [TestMethod]
        public void Test_StdGameReferee_ReturnsZero_WhenCalculateScoreMethodIsCalled_GivenAPlayerWithNoAnswers()
        {
            //Arrange
            Player myPlayer = new Player();
            StdGameReferee referee = new StdGameReferee();
            //Act
            var testValue = referee.CalculateScore(myPlayer);
            //Assert
            Assert.AreEqual(0,testValue);
        }

        [TestMethod]
        public void Test_StdGameReferee_Returns10_WhenCalculateScoreMethodIsCalled_GivenAPlayerWithExactlyOneTenletterWordInhisAnswerList()
        {
            //Arrange
            Player myPlayer = new Player();
            myPlayer.AnswerList.Add("TenLetters");
            StdGameReferee referee = new StdGameReferee();
            //Act
            var testValue = referee.CalculateScore(myPlayer);
            //Assert
            Assert.AreEqual(10, testValue);
        }

        [TestMethod]
        public void Test_StdGameReferee_Returns20_WhenCalculateScoreMethodIsCalled_GivenAPlayerWithExactlyTwoTenletterWordInhisAnswerList()
        {
            //Arrange
            Player myPlayer = new Player();
            myPlayer.AnswerList.Add("TenLetters");
            myPlayer.AnswerList.Add("TenLetters");
            StdGameReferee referee = new StdGameReferee();
            //Act
            var testValue = referee.CalculateScore(myPlayer);
            //Assert
            Assert.AreEqual(20, testValue);
        }

        [TestMethod]
        public void Test_StdGameReferee_Returns16_WhenCalculateScoreMethodIsCalled_GivenAPlayerWithExactlyOneTenletterWordAndExactlyOne6LetterWordInhisAnswerList()
        {
            //Arrange
            Player myPlayer = new Player();
            myPlayer.AnswerList.Add("TenLetters");
            myPlayer.AnswerList.Add("SixLet");
            StdGameReferee referee = new StdGameReferee();
            //Act
            var testValue = referee.CalculateScore(myPlayer);
            //Assert
            Assert.AreEqual(16, testValue);
        }

        [TestMethod]
        public void Test_StdGameReferee_Returns45_WhenCalculateScoreMethodIsCalled_GivenAPlayerWithExactly5NineletterWordInhisAnswerList()
        {
            //Arrange
            Player myPlayer = new Player();
            myPlayer.AnswerList.Add("NineLette");
            myPlayer.AnswerList.Add("NineLette");
            myPlayer.AnswerList.Add("NineLette");
            myPlayer.AnswerList.Add("NineLette");
            myPlayer.AnswerList.Add("NineLette");
            StdGameReferee referee = new StdGameReferee();
            //Act
            var testValue = referee.CalculateScore(myPlayer);
            //Assert
            Assert.AreEqual(45, testValue);
        }

    }
}
