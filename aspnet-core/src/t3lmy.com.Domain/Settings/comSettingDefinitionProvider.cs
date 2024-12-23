using Volo.Abp.Settings;

namespace t3lmy.com.Settings;

public class comSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(comSettings.MySetting1));
    }
}
