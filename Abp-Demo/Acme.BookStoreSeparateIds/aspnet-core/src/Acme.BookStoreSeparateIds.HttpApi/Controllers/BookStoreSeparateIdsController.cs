using Acme.BookStoreSeparateIds.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStoreSeparateIds.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BookStoreSeparateIdsController : AbpController
    {
        protected BookStoreSeparateIdsController()
        {
            LocalizationResource = typeof(BookStoreSeparateIdsResource);
        }
    }
}