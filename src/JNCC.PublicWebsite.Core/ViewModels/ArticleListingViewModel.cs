﻿using System;
using System.Web;
using Umbraco.Cms.Core.Strings;

namespace JNCC.PublicWebsite.Core.ViewModels
{
    public sealed class ArticleListingViewModel
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string ImageAltText { get; set; }
        public string ImageTitleText { get; set; }
        public DateTime PublishDate { get; set; }
        public IHtmlEncodedString Description { get; set; }
        public string Url { get; set; }
        public string ArticleType { get; set; }
    }
}
