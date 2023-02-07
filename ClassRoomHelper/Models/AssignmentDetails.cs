namespace ClassRoomHelper.Models
{
    public class AssignmentDetails
    {
        public int AssignDetailID { get; set; }
        public string AssignmentID { get; set; }
        public string AssignmentType { get; set; }
        public List<Question> Questions { get; set; }

    }
}
