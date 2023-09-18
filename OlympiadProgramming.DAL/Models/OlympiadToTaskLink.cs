
using System.ComponentModel.DataAnnotations;

namespace OlympiadProgramming.DAL.Models
{
    public class OlympiadToTaskLink
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int OlympiadId { get; set; }
        public int TaskNumber { get; set; }

        public virtual Olympiad Olympiad { get; set; }
        public virtual Task Task { get; set; }
    }
}
