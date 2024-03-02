using Microsoft.AspNetCore.Builder;
using Winner.Project.WinnerSite.Extensions;
using Sitecore.AspNet.RenderingEngine.Extensions;
using Sitecore.AspNet.RenderingEngine.Middleware;

namespace Winner.Project.WinnerSite.Middleware
{
    public class MvpSiteRenderingEnginePipeline : RenderingEnginePipeline
    {
        public override void Configure(IApplicationBuilder app)
        {
            app.UseSitecoreRenderingEngine();
            app.UseNotFoundRouting();
        }
    }
}
