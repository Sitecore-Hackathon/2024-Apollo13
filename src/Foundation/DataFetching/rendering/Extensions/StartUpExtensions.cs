using Microsoft.Extensions.DependencyInjection;
using Winner.Foundation.DataFetching.GraphQL;

namespace Winner.Feature.People.Exntesions
{
    public static class StartUpExtensions
    {
        public static IServiceCollection AddFoundationDataFetchingServices(this IServiceCollection services)
        {
            services.AddTransient<IGraphQLClientFactory, GraphQLClientFactory>();
            services.AddTransient<IGraphQLRequestBuilder, GraphQLRequestBuilder>();
            services.AddHttpClient<GraphQLClientFactory>();
            return services;
        }
    }
}