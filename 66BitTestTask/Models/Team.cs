using System.ComponentModel.DataAnnotations;

namespace _66BitTestTask.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
