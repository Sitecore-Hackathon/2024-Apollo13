﻿using Winner.Feature.BasicContent.Models;
using Sitecore.AspNet.RenderingEngine.Configuration;
using Sitecore.AspNet.RenderingEngine.Extensions;

namespace Winner.Feature.BasicContent.Extensions
{
    public static class RenderingEngineOptionsExtensions
    {
        public static RenderingEngineOptions AddFeatureBasicContent(this RenderingEngineOptions options)
        {
            options.AddModelBoundView<AnnouncementBar>("AnnouncementBar")
                   .AddModelBoundView<HalfWidthBanner>("HalfWidthBanner")
                   .AddModelBoundView<ContentList>("ContentList")
                   .AddModelBoundView<RichTextContent>("RichTextContent")
                   .AddModelBoundView<ImageTeaser>("ImageTeaser")
                   .AddModelBoundView<VideoTeaser>("VideoTeaser")
                   .AddModelBoundView<EmbedContent>("EmbedContent")
                   .AddPartialView("ColumnContainer")
                   .AddPartialView("PageOverviewPanel")

            .AddModelBoundView<HeroBig>("HeroBig")
              .AddModelBoundView<HeroMedium>("HeroMedium")
              .AddModelBoundView<HeroMediumWithLink>("HeroMediumWithLink");

            return options;
        }
    }
}