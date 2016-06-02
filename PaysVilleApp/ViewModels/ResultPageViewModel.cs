using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilleApp.ViewModels
{
    public class ResultPageViewModel
    {
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
    }
}
