using Volo.Abp.Settings;

namespace Paper.Record.Settings
{
    public class RecordSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(RecordSettings.MySetting1));
        }
    }
}
