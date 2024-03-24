using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager.Model
{
    public class League
    {
        public enum WinCriteria { Points,GoalDifference,GoalsScored, GoalsConceded}

        [Key]
        public Guid Id { get; set; }
        public ICollection<Team> Teams { get; set; }
        
        public List<LeagueFixture> LeagueFixtures { get; set; }

        public bool CanDraw { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Rounds { get; set; }
        public int PointsPerWin { get; set; }
        public int PointsPerLoss { get; set; }
        public int PointsPerTie { get; set; }
        public Guid WinnerID { get; set; }

        [ForeignKey("WinnerID")]
        public virtual Team Winner {get;set;} 

        
    }
}
