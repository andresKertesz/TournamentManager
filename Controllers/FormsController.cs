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

        public static Color ContrastColor(Color iColor)
        {
            // Calculate the perceptive luminance (aka luma) - human eye favors green color... 
            double luma = ((0.299 * iColor.R) + (0.587 * iColor.G) + (0.114 * iColor.B)) / 255;

            // Return black for bright colors, white for dark colors
            return luma > 0.5 ? Color.Black : Color.White;
        }
    }
}
