using System.ComponentModel.DataAnnotations;
namespace TestTaskApp.Models
{
    public class UserContact
    {
        public int Id { get; set; }
        public int EmailId { get; set; }

        [Required(ErrorMessage = "Phone number is Required")]
         [DataType(DataType.PhoneNumber)]

        [StringLength(10)]
        public string Mobile { get; set; }
    }
}
