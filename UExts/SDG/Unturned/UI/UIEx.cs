using SDG.Unturned;

namespace UExts.SDG.Unturned.UI
{
    public static class UIEx
    {
        public static Player EnableEverythingInUI(this Player source)
        {
            source.enablePluginWidgetFlag(EPluginWidgetFlags.Modal
                | EPluginWidgetFlags.ShowHealth
                | EPluginWidgetFlags.ShowFood
                | EPluginWidgetFlags.ShowWater
                | EPluginWidgetFlags.ShowVirus
                | EPluginWidgetFlags.ShowStamina
                | EPluginWidgetFlags.ShowLifeMeters
                | EPluginWidgetFlags.ShowStatusIcons
                | EPluginWidgetFlags.ShowDeathMenu
                | EPluginWidgetFlags.ShowInteractWithEnemy
                | EPluginWidgetFlags.ShowUseableGunStatus
                | EPluginWidgetFlags.ShowVehicleStatus);
            return source;
        }

        public static Player DisableEverythingInUI(this Player source)
        {
            source.disablePluginWidgetFlag(EPluginWidgetFlags.Modal
                | EPluginWidgetFlags.ShowHealth
                | EPluginWidgetFlags.ShowFood
                | EPluginWidgetFlags.ShowWater
                | EPluginWidgetFlags.ShowVirus
                | EPluginWidgetFlags.ShowStamina
                | EPluginWidgetFlags.ShowLifeMeters
                | EPluginWidgetFlags.ShowStatusIcons
                | EPluginWidgetFlags.ShowDeathMenu
                | EPluginWidgetFlags.ShowInteractWithEnemy
                | EPluginWidgetFlags.ShowUseableGunStatus
                | EPluginWidgetFlags.ShowVehicleStatus);
            return source;
        }
    }
}
