using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVRepositories
{
    public class Word
    {
        //Properties

        public string Name { get;set; }
        
        public List<Thema> ThemaList
        {
            get;
            set;
        }
        
        //Constructors
        public Word() 
        {
            ThemaList = new List<Thema>();
        }

    }
}
