using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Paper.Record.Web
{
    [Dependency(ReplaceServices = true)]
    public class RecordBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Record";
    }
}
