using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovieApplication
{
    // interface hadannne inherit karla ganna class ( normaly interface wala hadanne parent class ekak )

    // this is use case 
    public interface IMovieServices
    {
        List<Movie> GetAllMovies();
    }
}
