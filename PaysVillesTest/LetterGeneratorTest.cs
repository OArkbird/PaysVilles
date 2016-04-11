using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaysVilles;
using System.Collections.Generic;
namespace PaysVillesTest
{
    //LetterGenerator: Genere une lettre aleatoire
    [TestClass]
    public class LetterGeneratorTest
    {
         LetterGenerator generator;

        [TestInitialize]
        public void Setup() 
        { 
           generator = new LetterGenerator();
            
        }

        [TestMethod]
        public void Test_LetterGenerator_ReturnsALetter_When_GenerateMethodIsCalled()
        {
            //Arrange
            List<string> letterRange = new List<string>() 
            { 
                "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t",
                "u","v","w","x","y","z"
            };   
            //Act
            string testValue = generator.Generate();
            //Assert
            Assert.IsFalse(!letterRange.Exists(x => x == testValue.ToLower()));
        }

        [TestMethod]
        public void Test_LetterGenerator_ReturnsTwoDifferentLetters_When_GenerateMethodIsCalledTwiceInARaw()
        {
            //Arrange
            //Act
            string testValue1 = generator.Generate();
            string testValue2 = generator.Generate();

            //Assert
            Assert.AreNotEqual(testValue1, testValue2);
        }
        
    }
}
