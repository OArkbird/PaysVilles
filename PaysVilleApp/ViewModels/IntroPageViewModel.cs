using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics;
using System.Linq;


namespace PaysVilleApp.ViewModels
{
    public class IntroPageViewModel
    {
        //Constructors

        public IntroPageViewModel() 
        {
            GoToGameIntroPageCommand = new Command(ExecuteGoToGameIntroPageCommand,CanExecuteGoToGameIntroPageCommad);
        }

        //Properties

        private string gameTitle = "Pays - Villes";

        public string GameTitle 
        {
            get { return gameTitle; }
            set { gameTitle = value; }
        }

        private string startButton = "Start";

        public string StartButton
        {
            get { return startButton; }
            set { startButton = value; }
        }

        private string exitButton = "Exit";

        public string ExitButton
        {
            get { return exitButton; }
            set { exitButton = value; }
        }

        //Commands

        public ICommand GoToGameIntroPageCommand { get; set; }

        //Methods

        public bool CanExecuteGoToGameIntroPageCommad() 
        {
            return true;
        }

        public void ExecuteGoToGameIntroPageCommand()
        {
            var mainWindow =  App.Current.MainWindow.DataContext as MainWindowViewModel;
            mainWindow.DisplayedPage = "GamePageIntro.xaml";
        }

    }
}
