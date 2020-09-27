using System.Collections.Generic;

namespace FilmsEvaluationV2.Models
{
    public class Playlist
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public AppUser Creator { set; get; }
        public List<Film> Films { set; get; }
    }
}
