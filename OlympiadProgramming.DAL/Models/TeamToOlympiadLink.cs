using System.ComponentModel.DataAnnotations;

namespace OlympiadProgramming.DAL.Models
{
    public class TeamToOlympiadLink
    {
        [Key]
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int OlympiadId { get; set; }

        public virtual Team Team { get; set; }
        public virtual Olympiad Olympiad { get; set; }

        public TeamToOlympiadLink(int teamId, int olympiadId)
        {
            this.TeamId = teamId;
            this.OlympiadId = olympiadId;
        }
    }
}
