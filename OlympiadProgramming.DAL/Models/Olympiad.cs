using System.ComponentModel.DataAnnotations;

namespace OlympiadProgramming.DAL.Models
{
    public class Olympiad
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
