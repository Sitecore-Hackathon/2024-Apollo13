using GraphQL.Client.Abstractions;

namespace Winner.Foundation.DataFetching.GraphQL
{
    public interface IGraphQLClientFactory
    {
        public IGraphQLClient CreateGraphQlClient();
    }
}
