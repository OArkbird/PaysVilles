using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilles
{
    public class GameReferee
    {
        public int CalculateScore(Player myPlayer)
        {
            // Calculate the score of a player based on the answerList;
            int score = 0;

            if (myPlayer.AnswerList.Count > 0) 
            { 
                for (int i = 0; i<myPlayer.AnswerList.Count;i++)
                {
                    score += myPlayer.AnswerList[i].Length;
                }

                return score;
            }
            else 
            {
                return 0;
            }
            
        }
    }
}
