using System.Collections.Generic;

namespace FilmsEvaluationV2.Models
{
    public class Actor : Person
    {
        public int Id { set; get; }
        public string Awards { set; get; }
        public string Picture { get; set; } //Picture

        public List<FilmActors> Filmography { set; get; }
    }
}
