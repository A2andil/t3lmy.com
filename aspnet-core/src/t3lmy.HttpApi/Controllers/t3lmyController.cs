using t3lmy.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace t3lmy.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class t3lmyController : AbpControllerBase
{
    protected t3lmyController()
    {
        LocalizationResource = typeof(t3lmyResource);
    }
}
