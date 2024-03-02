﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Winner.Feature.Selections.Configuration;
using Winner.Feature.Selections.Providers;
using Winner.Feature.Selections.ViewComponents.Admin;
using Winner.Feature.Selections.ViewComponents.Any;
using Winner.Feature.Selections.ViewComponents.Apply;
using Winner.Selections.Client.Extensions;
using Winner.Selections.Client.Interfaces;
using Sitecore.AspNet.RenderingEngine.Configuration;
using Sitecore.AspNet.RenderingEngine.Extensions;

namespace Winner.Feature.Selections.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddFeatureSelectionsServices(this IServiceCollection services)
        {
            services.AddOptions<MvpSelectionsOptions>().Configure<IConfiguration>((options, configuration) =>
                configuration.GetSection(MvpSelectionsOptions.MvpSelections).Bind(options));
            services.AddScoped<ITokenProvider, HttpContextTokenProvider>();
            services.AddMvpSelectionsApiClient();
            return services;
        }

        public static RenderingEngineOptions AddFeatureSelections(this RenderingEngineOptions options)
        {
            options.AddViewComponent(UsersOverviewViewComponent.ViewComponentName);
            options.AddViewComponent(UserEditViewComponent.ViewComponentName);
            options.AddViewComponent(SystemRolesOverviewViewComponent.ViewComponentName);
            options.AddViewComponent(RegionsOverviewViewComponent.ViewComponentName);
            options.AddViewComponent(CountriesOverviewViewComponent.ViewComponentName);
            options.AddViewComponent(ApplicationOverviewViewComponent.ViewComponentName);
            options.AddViewComponent(MvpTypesOverviewViewComponent.ViewComponentName);
            options.AddViewComponent(DashboardViewComponent.ViewComponentName);
            options.AddViewComponent(ApplicationFormViewComponent.ViewComponentName);
            options.AddViewComponent(MyDataEditViewComponent.ViewComponentName);
            options.AddViewComponent(MyProfilesFormViewComponent.ViewComponentName);
            options.AddViewComponent(ScoreCardsViewComponent.ViewComponentName);
            options.AddViewComponent(ScoreCardDetailViewComponent.ViewComponentName);
            options.AddViewComponent(AwardViewComponent.ViewComponentName);
            options.AddViewComponent(ApplicationCommentViewComponent.ViewComponentName);
            options.AddViewComponent(ApplicationReviewSettingsViewComponent.ViewComponentName);
            options.AddViewComponent(ContributionOverviewViewComponent.ViewComponentName);
            options.AddViewComponent(SelectionOverviewViewComponent.ViewComponentName);
            return options;
        }
    }
}
