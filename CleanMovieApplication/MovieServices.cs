using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovieApplication
{
    public class MovieServices : IMovieServices
    {
        // Constructor Dependancy injection 
        // to create constructor type => ctor then hit enter
        public MovieServices( IMovieReporsitory movieReporsitory)
        {
            MovieReporsitory = movieReporsitory;
        }

        public IMovieReporsitory MovieReporsitory { get; }

        public List<Movie> GetAllMovies()
        {
            
            var movies = MovieReporsitory.GetAllMovies();
           return movies; 
        }
    }
}
