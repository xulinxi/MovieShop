using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class MovieRepository : EfRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Movie>> GetTopRatedMovies()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetMoviesByGenre(int genreId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetHighestGrossingMovies()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Review>> GetMovieReviews(int id)
        {
            throw new System.NotImplementedException();
        }
    }

   
}