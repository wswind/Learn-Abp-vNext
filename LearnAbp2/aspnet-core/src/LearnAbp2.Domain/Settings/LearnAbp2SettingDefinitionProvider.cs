using Volo.Abp.Settings;

namespace LearnAbp2.Settings
{
    public class LearnAbp2SettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(LearnAbp2Settings.MySetting1));
        }
    }
}
