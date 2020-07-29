using Paper.Record.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Paper.Record.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class RecordController : AbpController
    {
        protected RecordController()
        {
            LocalizationResource = typeof(RecordResource);
        }
    }
}