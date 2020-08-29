using System.Collections.Generic;
using System.Drawing;

namespace MovieApp
{
    public class Movie
    {
 
        public Movie() { }
        public Movie(string Id) { this.ImdbId = Id; }
        public string Name { get; set; }
        public string ImdbId { get; set; }
        public string Description { get; set; }
        public List<Image> Images { get; set; }
        public List<Cast> Casts { get; set; }
        
        public override string ToString()
        {
            return this.Name;
        }
    }
}
