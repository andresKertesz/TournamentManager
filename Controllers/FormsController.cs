using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentManager.Forms.Teams;

namespace TournamentManager.Controllers
{
    public static class FormsController
    {
        public static Form ActiveTeamTabController { get; private set; } = GenerateInitialScreen();

        private static Form GenerateInitialScreen()
        {

            TeamCrudForm team = new();
            team.Dock = DockStyle.Fill;
            return team;

        }
    }
}
