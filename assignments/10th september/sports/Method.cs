using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10th_september.sports
{
    class Method : TeamScore
    {
              
        public void PrintScores()
        {
            Console.WriteLine("total score for team {0} is {1}", Name, Score);
        }
     
        public void HighScore()
        {
            HighestScore = PlayerScores[0].Score;
         
            for (int PlayerCount = 0; PlayerCount < 3; PlayerCount++)
            {
                PlayerScores[PlayerCount].PlayerDetail = Player[PlayerCount];
                if (HighestScore < PlayerScores[PlayerCount].Score)
                {
                    HighestScore = PlayerScores[PlayerCount].Score;
                    PlayerScores[0].PlayerDetail = Player[PlayerCount];
                }

            }

            Console.WriteLine("highest score is for {0} :{1}", PlayerScores[0].PlayerDetail.Name, HighestScore);
        }



        public void ManOfTheMatch(Method M1,Method M2)
        {
            if (M1.HighestScore > M2.HighestScore)
            {
                Console.WriteLine("team {0} won", M1.Name);
                Console.WriteLine("man of the match is {0} with score {1}",M1.PlayerScores[0].PlayerDetail.Name,M1.HighestScore);
            }

            else
            {
                Console.WriteLine("team {0} won", M2.Name);
                Console.WriteLine("man of the match is {0} with score {1}", M2.PlayerScores[0].PlayerDetail.Name,M2.HighestScore);
            }
        }
    }
}