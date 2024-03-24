using TournamentManager.Controllers;
using TournamentManager.Forms.Teams;
using TournamentManager.Model;

namespace TournamentManager
{
    public partial class MainForm : Form
    {
        public static DatabaseDbContext DbContext { get; set; }
        public MainForm(Model.DatabaseDbContext databaseDbContext)
        {
            InitializeComponent();
            DbContext = databaseDbContext;
            InitializeTeamForm();
        }

        private void InitializeTeamForm()
        {

            pnlTeams.Controls.Add(FormsController.ActiveTeamTabController);
            FormsController.ActiveTeamTabController.Show();
        }
    }
}