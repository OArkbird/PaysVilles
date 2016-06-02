using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace PaysVilleApp.ViewModels
{
    public class ThemePageIntroViewModel: INotifyPropertyChanged
    {
        private string gameInfo = "";
        public string GameInfo
        {
            get { return gameInfo; }
            set
            {
                gameInfo = value;
                onPropertyChanged("GameInfo");
            }

        }

        private string gameInfoTitle = "";
        public string GameInfoTitle
        {
            get { return gameInfoTitle; }
            set
            {
                gameInfoTitle = value;
                onPropertyChanged("GameInfo");
            }

        }

        int timeLeft;
        public int TimeLeft
        {
            get { return timeLeft; }
            set
            {
                timeLeft = value;
            }
        }

        string timeLeftTitle = "";
        public string TimeLeftTitle
        {
            get { return timeLeftTitle; }
            set
            {
                timeLeftTitle = value;
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

        string currentThemeTitle = "";
        public string CurrentThemeTitle
        {
            get { return currentThemeTitle; }
            set
            {
                currentThemeTitle = value;
            }
        }

        string themeInfoDisplay = "";
        public string ThemeInfoDisplay
        {
            get { return themeInfoDisplay; }
            set
            {
                themeInfoDisplay = value;
            }
        }

        string themeInfoDisplayTitle = "";
        public string ThemeInfoDisplayTitle
        {
            get { return themeInfoDisplayTitle; }
            set
            {
                themeInfoDisplayTitle = value;
            }
        }

        string themeTitle = "";
        public string ThemeTitle
        {
            get { return themeTitle; }
            set
            {
                themeTitle = value;
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

        string inputInfoTitle = "";
        public string InputInfoTitle
        {
            get { return inputInfoTitle; }
            set
            {
                inputInfoTitle = value;
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

        string themeImageTitle = "";
        public string ThemeImageTitle
        {
            get { return themeImageTitle; }
            set
            {
                themeImageTitle = value;
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

        string userInputTitle = "";
        public string UserInputTitle
        {
            get { return userInputTitle; }
            set
            {
                userInputTitle = value;
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
