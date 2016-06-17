using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PVRepositories;

namespace PVRepositoriesTest
{
    [TestClass]
    public class WordRepoTest
    {
        [TestMethod]
        public void Test_WordRepo_LoadsAllTheWordsFromTheTextFileToHisWordList_WhenLoadMethodIsCalled()
        {
            //Arrange
            WordRepo myRepo = new WordRepo();
            int wordNumber = 0;
            //Act
            myRepo.Load();
            //Assert
            Assert.AreEqual(myRepo.List.Count, wordNumber);
        }
    }
}
