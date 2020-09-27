namespace FilmsEvaluationV2.Models
{
    public class Like
    {
        public int Id { set; get; }

        public AppUser Creator { set; get; }
        public Film Film { set; get; }
    }
}
