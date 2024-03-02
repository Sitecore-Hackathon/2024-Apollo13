using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Winner.Selections.Client;
using Sitecore.AspNet.RenderingEngine.Binding;

namespace Winner.Feature.Selections.ViewComponents
{
    public abstract class BaseViewComponent : ViewComponent
    {
        protected BaseViewComponent(IViewModelBinder modelBinder, MvpSelectionsApiClient client)
        {
            ModelBinder = modelBinder;
            Client = client;
        }

        protected IViewModelBinder ModelBinder { get; }

        protected MvpSelectionsApiClient Client { get; }

        public abstract Task<IViewComponentResult> InvokeAsync();
    }
}
