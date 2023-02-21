using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ClassRoomHelper.Models
{
    public class AssignmentDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AssignDetailID { get; set; }
        [Required]
        public int AssignmentID { get; set; }
        [Required]
        public string AssignmentType { get; set; }        
        public string? AssignmentInstructions { get; set; }
        public List<Question> Questions { get; set; }

    }
}
