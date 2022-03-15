using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Journaling.Models
{
    public class User
    {

        [Key]
        [Display(Name = "User Number")]
        public int UserNumber { get; set; }

        [Display(Name = "FullName")]
        [StringLength(30)]
        public string FullName { get; set; }

        [ForeignKey("UserNumber")]
        public ICollection<Journal> Journals { get; set; }

        [ForeignKey("UserNumber")]
        public ICollection<Comment> Comments { get; set; }

        public User()
        {
            Journals = new HashSet<Journal>();
            Comments = new HashSet<Comment>();

        }

    }
}
