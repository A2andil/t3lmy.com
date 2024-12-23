using Microsoft.Extensions.Localization;
using t3lmy.com.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace t3lmy.com;

[Dependency(ReplaceServices = true)]
public class comBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<comResource> _localizer;

    public comBrandingProvider(IStringLocalizer<comResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
