using SDG.Unturned;

namespace UExts.SDG.Unturned.Players
{
    public static class PlayerInputEx
    {
        public static bool PlayerInput(this PlayerInput player, InputKeys key)
        {
           return player.keys[(int)key];
        }
    }
}