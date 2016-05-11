using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVRepositories;
using PaysVilles.Exceptions;

namespace PaysVilles
{
    public class ThemeGenerator
    {
        //Properties

        Random randGen = new Random();

        private List<Thema> themeList = new List<Thema>();
        
        public List<Thema> ThemeList 
        {
            get { return themeList; }
            set { themeList = value; }
        }

        //Constructors
        public ThemeGenerator() 
        { 
            
        }

        public ThemeGenerator(List<Thema> injectedList)
        {
            themeList = injectedList;
        }
        
        // Methods
        public Thema Generate()
        {
            //Randomly returns a Thema object from the Thema list
            if (themeList.Count == 0) 
            {
                throw new EmptyListException("The List of Theme is empty");
            }
            else 
            {
                return themeList[randGen.Next(0, themeList.Count)];
            
            }
           
        }
    }
}
