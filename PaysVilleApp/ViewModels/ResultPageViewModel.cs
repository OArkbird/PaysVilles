using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilleApp.ViewModels
{
    public class ResultPageViewModel
    {
        //Properties

        private string results;
        public string Results 
        {
            get { return results; }
            set 
            {
                results = value;
            }
        }

        private string resultsTitle = "Game Results";
        public string ResultsTitle
        {
            get { return resultsTitle; }
            set
            {
                resultsTitle = value;
            }
        }

        private string endOfGameButton = "End Game";
        public string EndOfGameButton
        {
            get { return endOfGameButton; }
            set
            {
                endOfGameButton = value;
            }
        }

        //Commands

        public Command GoToIntroPageCommand { get; set; }

        //Constructors

        public ResultPageViewModel() 
        {
            GoToIntroPageCommand = new Command(ExecuteGoToIntroPageCommand,CanExecuteGoToIntroPageCommand);
        }

        //Methods

        public bool CanExecuteGoToIntroPageCommand() 
        {
            return true;
        }

        public void ExecuteGoToIntroPageCommand() 
        {
            MainWindowViewModel mainWindow = (MainWindowViewModel) App.Current.MainWindow.DataContext;
            mainWindow.DisplayedPage = "IntroPage.xaml";
        }

    }
}
