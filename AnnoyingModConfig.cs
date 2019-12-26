using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace AnnoyingMod
{
    [Label("Configuration")]
    public class AnnoyingModConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("Crimson Worlds")]

        [DefaultValue(true)]
        [Label("Crimslime Fix")]
        [Tooltip("Crimslimes will have a chance to inflict Darkness and drop the Blindfold")]
        public bool CrimslimeFix;
    }
}
