using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ProjectDotNet.Models
{
        public class User
        {
            public int Id { get; set; }
            [Required]
            [Column(TypeName = "varchar(50)")]
            [MaxLength(100)]
            public string Name { get; set; }
            [MaxLength(256)]
            public string FirstName { get; set; }
            [MaxLength(50)]
            public string LastName { get; set; }
            public virtual ICollection<ForumThread>? ForumThreads { get; set; }
            public virtual ICollection<Post>? Posts { get; set; }

    }
}
