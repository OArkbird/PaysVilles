﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilleApp.ViewModels
{
    public class IntroPageViewModel
    {
        private string gameTitle = "Pays - Villes";

        public string GameTitle 
        {
            get { return gameTitle; }
            set { gameTitle = value; }
        }

        private string startButton = "Pays - Villes";

        public string StartButton
        {
            get { return startButton; }
            set { startButton = value; }
        }

        private string exitButton = "Pays - Villes";

        public string ExitButton
        {
            get { return exitButton; }
            set { exitButton = value; }
        }

    }
}
