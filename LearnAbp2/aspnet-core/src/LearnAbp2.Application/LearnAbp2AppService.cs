using System;
using System.Collections.Generic;
using System.Text;
using LearnAbp2.Localization;
using Volo.Abp.Application.Services;

namespace LearnAbp2
{
    /* Inherit your application services from this class.
     */
    public abstract class LearnAbp2AppService : ApplicationService
    {
        protected LearnAbp2AppService()
        {
            LocalizationResource = typeof(LearnAbp2Resource);
        }
    }
}
