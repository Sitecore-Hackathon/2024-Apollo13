using Winner.Selections.Domain;
using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace Winner.Feature.Selections.Models.Admin
{
    public class CountriesOverviewModel : ListModel<Country>
    {
        public TextField TitleLabel { get; set; }

        public TextField NameTableHeader { get; set; }
    }
}
