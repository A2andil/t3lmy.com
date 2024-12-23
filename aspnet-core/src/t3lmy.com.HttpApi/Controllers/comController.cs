using t3lmy.com.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace t3lmy.com.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class comController : AbpControllerBase
{
    protected comController()
    {
        LocalizationResource = typeof(comResource);
    }
}
