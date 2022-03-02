﻿using JNCC.PublicWebsite.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using JNCC.PublicWebsite.Core.Interfaces.Services;
using JNCC.PublicWebsite.Core.Interfaces.Providers;
using JNCC.PublicWebsite.Core.Providers;
using JNCC.PublicWebsite.Core.Configuration;
using JNCC.PublicWebsite.Core.Constants;
using Microsoft.Extensions.Configuration;

namespace JNCC.PublicWebsite.Core.Composers
{
    public class WebComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            //Services
            builder.Services.AddSingleton<IHomePageService, HomePageService>();
            builder.Services.AddSingleton<IScienceDetailsPageService, ScienceDetailsPageService>();
            builder.Services.AddSingleton<ICareersLandingPageService, CareersLandingPageService>();
            builder.Services.AddSingleton<IIndividualJobPageService, IndividualJobPageService>();
            builder.Services.AddSingleton<IScienceAtoZPageService, ScienceAtoZPageService>();
            builder.Services.AddSingleton<IScienceLandingPageService, ScienceLandingPageService>();
            builder.Services.AddSingleton<IScienceCategoryPageService, ScienceCategoryPageService>();
            builder.Services.AddSingleton<IIFramePageService, IFramePageService>();
            builder.Services.AddSingleton<INewsAndInsightsLandingService, NewsAndInsightsLandingService>();

            builder.Services.AddSingleton<IBreadcrumbsService, BreadcrumbsService>();
            builder.Services.AddSingleton<INavigationItemService, NavigationItemService>();
            builder.Services.AddSingleton<IPageHeroService, PageHeroService>();
            builder.Services.AddSingleton<IMainNavigationService, MainNavigationService>();
            builder.Services.AddSingleton<ICategorisedFooterLinksService, CategorisedFooterLinksService>();
            builder.Services.AddSingleton<ISocialMediaLinksService, SocialMediaLinksService>();
            builder.Services.AddSingleton<ISidebarService, SidebarService>();
            builder.Services.AddSingleton<IScienceSidebarService, ScienceSidebarService>();
            builder.Services.AddSingleton<IRelatedItemService, RelatedItemsService>();
            builder.Services.AddSingleton<ICareersSidebarService, CareersSidebarService>();
            builder.Services.AddSingleton<ICalloutCardsService, CalloutCardsService>();
            builder.Services.AddSingleton<ILatestNewsSectionService, LatestNewsSectionService>();
            builder.Services.AddSingleton<ISearchQueryService, SearchQueryService>();
            builder.Services.AddSingleton<IDataHubRawQueryService, DataHubRawQueryService>();
            builder.Services.AddSingleton<IQueryService, QueryService>();
            builder.Services.AddSingleton<INewsAndInsightsLandingFilteringService, NewsAndInsightsLandingFilteringService>();

            builder.Services.AddSingleton<IScienceDetailsPageProvider, UmbracoScienceDetailsPageProvider>();
            builder.Services.AddSingleton<ISciencePageCategoriesProvider, UmbracoSciencePageCategoriesProvider>();
            builder.Services.AddSingleton<IUmbracoArticleYearsProvider, UmbracoArticleYearsProvider>();
            builder.Services.AddSingleton<IUmbracoArticleTypesProvider, UmbracoArticleTypesProvider>();
            builder.Services.AddSingleton<IUmbracoArticlePageTagsProvider, UmbracoArticlePageTagsProvider>();
        }
    }
}