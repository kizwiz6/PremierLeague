using PremierLeague;
using PremierLeague.Teams;

internal class Program
{
    static void Main(string[] args)
    {
        // Create some Premiership teams
        var arsenal = new Arsenal();
        var liverpool = new Liverpool();
        var manchesterCity = new ManchesterCity();
        var manchesterUnited = new ManchesterUnited();
        var newcastleUnited = new NewcastleUnited();
        var tottenhamHotspur = new TottenhamHotspur();

        // Points
        arsenal.Points = 37;
        manchesterCity.Points = 32;
        manchesterUnited.Points = 26;
        newcastleUnited.Points = 30;
        liverpool.Points = 22;
        tottenhamHotspur.Points = 29;

        Console.WriteLine("Team Information:");

        // Create a list of ITeamInformation objects
        var teams = new List<ITeamInformation> { manchesterUnited, liverpool, arsenal, manchesterCity, newcastleUnited };

        // Create a TeamDisplay object to show team information
        var teamDisplay = new TeamDisplay(teams);
        teamDisplay.ShowInformation();

        Console.WriteLine("\nStandings:");

        // Create a list of IStandings objects
        var standings = new List<IStandings> { arsenal, liverpool, manchesterCity, manchesterUnited, newcastleUnited, tottenhamHotspur };

        // Create a StandingsDisplay object to show team standings
        var standingsDisplay = new StandingsDisplay(standings);
        standingsDisplay.ShowStandings();
    }
}