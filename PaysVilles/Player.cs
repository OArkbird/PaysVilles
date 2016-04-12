using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilles
{
    public class Player
    {
        public string UserName { get; set; }

        private List<string> answerList = new List<string>();

        public List<string> AnswerList { get { return answerList; }}
    }
}
