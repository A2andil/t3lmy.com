using Microsoft.Extensions.Localization;
using t3lmy.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace t3lmy;

[Dependency(ReplaceServices = true)]
public class t3lmyBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<t3lmyResource> _localizer;

    public t3lmyBrandingProvider(IStringLocalizer<t3lmyResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
