using SDG.Unturned;
using System;
using UnityEngine;

namespace UExts.SDG.Unturned.Players
{
    public class DropItemInfo
    {
        public Vector3 Point { get; set; }
        public bool PlayEffect { get; set; }
        public bool IsDropped { get; set; }
        public bool WideSpread { get; set; }
    }


    public static class ItemsEx
    {
        public static Items Clear(this Items source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            byte itemsCount = source.getItemCount();
            for (byte index = 0; index < itemsCount; index++)
            {
                source.removeItem(0);
            }

            return source;
        }
        public static Items Clear(this Items source, Predicate<ItemJar> predicate)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (predicate == null)
            {
                return source.Clear();
            }

            byte itemsCount = source.getItemCount();
            byte skipCount = 0;
            for (byte index = 0; index < itemsCount; index++)
            {
                ItemJar item = source.getItem(index);
                if (predicate.Invoke(item))
                {
                    source.removeItem(skipCount);
                }
                else
                {
                    skipCount++;
                }
            }

            return source;
        }

        public static Items Drop(this Items source, Vector3 point, bool playEffect, bool isDropped, bool wideSpread)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            byte itemsCount = source.getItemCount();
            for (byte index = 0; index < itemsCount; index++)
            {
                ItemManager.dropItem(source.getItem(index).item, point, playEffect, isDropped, wideSpread);
            }

            return source;
        }
        public static Items Drop(this Items source, Func<ItemJar, DropItemInfo> func)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (func == null)
            {
                throw new ArgumentNullException(nameof(func));
            }

            byte itemsCount = source.getItemCount();
            for (byte index = 0; index < itemsCount; index++)
            {
                DropItemInfo info = func.Invoke(source.getItem(index));
                if (info != null)
                {
                    ItemManager.dropItem(source.getItem(index).item, info.Point, info.PlayEffect, info.IsDropped, info.WideSpread);
                }
            }

            return source;
        }

        public static Items Move(this Items source, Items output, Predicate<ItemJar> onItemNeedMoreSpace)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }
            if (onItemNeedMoreSpace == null)
            {
                throw new ArgumentNullException(nameof(onItemNeedMoreSpace));
            }

            byte itemsCount = source.getItemCount();
            byte skipCount = 0;
            for (byte index = 0; index < itemsCount; index++)
            {
                ItemJar item = source.getItem(skipCount);
                if (output.tryAddItem(item.item) == false && onItemNeedMoreSpace.Invoke(item) == false)
                {
                    skipCount++;
                }
                else
                {
                    source.removeItem(skipCount);
                }
            }

            return source;
        }
        public static Items Move(this Items source, Items output, Predicate<ItemJar> onItemNeedMoreSpace, Predicate<ItemJar> predicate)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }
            if (onItemNeedMoreSpace == null)
            {
                throw new ArgumentNullException(nameof(onItemNeedMoreSpace));
            }
            if (predicate == null)
            {
                return source.Move(output, onItemNeedMoreSpace);
            }

            byte itemsCount = source.getItemCount();
            byte skipCount = 0;
            for (byte index = 0; index < itemsCount; index++)
            {
                ItemJar item = source.getItem(skipCount);
                if (predicate.Invoke(item))
                {
                    if (output.tryAddItem(item.item) == false && onItemNeedMoreSpace.Invoke(item))
                    {
                        skipCount++;
                    }
                    else
                    {
                        source.removeItem(skipCount);
                    }
                }
                else
                {
                    skipCount++;
                }
            }

            return source;
        }

        public static Items Copy(this Items source, Items output, Action<ItemJar> onItemNeedMoreSpace)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }
            if (onItemNeedMoreSpace == null)
            {
                throw new ArgumentNullException(nameof(onItemNeedMoreSpace));
            }

            byte itemsCount = source.getItemCount();
            for (byte index = 0; index < itemsCount; index++)
            {
                ItemJar item = source.getItem(index);
                if (output.tryAddItem(item.item) == false)
                {
                    onItemNeedMoreSpace.Invoke(item);
                }
            }

            return source;
        }
        public static Items Copy(this Items source, Items output, Action<ItemJar> onItemNeedMoreSpace, Predicate<ItemJar> predicate)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }
            if (onItemNeedMoreSpace == null)
            {
                throw new ArgumentNullException(nameof(onItemNeedMoreSpace));
            }
            if (predicate == null)
            {
                return source.Copy(output, onItemNeedMoreSpace);
            }

            byte itemsCount = source.getItemCount();
            for (byte index = 0; index < itemsCount; index++)
            {
                ItemJar item = source.getItem(index);
                if (predicate.Invoke(item) && output.tryAddItem(item.item) == false)
                {
                    onItemNeedMoreSpace.Invoke(item);
                }
            }

            return source;
        }
    }
}
