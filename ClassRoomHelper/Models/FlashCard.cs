namespace ClassRoomHelper.Models
{
    public class FlashCard
    {
        public int FlashCardID { get; set; }
        public int SubjectID { get; set; }
        public string CardTitle { get; set; }
        public string CardQuestion { get; set; }
        public string CardAnswer { get; set; }
    }
}
