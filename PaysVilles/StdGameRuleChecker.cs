using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVRepositories;



namespace PaysVilles
{
    public class StdGameRuleChecker : GameRuleChecker
    {
        //Constructors
        public StdGameRuleChecker():
            base()
        {
            
        }

        public StdGameRuleChecker(AlphaChecker injectedAlphaCheck): 
            base(injectedAlphaCheck)
        {
            
        }

        public StdGameRuleChecker(WordRepo injectedRepo): 
            base(injectedRepo)
        {
            
        }

        public StdGameRuleChecker(ThemeRepo injectedRepo): 
            base(injectedRepo)
        {
            
        }

        public StdGameRuleChecker(ThemeRepo injectedTRepo, WordRepo injectedWRepo)
            : base(injectedTRepo, injectedWRepo)
        {
            
        }

        //Methods
        public override bool CheckRule(char gameLetter, string word)
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
