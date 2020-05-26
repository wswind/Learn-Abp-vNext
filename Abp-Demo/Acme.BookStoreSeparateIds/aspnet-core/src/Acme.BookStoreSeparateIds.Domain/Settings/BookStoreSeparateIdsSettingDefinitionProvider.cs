using Volo.Abp.Settings;

namespace Acme.BookStoreSeparateIds.Settings
{
    public class BookStoreSeparateIdsSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(BookStoreSeparateIdsSettings.MySetting1));
        }
    }
}
