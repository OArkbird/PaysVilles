using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PaysVilles
{
    public class StdGameRuleChecker : IRuleCheker
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

        public bool CheckWord(char gameLetter, string word)
        {

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
    }
}
