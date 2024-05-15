using Core;

namespace Infrastructure.Services;

public class EFMovieService : IMovieService
{
    private readonly MovieDbContext _dbContext;

    public EFMovieService(MovieDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Movie> FindAll() => _dbContext.Movies;

    public IEnumerable<Movie> FindByBudgetRange(int low, int high) =>
        _dbContext.Movies.Where(m => m.Budget >= low && m.Budget <= high);

    public IEnumerable<Movie> FindByHomepage(string homepage) =>
        _dbContext.Movies.Where(m => m.Homepage == homepage);

    public Movie? FindById(int id) => _dbContext.Movies.Find(id);

    public IEnumerable<Movie> FindByOverview(string overview) =>
        _dbContext.Movies.Where(m => m.Overview == overview);

    public IEnumerable<Movie> FindByPopularityRange(float low, float high) =>
        _dbContext.Movies.Where(m => m.Popularity >= low && m.Popularity <= high);

    public IEnumerable<Movie> FindByReleaseDate(DateOnly date) =>
        _dbContext.Movies.Where(m => m.ReleaseDate == date.ToDateTime(new TimeOnly()));

    public IEnumerable<Movie> FindByRevenueRange(long low, long high) =>
        _dbContext.Movies.Where(m => m.Revenue >= low && m.Revenue <= high);

    public IEnumerable<Movie> FindByRuntime(int runtime) =>
        _dbContext.Movies.Where(m => m.Runtime == runtime);

    public IEnumerable<Movie> FindByStatus(string status) =>
        _dbContext.Movies.Where(m => m.MovieStatus == status);

    public IEnumerable<Movie> FindByTagline(string tagline) =>
        _dbContext.Movies.Where(m => m.Tagline == tagline);

    public IEnumerable<Movie> FindByTitle(string title) =>
        _dbContext.Movies.Where(m => m.Title == title);

    public IEnumerable<Movie> FindByVoteAverage(float average) =>
        _dbContext.Movies.Where(m => m.VoteAverage == average);

    public IEnumerable<Movie> FindByVoteCount(float count) =>
        _dbContext.Movies.Where(m => m.VoteCount == count);
}
