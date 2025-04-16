using System.ComponentModel.DataAnnotations;

namespace ProjectDotNet.Models
{
    public class ForumThread
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
    }
}
