using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentManager.Controllers;

namespace TournamentManager.Forms.Teams
{
    public partial class TeamCrudForm : Form
    {
        public TeamCrudForm()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        private void TeamCrudForm_VisibleChanged(object sender, EventArgs e)
        {
            dgvUsers.DataSource = TeamController.GetTeams();
        }
    }
}
