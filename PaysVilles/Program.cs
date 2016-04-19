using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaysVilles
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Bienvenue sur PAYSVILLES");
            LetterGenerator Lgenerator = new LetterGenerator();
            int Themenumber = 5;
            List<string> themeList = new List<string>() { "Pays","Villes","Pokemon","Football Player","Video Game"};
            string gameLetter = Lgenerator.Generate();
            Console.WriteLine("Cycle 1, nous joueons avec la lettre: " + gameLetter);

            List<string> answersList = new List<string>();

            foreach(string theme in themeList) 
            {
                Console.WriteLine("Ecrivez un mot lie au theme suivant: " + theme);
                answersList.Add(Console.ReadLine());
            }


            

            
        }
    }
}
