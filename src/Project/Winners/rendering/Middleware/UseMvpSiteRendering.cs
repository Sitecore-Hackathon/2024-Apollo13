using System;
using Microsoft.AspNetCore.Mvc;

namespace Winner.Project.WinnerSite.Middleware
{
    public class UseMvpSiteRendering(Type configurationType) : MiddlewareFilterAttribute(configurationType)
    {
        public UseMvpSiteRendering()
        : this(typeof(MvpSiteRenderingEnginePipeline))
        {
        }
    }
}
