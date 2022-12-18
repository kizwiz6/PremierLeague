using PremierLeague;
using PremierLeague.Teams;

internal class Program
{
    static void Main(string[] args)
    {
        // Create some Premiership teams
        var arsenal = new Arsenal();
        var astonVilla = new AstonVilla();
        var brentford = new Brentford();
        var brighton = new Brighton();
        var chelsea = new Chelsea();
        var crystalPalace = new CrystalPalace();
        var everton = new Everton();
        var fulham = new Fulham();
        var leedsUnited = new LeedsUnited();
        var leicesterCity = new LeicesterCity();
        var liverpool = new Liverpool();
        var manchesterCity = new ManchesterCity();
        var manchesterUnited = new ManchesterUnited();
        var newcastleUnited = new NewcastleUnited();
        var nottinghamForest = new NottinghamForest();
        var southampton = new Southampton();
        var tottenhamHotspur = new TottenhamHotspur();
        var westHam = new WestHam();
        var wolves = new Wolves();

        // Points
        arsenal.Points = 37;
        astonVilla.Points = 18;
        brentford.Points = 19;
        brighton.Points = 21;
        chelsea.Points = 21;
        crystalPalace.Points = 19;
        everton.Points = 14;
        fulham.Points = 19;
        leedsUnited.Points = 15;
        leicesterCity.Points = 17;
        manchesterCity.Points = 32;
        manchesterUnited.Points = 26;
        newcastleUnited.Points = 30;
        nottinghamForest.Points = 13;
        liverpool.Points = 22;
        southampton.Points = 12;
        tottenhamHotspur.Points = 29;
        westHam.Points = 14;
        wolves.Points = 10;

        Console.WriteLine("Team Information:");

        // Create a list of ITeamInformation objects
        var teams = new List<ITeamInformation> { arsenal, astonVilla, brentford, brighton, chelsea, crystalPalace, everton, fulham, leedsUnited, leicesterCity, manchesterCity, manchesterUnited, manchesterUnited, newcastleUnited, nottinghamForest, liverpool, southampton, tottenhamHotspur, westHam, wolves };

        // Create a TeamDisplay object to show team information
        var teamDisplay = new TeamDisplay(teams);
        teamDisplay.ShowInformation();

        Console.WriteLine("\nStandings:");

        // Create a list of IStandings objects
        var standings = new List<IStandings> { arsenal, astonVilla, brentford, brighton, chelsea, crystalPalace, everton, fulham, leedsUnited, leicesterCity, manchesterCity, manchesterUnited, manchesterUnited, newcastleUnited, nottinghamForest, liverpool, southampton, tottenhamHotspur, westHam, wolves };

        // Sort the list of teams by points
        /*tandings.Sort((a, b) => a.Points.CompareTo(b.Points));*/

        // Create a StandingsDisplay object to show team standings
        var standingsDisplay = new StandingsDisplay(standings);
        standingsDisplay.ShowStandings();
    }
}