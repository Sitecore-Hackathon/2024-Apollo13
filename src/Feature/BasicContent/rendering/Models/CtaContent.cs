using Sitecore.LayoutService.Client.Response.Model.Fields;
using System;
using System.Collections.Generic;
using System.Text;

namespace Winner.Feature.BasicContent.Models
{
    public class CtaContent
    {
        public TextField CtaTitle { get; set; }
        public RichTextField CtaText { get; set; }
        public HyperLinkField CtaLink { get; set; }
        public ImageField CtaImage{ get; set; }
    }
}
