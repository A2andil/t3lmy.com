using System;
using System.Collections.Generic;
using System.Text;
using t3lmy.com.Localization;
using Volo.Abp.Application.Services;

namespace t3lmy.com;

/* Inherit your application services from this class.
 */
public abstract class comAppService : ApplicationService
{
    protected comAppService()
    {
        LocalizationResource = typeof(comResource);
    }
}
