//using PVRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using PVRepositories;

namespace PaysVilles
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            List<Word> List = new List<Word>();
            string carPath = "../../../PaysVilleApp/dictionnary/car.txt";
            string countryPath = "../../../PaysVilleApp/dictionnary/country.txt";
            string pokemonPath = "../../../PaysVilleApp/dictionnary/pokemon.txt";
            string capitalpath = "../../../PaysVilleApp/dictionnary/capitalcity.txt";
            string generalpath = "../../../PaysVilleApp/dictionnary/general.txt";

            List<string> ThemaPathList = new List<string>() { carPath, countryPath, pokemonPath, capitalpath, generalpath };


            foreach (string path in ThemaPathList)
            {
                TextReader reader = (TextReader)File.OpenText(path);

                do
                {
                    Word word = new Word();
                    word.Name = reader.ReadLine();
                    //Extraction of the thema from the path
                    word.ThemaList.Add(new Thema() { Name = path.Substring(34, path.Length - 38) });
                    List.Add(word);

                } while (reader.Peek() != -1);

                reader.Close();
            }
            for (int i = 800; i <1800; i++) 
            {
                Console.WriteLine(List[i].Name + " " +List[i].ThemaList[0].Name);
                
            }
            Console.Read();
               
                
                //System.IO.StreamReader dico = new System.IO.StreamReader("../../../Dictionnaires/dicoUK.txt");

                //string searchedWord = "namibia";
                //string dicoWord = dico.ReadLine();
                //bool wordIsFound = false;

                //while( dicoWord != null && wordIsFound == false) 
                //{
                //    if (dicoWord == searchedWord)
                //    {
                //        wordIsFound = true; 
                //        Console.WriteLine("The word " + searchedWord + " was found");
                //    }
                //    else 
                //    {
                //            dicoWord = dico.ReadLine();

                //    }


                //}
                //if (wordIsFound == false) 
                //{ 
                //    Console.WriteLine("The word is not in the list");
                //}
                //Console.Read();



                ////Introduction
                //Console.WriteLine("Bienvenue sur PAYSVILLES");

                ////Game Setting
                //List<Thema> themes = new List<Thema>() { new Thema() { Id = 0, Name = "Pays" }, new Thema() { Id = 2, Name = "Villes" }, new Thema() { Id = 3, Name = "Pokemon" }
                //,new Thema(){Id = 4},new Thema(){Id = 5, Name = "Film"}, new Thema(){Id = 6, Name = "Jeu Video"}, new Thema(){Id = 7, Name = "Sport"}};

                //StdGameRuleChecker checker = new StdGameRuleChecker();
                //ThemeGenerator tGenerator = new ThemeGenerator(themes);
                //int themeNumber = 8;
                //int phaseNumber = 5;
                //Thema theme;
                //GameReferee referee = new GameReferee();
                //Player playerOne = new Player();

                ////GameLoop
                //LetterGenerator lGenerator = new LetterGenerator();

                ////PhaseLoops
                //for (int i = 1; i <= phaseNumber; i++) 
                //{
                //    string playerWord = "";
                //    playerOne.AnswerList = new List<string>();
                //    char gameLetter = lGenerator.Generate();

                //    Console.WriteLine("Cycle 1, nous joueons avec la lettre: " + gameLetter);
                //    Console.WriteLine("Debut de la phase " + i);
                //    //ActionLoops
                //    for (int j = 0; j < themeNumber; j++) 
                //    {
                //        theme = tGenerator.Generate();

                //        playerWord = Console.ReadLine();

                //        //Check word Begins with the gameLetter
                //        while (!checker.CheckLetter(gameLetter, playerWord)) 
                //        {
                //            Console.WriteLine("Attention, le mot entre ne debute pas par la letre " + gameLetter);
                //            Console.WriteLine("Veuillez reiterer votre reponse");
                //            playerWord = Console.ReadLine();

                //        }
                //        //Check word exist

                //        //Check word respectes the theme



                //            playerOne.AnswerList.Add(playerWord);


                //    }

                //   Console.WriteLine("Your score for this phase is :" + referee.CalculateScore(playerOne)); 
                //   playerOne.Score += referee.CalculateScore(playerOne);
                //   Console.WriteLine("Fin de la phase" + i);

                //}

                //Console.WriteLine("Fin du jeu");
                //Console.WriteLine("Vous totalisez un score de " + playerOne.Score);            

            }
        }
    }
