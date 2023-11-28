using Clean.Application;
using Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Infrastructure
{
    public class MovieRepository : iMovieRepository
    {
        private MovieDbContext _MovieDbContext;
        public MovieRepository(MovieDbContext movieDbContext)
        {
            _MovieDbContext = movieDbContext;
        }

        public static List<Movie> movies = new List<Movie>();

        public Movie CreateMovie(Movie movie)
        {
            _MovieDbContext.Movies.Add(movie);
            _MovieDbContext.SaveChanges();
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _MovieDbContext.Movies.ToList();
        }
    }
}
