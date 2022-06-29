using SDG.Unturned;
using System;
using UnityEngine;

namespace UExts.SDG.Unturned.Players
{
    public static class InterctableStorageEx
    {
        public static InteractableStorage FindInWorldAndGetByInstanceId(uint value)
        {
            for (byte b1 = 0; b1 < Regions.WORLD_SIZE; b1++)
            {
                for (byte b2 = 0; b2 < Regions.WORLD_SIZE; b2++)
                {
                    BarricadeRegion barricadeRegion = null;
                    if ((barricadeRegion = BarricadeManager.regions[b1, b2]) != null)
                    {
                        for (int i = 0; i < barricadeRegion.drops.Count; i++)
                        {
                            if (barricadeRegion.drops[i].instanceID == value)
                            {
                                return barricadeRegion.drops[i].model.GetComponent<InteractableStorage>();
                            }
                        }
                    }
                }
            }

            return null;
        }

        public static bool TryFindInWorldAndGetByInstanceId(uint value, out InteractableStorage storage)
        {
            return (storage = FindInWorldAndGetByInstanceId(value)) != null;
        }

        public static InteractableStorage CloseAndNotifyClient(this InteractableStorage source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.isOpen)
            {
                if (source.opener != null)
                {
                    if (source.opener.inventory.isStoring)
                    {
                        source.opener.inventory.closeStorageAndNotifyClient();
                    }

                    source.opener = null;
                }

                source.isOpen = !source.isOpen;
            }

            return source;
        }

        public static InteractableStorage TryAddItemToStorageIfFailedDropIt(this InteractableStorage source, Item item, Player player,
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

            if (player == null)
            {
                throw new ArgumentNullException(nameof(player));
            }

            return TryAddItemToStorageIfFailedDropIt(source, item, player.transform.position, onItemAdded, onItemDropped, onBeforeItemDropped);
        }

        public static InteractableStorage TryAddItemToStorageIfFailedDropIt(this InteractableStorage source, Item item, Vector3 position,
            Action<Item> onItemAdded = null,
            Action<Item> onItemDropped = null,
            Action<Item> onBeforeItemDropped = null)
        {
            return TryAddItemToStorageIfFailedDropIt(source, item, position,
                isStateUpdatable: true, playEffect: true, isDropped: true, wideSpread: false,
                onItemAdded, onItemDropped, onBeforeItemDropped);
        }

        public static InteractableStorage TryAddItemToStorageIfFailedDropIt(this InteractableStorage source, Item item, Vector3 position,
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

            if (source.items.tryAddItem(item, isStateUpdatable) == false)
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

        public static InteractableStorage DropPlayerItemsIntoStorageIfFailedDropIt(this InteractableStorage source, Player player, Vector3 position,
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

            if (player == null)
            {
                throw new ArgumentNullException(nameof(player));
            }


            for (byte page = 0; page < PlayerInventory.PAGES - 2; page++)
            {
                player.inventory.items[page].TransferItemsIfFailedToAddDropItToAnotherAndReturnIt(source.items, position,
                    isStateUpdatable, playEffect, isDropped, wideSpread,
                    onBeforeItemRemovedCallback, onItemRemovedCallback, onItemRemoveCanceled, onItemAdded, onItemDropped, onBeforeItemDropped);
            }

            return source;
        }

        public static InteractableStorage DropPlayerItemsIntoStorageIfFailedDropIt(this InteractableStorage source, Player player,
            bool isStateUpdatable, bool playEffect, bool isDropped, bool wideSpread,
            Predicate<ItemJar> onBeforeItemRemovedCallback = null,
            Action<ItemJar> onItemRemovedCallback = null,
            Action<ItemJar> onItemRemoveCanceled = null,
            Action<Item> onItemAdded = null,
            Action<Item> onItemDropped = null,
            Action<Item> onBeforeItemDropped = null)
        {
            if (player == null)
            {
                throw new ArgumentNullException(nameof(player));
            }

            for (byte page = 0; page < PlayerInventory.PAGES - 2; page++)
            {
                player.inventory.items[page].TransferItemsIfFailedToAddDropItToAnotherAndReturnIt(source.items, player.transform.position,
                    isStateUpdatable, playEffect, isDropped, wideSpread,
                    onBeforeItemRemovedCallback, onItemRemovedCallback, onItemRemoveCanceled, onItemAdded, onItemDropped, onBeforeItemDropped);
            }
                
            return source;
        }
    }
}
