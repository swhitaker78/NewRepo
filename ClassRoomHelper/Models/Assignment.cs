using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassRoomHelper.Models
{
    public class Assignment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AssignmentID { get; set; }
        [Required]
        public int SubjectID { get; set; }
        [Required]
        public string AssignmentName { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public DateTime? CompletionDate { get; set; }
    }
}
