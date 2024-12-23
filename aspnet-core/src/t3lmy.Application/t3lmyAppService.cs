using System;
using System.Collections.Generic;
using System.Text;
using t3lmy.Localization;
using Volo.Abp.Application.Services;

namespace t3lmy;

/* Inherit your application services from this class.
 */
public abstract class t3lmyAppService : ApplicationService
{
    protected t3lmyAppService()
    {
        LocalizationResource = typeof(t3lmyResource);
    }
}
