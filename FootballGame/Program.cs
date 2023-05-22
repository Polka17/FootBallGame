using FootballGame;

Team team1 = new Team();
Team team2 = new Team();
team1.Players = GeneratePlayers( 11);

static FootballPlayer[] GeneratePlayers( int count)
{
    FootballPlayer[] players = new FootballPlayer[count];
    for (int i = 0; i < players.Length; i++)
    {
        Console.WriteLine("Enter the type of player (striker/midfield/goalkeeper/defender):");
        string type = Console.ReadLine();
        if (type == "striker")
        {
            Striker striker = new Striker();
            players[i] = striker;

        }
        if (type == "midfield")
        {
            Midfield midfield = new Midfield();
            players[i] = midfield;
        }
        if (type == "goalkeeper")
        {
            GoalKeeper goalkeeper = new GoalKeeper();
            players[i] = goalkeeper;
        }
        if (type == "defender")
        {
            Defender defender = new Defender();
            players[i] = defender;
        }
        players[i].EnterPersonInfo();
        players[i].EnterPlayerInfo();
    }
    return players;
}

//static void GenerateReferee(int count)
//{
//    Referee[] referees = new Referee[count];
//    for (int i = 0; i < referees.Length; i++)
//    {
//        referees[i].EnterPersonInfo();
//    }
//}
//static void GenerateCoach(int count)
//{
//    Coach[] coaches = new Coach[count];
//    for (int i = 0; i < coaches.Length; i++)
//    {
//        coaches[i].EnterPersonInfo();
//    }
//}
