﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilles
{
    public class LetterGenerator
    {
        Random randGen = new Random();
        
        public char Generate()
        { 
            return ((char)randGen.Next(97,122));
        }
    }
}
