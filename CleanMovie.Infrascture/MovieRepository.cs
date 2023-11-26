using CleanMovie.Domain;
using CleanMovieApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrascture
{
    public class MovieRepository : IMovieReporsitory  // to fix the error select IMovieReporsitory and ctrl + enter
    {

        public static List<Movie> movies = new List<Movie>() 
        { 
            new Movie{ Id =1 , Cost = 2, Name = "bigi"},
            new Movie{ Id =2 , Cost = 6, Name = "bahubali"},
            new Movie{ Id =3 , Cost = 23, Name = "surya"}
        };


        public List<Movie> GetAllMovies()
        {
           return movies;
        }
    }
}
