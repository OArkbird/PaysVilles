using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaysVilles;

namespace PaysVillesTest
{
    [TestClass]
    public class GameRefereeTest
    {
        [TestMethod]
        public void Test_GameReferee_ReturnsZero_WhenCalculateScoreMethodIsCalled_GivenAPlayerWithNoAnswers()
        {
            //Arrange
            Player myPlayer = new Player();
            GameReferee referee = new GameReferee();
            //Act
            var testValue = referee.CalculateScore(myPlayer);
            //Assert
            Assert.AreEqual(0,testValue);
        }

        [TestMethod]
        public void Test_GameReferee_Returns10_WhenCalculateScoreMethodIsCalled_GivenAPlayerWithExactlyOneTenletterWordInhisAnswerList()
        {
            //Arrange
            Player myPlayer = new Player();
            myPlayer.AnswerList.Add("TenLetters");
            GameReferee referee = new GameReferee();
            //Act
            var testValue = referee.CalculateScore(myPlayer);
            //Assert
            Assert.AreEqual(10, testValue);
        }

        [TestMethod]
        public void Test_GameReferee_Returns20_WhenCalculateScoreMethodIsCalled_GivenAPlayerWithExactlyTwoTenletterWordInhisAnswerList()
        {
            //Arrange
            Player myPlayer = new Player();
            myPlayer.AnswerList.Add("TenLetters");
            myPlayer.AnswerList.Add("TenLetters");
            GameReferee referee = new GameReferee();
            //Act
            var testValue = referee.CalculateScore(myPlayer);
            //Assert
            Assert.AreEqual(20, testValue);
        }

        [TestMethod]
        public void Test_GameReferee_Returns16_WhenCalculateScoreMethodIsCalled_GivenAPlayerWithExactlyOneTenletterWordAndExactlyOne6LetterWordInhisAnswerList()
        {
            //Arrange
            Player myPlayer = new Player();
            myPlayer.AnswerList.Add("TenLetters");
            myPlayer.AnswerList.Add("SixLet");
            GameReferee referee = new GameReferee();
            //Act
            var testValue = referee.CalculateScore(myPlayer);
            //Assert
            Assert.AreEqual(16, testValue);
        }

        [TestMethod]
        public void Test_GameReferee_Returns45_WhenCalculateScoreMethodIsCalled_GivenAPlayerWithExactly5NineletterWordInhisAnswerList()
        {
            //Arrange
            Player myPlayer = new Player();
            myPlayer.AnswerList.Add("NineLette");
            myPlayer.AnswerList.Add("NineLette");
            myPlayer.AnswerList.Add("NineLette");
            myPlayer.AnswerList.Add("NineLette");
            myPlayer.AnswerList.Add("NineLette");
            GameReferee referee = new GameReferee();
            //Act
            var testValue = referee.CalculateScore(myPlayer);
            //Assert
            Assert.AreEqual(45, testValue);
        }

    }
}
