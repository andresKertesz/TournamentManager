using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentManager.Model
{
    public class Match
    {



    }

    public class LeagueFixture
    {
        [Key]
        public Guid FixtureID { get; set; }
        
        public Guid HomeTeamID { get;set; }

        public Guid AwayTeamID { get;set; }

        public Guid LeagueFixtureID { get; set; }
        public int Matchday { get; set; }

        [ForeignKey("HomeTeamID")]
        public virtual Team HomeTeam { get; set; }
        
        [ForeignKey("AwayTeamID")]
        public virtual Team AwayTeam { get; set; }

        [ForeignKey("LeagueFixtureID")]
        public virtual League League { get; set; }
    }
}
