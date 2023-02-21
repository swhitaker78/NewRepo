using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations.Schema;
namespace ClassRoomHelper.Models
{
    public class Question
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int QuestionID { get; set; }
        [Required]
        public string AssignmentID { get; set; }
        [Required]
        public string QuestionInfo { get; set; }
        [Required]
        public List<Answers> AnswerChoices { get; set; }
        [Required]
        public int CorrectAnswerID { get; set; }
        
    }
}
