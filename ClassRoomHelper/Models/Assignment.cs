namespace ClassRoomHelper.Models
{
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public int SubjectID { get; set; }
        public string AssignmentName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? CompletionDate { get; set; }
    }
}
