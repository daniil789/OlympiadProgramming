using System.ComponentModel.DataAnnotations;

namespace OlympiadProgramming.DAL.Models
{
    public class TeamsToUsersLink
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TeamId { get; set; }

        public virtual User User { get; set; }
        public virtual Team Team { get; set; }

        public TeamsToUsersLink(int userId, int teamId)
        {
            this.UserId = userId;
            this.TeamId = teamId;
        }
    }
}
