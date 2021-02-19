using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Helpers;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        public async Task<PagedResultSet<MovieResponseModel>> GetMoviesByPagination(int pageSize = 20, int page = 0,
            string title = "")
        {
            throw new System.NotImplementedException();
        }

        public async Task<PagedResultSet<MovieResponseModel>> GetAllMoviePurchasesByPagination(int pageSize = 20,
            int page = 0)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PaginatedList<MovieResponseModel>> GetAllPurchasesByMovieId(int movieId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<MovieDetailsResponseModel> GetMovieAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<ReviewMovieResponseModel>> GetReviewsForMovie(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> GetMoviesCount(string title = "")
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<MovieResponseModel>> GetTopRatedMovies()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<MovieResponseModel>> GetHighestGrossingMovies()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<MovieResponseModel>> GetMoviesByGenre(int genreId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<MovieDetailsResponseModel> CreateMovie(MovieCreateRequest movieCreateRequest)
        {
            throw new System.NotImplementedException();
        }

        public async Task<MovieDetailsResponseModel> UpdateMovie(MovieCreateRequest movieCreateRequest)
        {
            throw new System.NotImplementedException();
        }
    }
}