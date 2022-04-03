using MovieDataBase.Data;
using MovieDataBase.Models;

namespace MovieDataBase.Repositories
{
    public class MovieRepository
    {
        MovieContext _movieContext;
        public MovieRepository(MovieContext movieContext)
        {
            this._movieContext = movieContext;

        }
        public void AddMovie(Movie newMovie)
        {
            _movieContext.Movies.Add(newMovie);
            _movieContext.SaveChanges();
        }

        public List<Movie> GetAllMovies()
        {
            return _movieContext.Movies.ToList();
        }
    }
}
