using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestTaskApp.Models.Enum;

namespace TestTaskApp.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name must be between 8 and 60 characters.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public GenderEnum Gender { get; set; }
        [Required]
        public string Email { get; set; }

        public int UserContactId { get; set; }

        [ForeignKey("UserContactId")]
        public virtual UserContact UserContact { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public Boolean IsActive { get; set; }
        public Boolean IsDeleted { get; set; }
    }

}
