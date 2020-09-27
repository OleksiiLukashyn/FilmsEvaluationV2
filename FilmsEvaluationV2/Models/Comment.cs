using System;

namespace FilmsEvaluationV2.Models
{
    public class Comment
    {
        public int Id { set; get; }
        public string Text { set; get; }
        public DateTime CreationTime { set; get; }

        public AppUser Creator { set; get; }
        public Film Film { set; get; }
    }
}
