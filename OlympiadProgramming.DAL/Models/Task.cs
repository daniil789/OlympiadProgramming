
using System.ComponentModel.DataAnnotations;

namespace OlympiadProgramming.DAL.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Result { get; set; }
    }
}
