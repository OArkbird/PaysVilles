using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PaysVilleApp.ViewModels
{
    public class PhaseIntroPageViewModel
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

        //Game info box properties

        string gameInfoDisplay = "";
        public string GameInfoDisplay
        {
            get { return gameInfoDisplay; }
            set
            {
                gameInfoDisplay = value;
            }
        }

        string gameInfoDisplayTitle = "Game Information";
        public string GameInfoDisplayTitle
        {
            get { return gameInfoDisplayTitle; }
            set
            {
                gameInfoDisplayTitle = value;
            }
        }

        //Game info box Form properties

        string gameInfoDisplayLabelOne = "Game:";
        public string GameInfoDisplayLabelOne
        {
            get { return gameInfoDisplayLabelOne; }
            set
            {
                gameInfoDisplayLabelOne = value;
            }
        }

        string gameInfoDisplayLabelOneContent = "";
        public string GameInfoDisplayLabelOneContent
        {
            get { return gameInfoDisplayLabelOneContent; }
            set
            {
                gameInfoDisplayLabelOneContent = value;
            }
        }


        string gameInfoDisplayLabelTwo = "Players:";
        public string GameInfoDisplayLabelTwo
        {
            get { return gameInfoDisplayLabelTwo; }
            set
            {
                gameInfoDisplayLabelTwo = value;
            }
        }

        string gameInfoDisplayLabelTwoContent = "";
        public string GameInfoDisplayLabelTwoContent
        {
            get { return gameInfoDisplayLabelTwoContent; }
            set
            {
                gameInfoDisplayLabelTwoContent = value;
            }
        }

        string gameInfoDisplayLabelThree = "Phase:";
        public string GameInfoDisplayLabelThree
        {
            get { return gameInfoDisplayLabelThree; }
            set
            {
                gameInfoDisplayLabelThree = value;
            }
        }

        string gameInfoDisplayLabelThreeContent = "";
        public string GameInfoDisplayLabelThreeContent
        {
            get { return gameInfoDisplayLabelThreeContent; }
            set
            {
                gameInfoDisplayLabelThreeContent = value;
            }
        }

        string gameInfoDisplayLabelFour = "Chronometre:";
        public string GameInfoDisplayLabelFour
        {
            get { return gameInfoDisplayLabelFour; }
            set
            {
                gameInfoDisplayLabelFour = value;
            }
        }

        string gameInfoDisplayLabelFourContent = "";
        public string GameInfoDisplayLabelFourContent
        {
            get { return gameInfoDisplayLabelFourContent; }
            set
            {
                gameInfoDisplayLabelFourContent = value;
            }
        }

        string gameInfoDisplayLabelFive = "Game letter:";
        public string GameInfoDisplayLabelFive
        {
            get { return gameInfoDisplayLabelFive; }
            set
            {
                gameInfoDisplayLabelFive = value;
            }
        }

        string gameInfoDisplayLabelFiveContent = "";
        public string GameInfoDisplayLabelFiveContent
        {
            get { return gameInfoDisplayLabelFiveContent; }
            set
            {
                gameInfoDisplayLabelFiveContent = value;
            }
        }

        //Commands

        public ICommand GoToThemePageIntroCommand { get; set; }
        
        //Constructors

        public PhaseIntroPageViewModel() 
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
