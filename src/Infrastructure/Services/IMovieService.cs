using Core;

namespace Infrastructure.Services;

public interface IMovieService
{
    Movie? FindById(int id);

    IEnumerable<Movie> FindByTitle(string title);
    IEnumerable<Movie> FindByStatus(string status);
    IEnumerable<Movie> FindByTagline(string tagline);
    IEnumerable<Movie> FindByHomepage(string homepage);
    IEnumerable<Movie> FindByOverview(string overview);

    IEnumerable<Movie> FindByReleaseDate(DateOnly date);

    IEnumerable<Movie> FindByRuntime(int runtime);
    IEnumerable<Movie> FindByVoteCount(float count);
    IEnumerable<Movie> FindByVoteAverage(float average);

    IEnumerable<Movie> FindByBudgetRange(int low, int high);
    IEnumerable<Movie> FindByPopularityRange(float low, float high);
    IEnumerable<Movie> FindByRevenueRange(long low, long high);

    IEnumerable<Movie> FindAll();
}
