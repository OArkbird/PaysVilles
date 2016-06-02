using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilleApp.ViewModels
{
    public class GamePageIntroViewModel: INotifyPropertyChanged
    {
        private string gameInfo = "";

        public string GameInfo
        {
            get {return gameInfo;}
            set 
            { 
                gameInfo = value;
                onPropertyChanged("GameInfo");
            }

        }

        int timeLeft = 0;
        public int TimeLeft
        {
            get { return timeLeft; }
            set
            {
                timeLeft = value;
            }
        }

        string currentTheme = "";
        public string CurrentTheme
        {
            get { return currentTheme; }
            set
            {
                currentTheme = value;
            }
        }

        string theme = "";
        public string Theme
        {
            get { return theme; }
            set
            {
                theme = value;
            }
        }

        string inputInfo = "";
        public string InputInfo
        {
            get { return inputInfo; }
            set
            {
                inputInfo = value;
            }
        }

        string themeImage = "";
        public string ThemeImage
        {
            get { return themeImage; }
            set
            {
                themeImage = value;
            }
        }

        string userInput = "";
        public string UserInput
        {
            get { return userInput; }
            set
            {
                userInput = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
