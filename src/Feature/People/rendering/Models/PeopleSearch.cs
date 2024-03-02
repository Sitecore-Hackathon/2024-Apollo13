using Winner.Foundation.DataFetching.GraphQL.Models;

namespace Winner.Feature.People.Models;

public class PeopleSearch
{
    public MvpSearchResult[] Results { get; set; }
    public int Total { get; set; }
    public PageInfo PageInfo { get; set; }
}