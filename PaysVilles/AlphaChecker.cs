using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PaysVilles
{
    public class AlphaChecker
    {
        Regex alphabet = new Regex("[a-z,A-Z]");
 
       virtual public bool IsALetter(char letter)
        {
            if (alphabet.IsMatch(letter.ToString()))
           {
               return true;
           }
            else 
            {
                return false;
            }
            
        }
    }
}
