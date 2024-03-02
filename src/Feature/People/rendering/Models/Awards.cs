using Winner.Foundation.DataFetching.GraphQL.Models;

namespace Winner.Feature.People.Models;

public class Awards
{
    public NameItem Parent { get; set; }

    public TargetItemFieldValueItem Field { get; set; }
}