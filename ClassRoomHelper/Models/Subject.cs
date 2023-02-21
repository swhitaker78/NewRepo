using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ClassRoomHelper.Models
{
    public class Subject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SubjectID { get; set; }
        [Required]
        public string SubjectName { get; set; }        
        public string? SubjectDescription { get; set; }
        [Required]
        public string SubjectTerm { get; set; }
        
    }
}
