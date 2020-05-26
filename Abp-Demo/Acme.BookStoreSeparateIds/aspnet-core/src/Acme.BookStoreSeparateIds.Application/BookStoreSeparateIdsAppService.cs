using System;
using System.Collections.Generic;
using System.Text;
using Acme.BookStoreSeparateIds.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookStoreSeparateIds
{
    /* Inherit your application services from this class.
     */
    public abstract class BookStoreSeparateIdsAppService : ApplicationService
    {
        protected BookStoreSeparateIdsAppService()
        {
            LocalizationResource = typeof(BookStoreSeparateIdsResource);
        }
    }
}
