﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilleApp.ViewModels
{
    public class GamePageViewModel: INotifyPropertyChanged
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

        private string gameInfoTitle = "Game information";
        public string GameInfoTitle
        {
            get { return gameInfoTitle; }
            set
            {
                gameInfoTitle = value;
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

        string timeLeftTitle = "Time left";
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

        string currentThemeTitle = "Current theme";
        public string CurrentThemeTitle
        {
            get { return currentThemeTitle; }
            set
            {
                currentThemeTitle = value;
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

        string inputInfoTitle = "Warning";
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

        string themeImageTitle = "Theme";
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

        string userInputTitle = "Type your word";
        public string UserInputTitle
        {
            get { return userInputTitle; }
            set
            {
                userInputTitle = value;
            }
        }

        //Command

        public Command GoToResultsPageCommand{get;set;}

        //Constructors
        public GamePageViewModel() 
        {
            GoToResultsPageCommand = new Command(ExecuteGoToResultsPageCommand, CanExecuteGoToResultsPageCommand);
        }

        //Methods

        public bool CanExecuteGoToResultsPageCommand()
        {
            return true;
        }

        public void ExecuteGoToResultsPageCommand()
        {
            MainWindowViewModel mainWindow = (MainWindowViewModel)App.Current.MainWindow.DataContext;
            mainWindow.DisplayedPage = "ResultsPage.xaml";
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
