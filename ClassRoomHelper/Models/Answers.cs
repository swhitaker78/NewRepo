using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassRoomHelper.Models
{
    public class Answers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AnswerID { get; set; }       
        [Required]
        public int QuestionID { get; set; }
        [Required]
        public string Answer { get; set; }
        [Required]
        public bool IsCorrect { get; set; }
    }
}
