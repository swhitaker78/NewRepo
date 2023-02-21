using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ClassRoomHelper.Models
{
    public class FlashCard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int FlashCardID { get; set; }
        [Required]
        public int SubjectID { get; set; }
        [Required]
        public string CardTitle { get; set; }
        [Required]
        public string CardQuestion { get; set; }
        [Required]
        public string CardAnswer { get; set; }
    }
}
