using SDG.Unturned;
using System;

namespace UExts.SDG.Unturned.Players
{
    public static class PlayerStanceEx
    {
        public static Player Set(this Player source, EPlayerStance stance)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            source.stance.ReceiveStance(stance);
            return source;
        }
    }
}
