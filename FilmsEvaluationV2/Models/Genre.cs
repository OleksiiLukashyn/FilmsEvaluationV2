using System.Collections.Generic;

namespace FilmsEvaluationV2.Models
{
    public class Genre
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }

        public List<FilmGenres> Filmography { set; get; }
    }
}
