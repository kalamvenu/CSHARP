using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10th_september.sports
{
    public static class CricketSettings
    {
        public static int TeamArraySize = 11;
        public static int TeamSize = 2;

    }










    //for(int TeamCount = 0; TeamCount < CricketSettings.TeamSize; TeamCount++)
    //{
    //    TeamScores[TeamCount] = new TeamScore();
    //Console.WriteLine("enter the team names");
    //    TeamScores[TeamCount].Name = Console.ReadLine();
    //    for(int PlayerCount = 0; PlayerCount < 3; PlayerCount++)
    //    {
    //        TeamScores[TeamCount].Player[PlayerCount] = new Player();
    //        Console.WriteLine("enter player names");
    //        TeamScores[TeamCount].Player[PlayerCount].Name = Console.ReadLine();
    //    }
    //}


    // for (int TeamCount = 0; TeamCount < CricketSettings.TeamSize; TeamCount++)
    // {
    //     TeamScores[TeamCount] = new TeamScore();
    //     Console.WriteLine("enter scores for team {0}", TeamScores[TeamCount].Name);
    //     for (int ScoreCount = 0; ScoreCount < 3; ScoreCount++)
    //     {

    //         TeamScores[TeamCount].PlayerScores[ScoreCount] = new PlayerScore();
    //         Console.WriteLine("enter scores for player {0}", TeamScores[TeamCount].Player[ScoreCount].Name);
    //         TeamScores[TeamCount].PlayerScores[ScoreCount].Score = int.Parse(Console.ReadLine());
    //         Console.WriteLine("enter the number of balls he took");
    //         TeamScores[TeamCount].PlayerScores[ScoreCount].Balls = int.Parse(Console.ReadLine());

    //         TeamScores[TeamCount].Score = TeamScores[TeamCount].Score + TeamScores[TeamCount].PlayerScores[ScoreCount].Score;
    //     }

    //}

    //TeamScore[] TeamScores = new TeamScore[CricketSettings.TeamSize];

    //for (int TeamCount = 0; TeamCount < CricketSettings.TeamSize; TeamCount++)
    //{
    //    TeamScores[TeamCount] = new TeamScore();
    //    Console.WriteLine("enter the team names");
    //    TeamScores[TeamCount].Name = Console.ReadLine();
    //    for (int PlayerCount = 0; PlayerCount < 3; PlayerCount++)
    //    {
    //        TeamScores[TeamCount].Player[PlayerCount] = new Player();
    //        Console.WriteLine("enter player names");
    //        TeamScores[TeamCount].Player[PlayerCount].Name = Console.ReadLine();
    //    }
    //}

    //total score of team


    /*    for (int TeamScoreCount = 0; TeamScoreCount < CricketSettings.TeamSize; TeamScoreCount++)
        {
            Console.WriteLine("total score of team {0} is {1}", TeamScores[TeamScoreCount].Name, TeamScores[TeamScoreCount].Score);

        }



        for (int TeamScoreCount = 0; TeamScoreCount < CricketSettings.TeamSize; TeamScoreCount++)
        {

            TeamScores[TeamScoreCount].PlayerScores[0].PlayerDetail.HighestScore = TeamScores[TeamScoreCount].PlayerScores[0].Score;
            for (int PlayerCount = 0; PlayerCount < 3; PlayerCount++)
            {
                if(TeamScores[TeamScoreCount].PlayerScores[0].PlayerDetail.HighestScore < TeamScores[TeamScoreCount].PlayerScores[PlayerCount].Score)
                {
                    TeamScores[TeamScoreCount].PlayerScores[0].PlayerDetail.HighestScore = TeamScores[TeamScoreCount].PlayerScores[PlayerCount].Score;

                    TeamScores[TeamScoreCount].PlayerScores[0].PlayerDetail.Name = TeamScores[TeamScoreCount].Player[PlayerCount].Name;
                }

            }
        }

        for(int TeamScoreCount = 0; TeamScoreCount < CricketSettings.TeamSize; TeamScoreCount++)
        {
            Console.WriteLine("highest score from team {0} is {1} for {2} ", TeamScores[TeamScoreCount].Name, TeamScores[TeamScoreCount].PlayerScores[0].PlayerDetail.HighestScore, TeamScores[TeamScoreCount].PlayerScores[0].PlayerDetail.Name);
        }

        if(TeamScores[0].PlayerScores[0].PlayerDetail.HighestScore > TeamScores[1].PlayerScores[0].PlayerDetail.HighestScore)
            Console.WriteLine("high score from both teams is {0} for {1}", TeamScores[0].PlayerScores[0].PlayerDetail.HighestScore, TeamScores[0].PlayerScores[0].PlayerDetail.Name);
        else Console.WriteLine("high score from both teams is {0} for {1}", TeamScores[1].PlayerScores[0].PlayerDetail.HighestScore, TeamScores[1].PlayerScores[0].PlayerDetail.Name);


*/
}
