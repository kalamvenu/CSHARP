using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10th_september.sports
{

    class Sports
    {
        static void Main(string[] args)
        {
                   
            Method[] MatchDetails = new Method[CricketSettings.TeamSize];

            for (int NoOfTeams = 0; NoOfTeams < CricketSettings.TeamSize; NoOfTeams++)
            {
                MatchDetails[NoOfTeams] = new Method();
                MatchDetails[NoOfTeams].SetNames();
                MatchDetails[NoOfTeams].SetScores();
                MatchDetails[NoOfTeams].PrintScores();
                MatchDetails[NoOfTeams].HighScore();
                MatchDetails[NoOfTeams].StrikeRate();

            }

            MatchDetails[0].ManOfTheMatch(MatchDetails[0],MatchDetails[1]);

            Console.ReadKey();
        }


    }
}
