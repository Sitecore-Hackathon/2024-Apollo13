using Winner.Selections.Domain;
using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace Winner.Feature.Selections.Models.Admin
{
    public class RegionsOverviewModel : ListModel<Region>
    {
        public TextField TitleLabel { get; set; }

        public TextField NameTableHeader { get; set; }

        public TextField CountryCountTableHeader { get; set; }
    }
}
