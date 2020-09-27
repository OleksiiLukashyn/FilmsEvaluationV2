namespace FilmsEvaluationV2.Models
{
    public class AppUser : Person
    {
        public int Id { set; get; }
        public string Nickname { set; get; }
        public string ProfilePicture { get; set; } //Picture
    }
}
