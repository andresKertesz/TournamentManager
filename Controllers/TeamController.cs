using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentManager.Model;

namespace TournamentManager.Controllers
{
    public static class TeamController
    {

        public static List<Team> GetTeams()
        {

            return MainForm.DbContext.Teams.ToList();

        }

        

        

    }
}
