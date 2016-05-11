using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilles
{
    public class LetterGenerator
    {
        //This class is responsible for generating a random letter

        //Properties
        Random randGen = new Random();
        
        //Methods
        public char Generate()
        { //generate a random lower case letter
            return ((char)randGen.Next(97,122));
        }
    }
}
