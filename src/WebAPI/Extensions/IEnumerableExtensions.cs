namespace WebAPI.Extensions;

public static class IEnumerableExtensions
{
    private const int defaultPageSize = 10;

    public static IEnumerable<T> GetPage<T>(this IEnumerable<T> enumerable, int page, int pageSize)
    {
        if (page < 0)
        {
            page = 0;
        }
        if (pageSize <= 0)
        {
            pageSize = defaultPageSize;
        }

        return enumerable.Skip(pageSize * page).Take(pageSize);
    }
}
