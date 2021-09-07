using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace KnowYourArmorPatcher
{
    public class Settings
    {
        [SettingName("Intensité de l'effet")]
        public float EffectIntensity { get; set; } = 1.0f;
        
        [SettingName("Modifier les descriptions")]
        public bool PatchArmorDescriptions { get; set; } = true;
    }
}
