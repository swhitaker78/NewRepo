namespace ClassRoomHelper.Models
{
    public class Answers
    {
        public int AnswerID { get; set; }
        public int QuestionID { get; set; }
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }
    }
}
