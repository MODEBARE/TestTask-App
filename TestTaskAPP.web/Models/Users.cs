using System.ComponentModel.DataAnnotations;

namespace TestTaskAPP.web.Models
{
    public class Users
    {

        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public GenderEnum Gender { get; set; }

    }
}
