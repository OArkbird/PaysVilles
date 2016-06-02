using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilleApp.ViewModels
{
    public class GamePageViewModel: INotifyPropertyChanged
    {
        int timeLeft = 0;
        public int TimeLeft
        {
            get { return timeLeft; }
            set
            {
                timeLeft = value;
                onPropertyChanged("TimeLeft");

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
