using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaysVilles
{
    public interface IGameReferee
    {
        int CalculateScore(Player myPlayer);
    }
}
