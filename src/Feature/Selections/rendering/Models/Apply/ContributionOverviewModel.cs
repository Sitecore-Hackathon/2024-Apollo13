﻿using System;
using Winner.Selections.Domain;
using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace Winner.Feature.Selections.Models.Apply
{
    public class ContributionOverviewModel : ListModel<Contribution>
    {
        public TextField TitleLabel { get; set; }

        public TextField DateTableHeader { get; set; }

        public TextField NameTableHeader { get; set; }

        public TextField TypeTableHeader { get; set; }

        public TextField UriTableHeader { get; set; }

        public TextField IsPublicTableHeader { get; set; }

        public Guid? TogglePublicContributionId { get; set; }
    }
}
