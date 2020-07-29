using System;
using System.Collections.Generic;
using System.Text;
using Paper.Record.Localization;
using Volo.Abp.Application.Services;

namespace Paper.Record
{
    /* Inherit your application services from this class.
     */
    public abstract class RecordAppService : ApplicationService
    {
        protected RecordAppService()
        {
            LocalizationResource = typeof(RecordResource);
        }
    }
}
