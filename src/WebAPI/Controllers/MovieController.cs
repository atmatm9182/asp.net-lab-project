using Core;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Extensions;

namespace WebAPI;

[ApiController]
[Route("/api/movies")]
public class MovieController : ControllerBase
{
    private const int pageSize = 25;

    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet]
    [Route("{page}")]
    public IEnumerable<Movie> GetAll(int page) => _movieService.FindAll().GetPage(page, pageSize);

    [HttpGet]
    [Route("byTitle/{title}/{page}")]
    public IEnumerable<Movie> GetByTitle(string title, int page) =>
        _movieService.FindByTitle(title).GetPage(page, pageSize);

    [HttpGet]
    [Route("byStatus/{status}/{page}")]
    public IEnumerable<Movie> GetByStatus(string status, int page) =>
        _movieService.FindByStatus(status).GetPage(page, pageSize);

    [HttpGet]
    [Route("byTagline/{tagline}/{page}")]
    public IEnumerable<Movie> GetByTagline(string tagline, int page) =>
        _movieService.FindByTagline(tagline).GetPage(page, pageSize);

    [HttpGet]
    [Route("byHomepage/{homepage}/{page}")]
    public IEnumerable<Movie> GetByHomepage(string homepage, int page) =>
        _movieService.FindByHomepage(homepage).GetPage(page, pageSize);

    [HttpGet]
    [Route("byOverview/{overview}/{page}")]
    public IEnumerable<Movie> GetByOverview(string overview, int page) =>
        _movieService.FindByOverview(overview).GetPage(page, pageSize);

    [HttpGet]
    [Route("byReleaseDate/{releaseDate}/{page}")]
    public IEnumerable<Movie> GetByReleaseDate(DateOnly releaseDate, int page) =>
        _movieService.FindByReleaseDate(releaseDate).GetPage(page, pageSize);

    [HttpGet]
    [Route("byRuntime/{runtime}/{page}")]
    public IEnumerable<Movie> GetByRuntime(int runtime, int page) =>
        _movieService.FindByRuntime(runtime).GetPage(page, pageSize);

    [HttpGet]
    [Route("byVoteCount/{count}/{page}")]
    public IEnumerable<Movie> GetByVoteCount(float count, int page) =>
        _movieService.FindByVoteCount(count).GetPage(page, pageSize);

    [HttpGet]
    [Route("byVoteAverage/{average}/{page}")]
    public IEnumerable<Movie> GetByVoteAverage(float average, int page) =>
        _movieService.FindByVoteAverage(average).GetPage(page, pageSize);

    [HttpGet]
    [Route("byBudgetRange/{low}/{high}/{page}")]
    public IEnumerable<Movie> GetByBudgetRange(int low, int high, int page) =>
        _movieService.FindByBudgetRange(low, high).GetPage(page, pageSize);

    [HttpGet]
    [Route("byPopularityRange/{low}/{high}/{page}")]
    public IEnumerable<Movie> GetByPopularityRange(float low, float high, int page) =>
        _movieService.FindByPopularityRange(low, high).GetPage(page, pageSize);

    [HttpGet]
    [Route("byRevenueRange/{low}/{high}/{page}")]
    public IEnumerable<Movie> GetByRevenueRange(long low, long high, int page) =>
        _movieService.FindByRevenueRange(low, high).GetPage(page, pageSize);
}
