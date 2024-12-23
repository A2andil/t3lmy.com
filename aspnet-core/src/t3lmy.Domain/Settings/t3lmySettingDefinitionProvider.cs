using Volo.Abp.Settings;

namespace t3lmy.Settings;

public class t3lmySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(t3lmySettings.MySetting1));
    }
}
