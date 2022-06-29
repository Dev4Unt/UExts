using SDG.Unturned;
using System;

namespace UExts.SDG.Unturned.Players
{
    public static class PlayerLifeEx
    {
        public static Player SetHealth(this Player source, byte amount)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            source.life.ReceiveHealth(amount);
            return source;
        }
    }
}
