using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager.Model
{
    public class Team
    {
        [Key]
        public Guid TeamID { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string ColorString { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public List<League> LeaguesWon { get; set; }
        public List<League> Leagues { get; set; }
    }
}
