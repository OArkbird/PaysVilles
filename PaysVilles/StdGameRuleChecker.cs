using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PaysVilles
{
    public class StdGameRuleChecker: IRuleCheker
    {
        AlphaChecker alphaCheck;

        public StdGameRuleChecker() 
        {
            alphaCheck = new AlphaChecker();
        }

        public StdGameRuleChecker(AlphaChecker injectedAlphaCheck) 
        {
            alphaCheck = injectedAlphaCheck;
        }

        public bool CheckWord(string gameLetter, string word)
        {
            
            if (gameLetter.Length == 1) 
            {
                if (alphaCheck.IsALetter(gameLetter))
                {
                    if (word[0].ToString() == gameLetter)
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
                    throw new InvalidArgumentException("The String should be a Letter");
                }
                
            }
            else 
            {
                throw new InvalidArgumentException("The String Length of the first argument have To be One");
            }
            
            
        }
    }
}
