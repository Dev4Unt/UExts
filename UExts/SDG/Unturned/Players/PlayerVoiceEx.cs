using SDG.Unturned;
using UExts.Reflections;

namespace UExts.SDG.Unturned.Players
{
    public static class PlayerVoiceEx
    {
        public static bool InputWantsToRecord(this PlayerVoice source)
        {
            return ReflectionFieldAccessor<PlayerVoice>.GetValue<bool>("inputWantsToRecord", source);
        }

        public static float AvaliablePlayBackTime(this PlayerVoice source)
        {
            return ReflectionFieldAccessor<PlayerVoice>.GetValue<float>("availablePlaybackTime", source);
        }
    }
}
