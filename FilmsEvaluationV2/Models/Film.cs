using System;
using System.Collections.Generic;

namespace FilmsEvaluationV2.Models
{
    public class Film
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Country { set; get; }
        public int Year { set; get; }
        public TimeSpan Duration { set; get; }
        public string Awards { set; get; }
        public string Description { set; get; }
        public string Picture { get; set; } //Picture

        public List<FilmDirectors> Directors { set; get; }
        public List<FilmGenres> Genres { set; get; }
        public List<FilmActors> Cast { set; get; }
        public List<Like> Likes { set; get; }
        public List<Comment> Comments { set; get; }
    }
}
