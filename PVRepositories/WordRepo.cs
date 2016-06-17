using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PVRepositories
{
    public class WordRepo
    {
        //This class is responsible for the conversion of the word lists into a Word object list.

        //Properties

        public List<Word> List { get; set; }

        //Constructors

        //Methods

       virtual public List<object> GetAll() 
        {
            return new List<object>();
        }

       public void Load()
       {
           //../../dictionnary/car.txt

         string carPath = "../../dictionnary/car.txt";
         string countryPath = "../../dictionnary/country.txt";
         string pokemonPath = "../../dictionnary/pokemon.txt";
         string capitalpath = "../../dictionnary/capitalcity.txt";
         string generalpath = "../../dictionnary/general.txt";
           
           List<string> ThemaPathList = new List<string>() { carPath, countryPath, pokemonPath, capitalpath, generalpath };
            

            foreach (string path in ThemaPathList) 
           {
               TextReader reader = (TextReader)File.OpenText(path);

               do
               {
                   Word word = new Word();
                   word.Name = reader.ReadLine();
                   //Extraction of the thema from the path
                   word.ThemaList.Add(new Thema() { Name = path.Substring(18, path.Length - 22) });
                   List.Add(word);

               } while (reader.Peek() != -1);

               reader.Close();
           }
           
       }


       public Word GetWordByName(string searchedName) 
       {

           return List.Find(x => x.Name == searchedName);
       }


    }
}
