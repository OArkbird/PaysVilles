using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilleApp.ViewModels
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        private string displayedPage = "IntroPage.xaml";

        public string DisplayedPage 
        {
            get { return displayedPage; }
            set 
            { 
                displayedPage = value;
                onPropertyChanged("DisplayedPage");
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
