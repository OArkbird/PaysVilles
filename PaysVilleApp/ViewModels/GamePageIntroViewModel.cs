using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        int timeLeft = 0;
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

        string gameInfoDisplay = "";
        public string GameInfoDisplay
        {
            get { return gameInfoDisplay; }
            set
            {
                gameInfoDisplay = value;
            }
        }

        string gameInfoDisplayTitle = "";
        public string GameInfoDisplayTitle
        {
            get { return gameInfoDisplayTitle; }
            set
            {
                gameInfoDisplayTitle = value;
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

        //Commands

        public ICommand GoToThemePageIntroCommand { get; set; }
        
        //Constructors

        public GamePageIntroViewModel() 
        {
            GoToThemePageIntroCommand = new Command(ExecuteGoToThemePageIntroCommand,CanExecuteGoToThemePageIntroCommand);
        }

        //Methods

        public bool CanExecuteGoToThemePageIntroCommand() 
        {
            return true;
        }

        public void ExecuteGoToThemePageIntroCommand() 
        {
            MainWindowViewModel mainWindow = (MainWindowViewModel) App.Current.MainWindow.DataContext;
            mainWindow.DisplayedPage = "ThemePageIntro.xaml";
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
