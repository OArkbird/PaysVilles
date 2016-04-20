using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PVRepositories;
using PaysVilles.Exceptions;
using PaysVilles;
using System.Collections.Generic;

namespace PaysVillesTest
{
    [TestClass]
    public class ThemeGeneratorTest
    {
        [TestMethod]
        [ExpectedException(typeof(EmptyListException))]
        public void Test_ThemeGenerator_ReturnsAThemeObject_WhenGenerateMethodIsCalled()
        {
            //Arrange
            ThemeGenerator tGenerator = new ThemeGenerator();
            //Act
            var testResult = tGenerator.Generate();
            //Assert
            Assert.IsInstanceOfType(testResult, typeof(Thema));
        }

        [TestMethod]
        public void Test_ThemeGenerator_ReturnsTwoDifferentThemeObject_WhenGenerateMethodIsCalledTwiceInARow()
        {
            //Arrange
            
            List<Thema> themes = new List<Thema>() { new Thema() { Id = 0 }, new Thema() { Id = 2 }, new Thema() { Id = 3 }
            ,new Thema(){Id = 4},new Thema(){Id = 5}, new Thema(){Id = 6}, new Thema(){Id = 7}};
            ThemeGenerator tGenerator = new ThemeGenerator(themes);
            
            //Act
            var testResult1 = tGenerator.Generate();
            var testResult2 = tGenerator.Generate();
            //Assert
            Assert.AreNotEqual(testResult1.Id, testResult2.Id);
        }
    }
}
