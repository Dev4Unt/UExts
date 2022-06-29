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

            for (byte p = 0; p < PlayerInventory.PAGES - 2; p += 1)
            {
                for (byte i = 0; i < source.items[p].items.Count; i++)
                {
                    ItemJar itemJar = source.items[p].getItem(i);

                    bool? allow = onBeforeItemRemovedCallback?.Invoke(itemJar);
                    if (allow.HasValue && allow.Value)
                    {
                        source.removeItem(p, i);
                        onItemRemovedCallback?.Invoke(itemJar);
                    }
                    else
                    {
                        onItemRemoveCanceled?.Invoke(itemJar);
                    }
                }
            }

            return source;
        }
    }
}
