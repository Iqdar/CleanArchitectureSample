using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Domain;


namespace Clean.Application
{
    public interface iMovieRepository
    {

        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);
    }
}
