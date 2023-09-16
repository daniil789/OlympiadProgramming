using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadProgramming.DAL.Models
{
    public class TeamsToUsersLink
    {
        public int UserId { get; set; }
        public int TeamId { get; set; }

        public virtual User User { get; set; }
        public virtual Team Team { get; set; }
    }
}
