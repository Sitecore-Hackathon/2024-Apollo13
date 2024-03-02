using Sitecore.AspNet.RenderingEngine.Configuration;
using Sitecore.AspNet.RenderingEngine.Extensions;

namespace Winner.Feature.User.Extensions
{
    public static class RenderingEngineOptionsExtensions
    {
        public static RenderingEngineOptions AddFoundationUser(this RenderingEngineOptions options)
        {
            options.AddPartialView("~/Views/Shared/Components/SignIn.cshtml");
            return options;
        }
    }
}