using PVRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilles
{
    abstract public class GameRuleChecker:IRuleChecker
    {
       protected AlphaChecker alphaCheck;
       protected WordRepo wordRepo;
       protected ThemeRepo themeRepo;

        //Constructors
        public GameRuleChecker()
        {
            alphaCheck = new AlphaChecker();
            wordRepo =  new WordRepo();
            themeRepo = new ThemeRepo();
        }

        public GameRuleChecker(AlphaChecker injectedAlphaCheck)
        {
            alphaCheck = injectedAlphaCheck;
        }

        public GameRuleChecker(WordRepo injectedRepo)
        {
            wordRepo = injectedRepo;
        }

        public GameRuleChecker(ThemeRepo injectedRepo)
        {
            themeRepo = injectedRepo;
        }

        public GameRuleChecker(ThemeRepo injectedTRepo, WordRepo injectedWRepo)
        {
            wordRepo = injectedWRepo;
            themeRepo = injectedTRepo;
        }

        //Methods
        abstract public bool CheckRule(char gameLetter, string word);

        public bool CheckTheme(Thema myTheme, string word)
        {
             wordRepo.GetAll();
             new NotImplementedException();
             return true;
        }

        public bool CheckIfWordExist(string myWord)
        {
            //Check if the myWord is in the list of existing words
            List<object> words = wordRepo.GetAll();

            myWord = myWord.ToLower().Trim();
            bool wordIsFound = false;

            foreach (string listWord in words)
            {
                if (myWord == listWord.ToLower().Trim())
                {
                    wordIsFound = true;
                }
            }

            return wordIsFound;
        }
    }
}
