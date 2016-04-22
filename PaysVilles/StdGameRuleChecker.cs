using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVRepositories;



namespace PaysVilles
{
    public class StdGameRuleChecker : IRuleCheker
    {
        //Members variables
        AlphaChecker alphaCheck;

        WordRepo wordRepo;
        ThemeRepo themeRepo;

        //Constructors
        public StdGameRuleChecker()
        {
            alphaCheck = new AlphaChecker();
            wordRepo =  new WordRepo();
            themeRepo = new ThemeRepo();
        }

        public StdGameRuleChecker(AlphaChecker injectedAlphaCheck)
        {
            alphaCheck = injectedAlphaCheck;
        }

        public StdGameRuleChecker(WordRepo injectedRepo)
        {
            wordRepo = injectedRepo;
        }

        public StdGameRuleChecker(ThemeRepo injectedRepo)
        {
            themeRepo = injectedRepo;
        }

        public StdGameRuleChecker(ThemeRepo injectedTRepo, WordRepo injectedWRepo)
        {
            wordRepo = injectedWRepo;
            themeRepo = injectedTRepo;
        }

        //Methods
        public bool CheckLetter(char gameLetter, string word)
        {
            // check if the word beggins with the gameletter
            if (alphaCheck.IsALetter(gameLetter))
            {
                if (word[0] == gameLetter)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new InvalidArgumentException("The char Argument is not a Letter");
            }
        }

        public bool CheckTheme(Thema myTheme, string word)
        {
            
            return true;
        }

        public bool CheckIfWordExist(string myWord)
        {
            List<object> words = wordRepo.GetAll();

            myWord = myWord.ToLower().Trim();
            bool wordIsFound = false;

            foreach(string listWord in words) 
            {
                if (myWord == listWord.ToLower().Trim()) 
                {
                    wordIsFound = true;
                }
            }

            return wordIsFound;
        }

        //public bool CheckIfWordExist(string myWord, Thema theme)
        //{
        //    System.IO.StreamReader dico = new System.IO.StreamReader("../../../Dictionnaires/" + theme.Name.ToLower() + ".txt");

        //    myWord = myWord.ToLower().Trim();
        //    string dicoWord =  dico.ReadLine().ToLower().Trim();
        //    bool wordIsFound = false;

        //    while (dicoWord != null && wordIsFound == false)
        //    {
        //        if (dicoWord.ToLower().Trim() == myWord)
        //        {
        //            wordIsFound = true;
        //        }
        //        else
        //        {
        //            dicoWord = dico.ReadLine();
        //        }

        //    }

        //    return wordIsFound;            
        //}


    }
}
