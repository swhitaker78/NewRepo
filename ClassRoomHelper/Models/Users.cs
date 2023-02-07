namespace ClassRoomHelper.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public enum UserTypes
        {
            Admin = 1, Teacher = 2, Student = 3
        }
    }
}
