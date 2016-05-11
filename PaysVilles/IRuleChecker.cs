using PVRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilles
{
    public interface IRuleChecker
    {
        //Methods
         bool CheckRule(char gameLetter, string word);

         bool CheckTheme(Thema myTheme, string word);

         bool CheckIfWordExist(string myWord);
  
    }
}
