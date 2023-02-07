namespace ClassRoomHelper.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string AssignmentID { get; set; }
        public string QuestionInfo { get; set; }
        public List<Answers> AnswerChoices { get; set; }
        public int CorrectAnswerID { get; set; }
        
    }
}
