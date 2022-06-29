using SDG.Unturned;
using System;

namespace UExts.SDG.Unturned.Players
{
    public static class PlayerInventoryEx
    {
        public static PlayerInventory Clear(this PlayerInventory source,
            Predicate<ItemJar> onBeforeItemRemovedCallback = null,
            Action<ItemJar> onItemRemovedCallback = null,
            Action<ItemJar> onItemRemoveCanceled = null)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            source.items.Clear(onBeforeItemRemovedCallback, onItemRemovedCallback, onItemRemoveCanceled);
            return source;
        }
    }
}
