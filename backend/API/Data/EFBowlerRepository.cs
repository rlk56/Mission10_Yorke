using System.Linq;

namespace API.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private readonly BowlerContext _bowlerContext;

        public EFBowlerRepository(BowlerContext context)
        {
            _bowlerContext = context;
        }

        public IEnumerable<Bowler> Bowlers =>
            _bowlerContext.Bowlers
                          .Where(bowler => bowler.TeamID == 1 || bowler.TeamID == 2)
                          .Join(_bowlerContext.Teams, // Joining with the Teams table
                                bowler => bowler.TeamID, // Joining on the TeamID property of Bowler
                                team => team.TeamID,     // Joining on the TeamID property of Team
                                (bowler, team) =>       // Result selector
                                    new Bowler
                                    {
                                        BowlerID = bowler.BowlerID,
                                        BowlerFirstName = bowler.BowlerFirstName,
                                        BowlerMiddleInit = bowler.BowlerMiddleInit,
                                        BowlerLastName = bowler.BowlerLastName,
                                        TeamID = bowler.TeamID,
                                        TeamName = team.TeamName, // Include TeamName from the Team table
                                        BowlerAddress = bowler.BowlerAddress,
                                        BowlerCity = bowler.BowlerCity,
                                        BowlerState = bowler.BowlerState,
                                        BowlerZip = bowler.BowlerZip,
                                        BowlerPhoneNumber = bowler.BowlerPhoneNumber
                                    });
    }
}
