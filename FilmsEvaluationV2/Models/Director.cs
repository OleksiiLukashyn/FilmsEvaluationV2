using System.Collections.Generic;

namespace FilmsEvaluationV2.Models
{
    public class Director : Person
    {
        public int Id { set; get; }
        public string Awards { set; get; }

        public List<FilmActors> Filmography { set; get; }
    }
}
