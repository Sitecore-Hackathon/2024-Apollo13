﻿using Winner.Feature.Navigation.Models;
using Sitecore.AspNet.RenderingEngine.Configuration;
using Sitecore.AspNet.RenderingEngine.Extensions;

namespace Winner.Feature.Navigation.Extensions
{
    public static class RenderingEngineOptionsExtensions
    {
        public static RenderingEngineOptions AddFeatureNavigation(this RenderingEngineOptions options)
        {
            options.AddModelBoundView<TopLinks>("TopLinks")
                   .AddModelBoundView<MainNav>("MainNav")
                   .AddModelBoundView<Footer>("Footer");
            return options;
        }
    }
}