using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Microsoft.Extensions.Caching.Memory;

namespace Infrastructure.Services
{
    public class GenreService : IGenreService
    {
        private readonly IAsyncRepository<Genre> _genreRepository;
        private static readonly TimeSpan _defaultCacheDuration = TimeSpan.FromDays(30);
        private static readonly string _genresKey = "genres";
        private readonly IMemoryCache _cache;

        public GenreService(IAsyncRepository<Genre> genreRepository, IMemoryCache cache)
        {
            _genreRepository = genreRepository;
            _cache = cache;
        }

        public async Task<IEnumerable<Genre>> GetAllGenres()
        {
            var genres = await _cache.GetOrCreateAsync(_genresKey, async entry =>
            {
                entry.SlidingExpiration = _defaultCacheDuration;
                return await _genreRepository.ListAllAsync();
            });
            return genres.OrderBy(g => g.Name);
        }
    }
}