using Volo.Abp.Settings;

namespace HelloWord.Settings;

public class HelloWordSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HelloWordSettings.MySetting1));
    }
}
