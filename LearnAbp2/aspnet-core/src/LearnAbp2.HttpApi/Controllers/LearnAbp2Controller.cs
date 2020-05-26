using LearnAbp2.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LearnAbp2.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LearnAbp2Controller : AbpController
    {
        protected LearnAbp2Controller()
        {
            LocalizationResource = typeof(LearnAbp2Resource);
        }
    }
}