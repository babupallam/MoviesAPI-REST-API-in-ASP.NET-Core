using MoviesAPI.Entities;

namespace MoviesAPI.Services
{
    /*
     * A fake memory repository for 
     */
    public class InMemoryRepository: IRepository
    {
        private List<Genre> _genres;
        public InMemoryRepository()
        {
            _genres = new List<Genre>()
            {
                new Genre(){Id = 1, Name ="Comedy"},
                new Genre(){Id = 2, Name ="Action"},
                new Genre(){Id = 3, Name ="Sci-Fi"},
            };
        }
        public List<Genre> GetAllGenres()
        {
            return _genres;
        }

        public Genre GetGenreById(int Id)
        {
            return _genres.FirstOrDefault(x => x.Id == Id);
        }
    }
}
