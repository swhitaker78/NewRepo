using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassRoomHelper.Models
{
    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserType { get; set; }

        public enum UserTypes
        {
            Admin = 1, Teacher = 2, Student = 3
        }
    }
}
