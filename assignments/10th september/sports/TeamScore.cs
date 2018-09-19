using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10th_september.sports
{
    public class TeamScore : Team
    {
        public PlayerScore[] PlayerScores = new PlayerScore[CricketSettings.TeamArraySize];
        public bool IsWinning;
        public int Score = 0;
        public int HighestScore = 0;


        public void SetNames()
        {

            Console.WriteLine("enter team names");
            Name = Console.ReadLine();

            for (int PlayerCount = 0; PlayerCount < 3; PlayerCount++)
            {
                Player[PlayerCount] = new Player();
                Console.WriteLine("enter the name of the player");
                Player[PlayerCount].Name = Console.ReadLine();
            }
        }


        public void SetScores()
        {
            for (int PlayerCount = 0; PlayerCount < 3; PlayerCount++)
            {
                PlayerScores[PlayerCount] = new PlayerScore();
                Console.WriteLine("enter score of player");
                PlayerScores[PlayerCount].Score = int.Parse(Console.ReadLine());
                Console.WriteLine("enter no of balls");
                PlayerScores[PlayerCount].Balls = int.Parse(Console.ReadLine());

                Score = Score + PlayerScores[PlayerCount].Score;
            }
        }

        public void StrikeRate()
        {
            for (int PlayerCount = 0; PlayerCount < 3; PlayerCount++)
            {

                Player[PlayerCount].StrikeRate = (PlayerScores[PlayerCount].Score / PlayerScores[PlayerCount].Balls) * 100;

                Console.WriteLine("strike rate for {0} is {1}", Player[PlayerCount].Name, Player[PlayerCount].StrikeRate);
            }
        }
    }
}

