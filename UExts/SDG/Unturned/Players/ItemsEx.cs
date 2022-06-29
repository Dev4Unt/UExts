using SDG.Unturned;
using System;
using UnityEngine;

namespace UExts.SDG.Unturned.Players
{
    public static class ItemsEx
    {
        public static Items[] Clear(this Items[] source,
            Predicate<ItemJar> onBeforeItemRemovedCallback = null,
            Action<ItemJar> onItemRemovedCallback = null,
            Action<ItemJar> onItemRemoveCanceled = null)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (byte page = 0; page < PlayerInventory.PAGES; page += 1)
            {
                source[page].Clear(onBeforeItemRemovedCallback, onItemRemovedCallback, onItemRemoveCanceled);
            }

            return source;
        }

        public static Items Clear(this Items source,
            Predicate<ItemJar> onBeforeItemRemovedCallback = null,
            Action<ItemJar> onItemRemovedCallback = null,
            Action<ItemJar> onItemRemoveCanceled = null)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (byte index = 0; index < source.items.Count; index++)
            {
                ItemJar itemJar = source.getItem(index);

                bool? allow = onBeforeItemRemovedCallback?.Invoke(itemJar);
                if (allow.HasValue && allow.Value)
                {
                    RemoveItem(source, index);
                    onItemRemovedCallback?.Invoke(itemJar);
                }
                else
                {
                    onItemRemoveCanceled?.Invoke(itemJar);
                }
            }

            return source;
        }

        public static Items TransferItemsIfFailedToAddDropItToAnotherAndReturnIt(this Items source, Items target, Vector3 position,
            bool isStateUpdatable, bool playEffect, bool isDropped, bool wideSpread,
            Predicate<ItemJar> onBeforeItemRemovedCallback = null,
            Action<ItemJar> onItemRemovedCallback = null,
            Action<ItemJar> onItemRemoveCanceled = null,
            Action<Item> onItemAdded = null,
            Action<Item> onItemDropped = null,
            Action<Item> onBeforeItemDropped = null)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }


            for (byte i = 0; i < source.items.Count; i++)
            {
                ItemJar itemJar = source.getItem(i);

                bool? allow = onBeforeItemRemovedCallback?.Invoke(itemJar);
                if (allow.HasValue && allow.Value)
                {
                    TryAddItemIfFailedDropIt(source, itemJar.item, position,
                        isStateUpdatable, playEffect, isDropped, wideSpread,
                        onItemAdded, onItemDropped, onBeforeItemDropped);
                    RemoveItem(source, i);
                    onItemRemovedCallback?.Invoke(itemJar);
                }
                else
                {
                    onItemRemoveCanceled?.Invoke(itemJar);
                }
            }

            return target;
        }

        public static Items TryAddItemIfFailedDropIt(this Items source, Item item, Vector3 position,
            bool isStateUpdatable, bool playEffect, bool isDropped, bool wideSpread,
            Action<Item> onItemAdded = null,
            Action<Item> onItemDropped = null,
            Action<Item> onBeforeItemDropped = null)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (source.tryAddItem(item, isStateUpdatable) == false)
            {
                onBeforeItemDropped?.Invoke(item);
                ItemManager.dropItem(item, position, playEffect, isDropped, wideSpread);
                onItemDropped?.Invoke(item);
            }
            else
            {
                onItemAdded?.Invoke(item);
            }

            return source;
        }

        public static Items RemoveItem(this Items source, byte index)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            source.removeItem(index);

            return source;
        }

        public static Items[] RemoveItem(this Items[] source, byte page, byte index)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            source[page].removeItem(index);
            return source;
        }
    }
}
