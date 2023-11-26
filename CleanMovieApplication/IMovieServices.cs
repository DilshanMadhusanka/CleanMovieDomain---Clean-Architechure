using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovieApplication
{


    // this is use case 
    public interface IMovieServices
    {
        List<Movie> GetAllMovies();
    }
}
