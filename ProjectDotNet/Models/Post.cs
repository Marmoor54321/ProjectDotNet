using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ProjectDotNet.Models
{
    public class Post
    {
        public int Id {  get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ForumThreadId {get; set; }
        public virtual ForumThread ForumThread { get; set; }
        [Required]
        [MaxLength(512)]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
