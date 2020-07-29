using Paper.Record.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Paper.Record.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class RecordPageModel : AbpPageModel
    {
        protected RecordPageModel()
        {
            LocalizationResourceType = typeof(RecordResource);
        }
    }
}