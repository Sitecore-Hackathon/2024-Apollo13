using Microsoft.AspNetCore.Builder;
using Winner.Project.WinnerSite.Middleware;

namespace Winner.Project.WinnerSite.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder EnsureAcceptLanguageHeader(this IApplicationBuilder app)
        {
            app.UseMiddleware<EnsureAcceptLanguageHeaderMiddleware>();
            return app;
        }

        public static IApplicationBuilder UseNotFoundRouting(this IApplicationBuilder app)
        {
            app.UseMiddleware<NotFoundRoutingMiddleware>();
            return app;
        }
    }
}
