using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footbal_team
{
    public class Game
    {
    
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }
    public Referee Referee { get; set; }
    public List<AssistantReferee> AssistantReferees { get; set; }
    public List<Goal> Goals { get; set; }
    public string GameResult { get; set; }
    public Team Winner
    {
        get
        {
            if (GameResult == "Team1")
                return Team1;
            else if (GameResult == "Team2")
                return Team2;
            else
                return null; 
        }
    }

    public Game(Team team1, Team team2, Referee referee, List<AssistantReferee> assistantReferees)
    {
        Team1 = team1;
        Team2 = team2;
        Referee = referee;
        AssistantReferees = assistantReferees;
        Goals = new List<Goal>();
        GameResult = "";
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }
}
    }

