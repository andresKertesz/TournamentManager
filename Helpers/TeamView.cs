using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentManager.Model;

namespace TournamentManager.Helpers
{
    public class TeamView
    {
        [Browsable(false)]
        public Team Team { get; private set; }
        [Browsable(false)]
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public int TournamentsPlayed { get; set; }
        public int TounramentsWon { get; set; }
        public Image TeamImage { get; set; }
        public Color TeamColor { get; set; }

        public TeamView(Team team)
        {

        }
    }
}
