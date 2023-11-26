using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


// Me project eke first layer eka CleanMovie.Domain
// second layer eka CleanMovieApplication 
// third layer eka CleanMovieInfrascture
// API is depend on Application layer

// mewa  ekin ekat link wela thiyenne 
// domain =>  application => infranscture


namespace CleanMovie.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Cost { get; set; } 
    }
}
