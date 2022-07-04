using SDG.Unturned;
using UExts.Reflections;

namespace UExts.SDG.Unturned.Players
{
    public enum InputKeys
    {
        Jump = 0,
        Primary = 1,
        Secondary = 2,
        Crouch = 3,
        Prone = 4,
        Sprint = 5,
        LeanLeft = 6,
        LeanRight = 7,
        PluginKey1 = 9,
        PluginKey2 = 10,
        PluginKey3 = 11,
        PluginKey4 = 12,
        PluginKey5 = 13,
    }

    public static class PlayerInputEx
    {
        public static bool IsKey(this PlayerInput source, InputKeys key)
        {
           return source.keys[(int)key];
        }

        public static bool HasInputed(this PlayerInput source)
        {
            return ReflectionFieldAccessor<PlayerInput>.GetValue<bool>("hasInputed", source);
        }

        public static float LastInputed(this PlayerInput source)
        {
            return ReflectionFieldAccessor<PlayerInput>.GetValue<float>("lastInputed", source);
        }

        public static bool IsDismissed(this PlayerInput source)
        {
            return ReflectionFieldAccessor<PlayerInput>.GetValue<bool>("isDismissed", source);
        }
    }
}