using SDG.Unturned;

namespace UExts.SDG.Unturned.Players
{
    public static class PlayerInputEx
    {
        public static bool IsKey(this PlayerInput player, InputKeys key)
        {
           return player.keys[(int)key];
        }

        public static bool HasInputed(this PlayerInput player)
        {
            return Reflections.ReflectionFieldAccessor<PlayerInput>.GetValue<bool>("hasInputed", player);
        }

        public static float LastInuted(this PlayerInput player)
        {
            return Reflections.ReflectionFieldAccessor<PlayerInput>.GetValue<float>("lastInputed", player);
        }
    }
}