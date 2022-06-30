using SDG.Unturned;
using System;

namespace UExts.SDG.Unturned.Players
{
    [Flags]
    public enum PlayerInventoryPages : byte
    {
        Slot1 = 1,
        Slot2 = 2,
        Slots = 3,
        Backpack = 4,
        Vest = 8,
        Shirt = 16,
        Pants = 32,
        Clothes = 60,
        Storage = 64,
        All = 127,
        Area = 128
    }
    
    public static class PlayerInventoryEx
    {
        public static PlayerInventory Clear(this PlayerInventory source, PlayerInventoryPages page)
        {
            return source.Clear(page, null);
        }

        public static PlayerInventory Clear(this PlayerInventory source, PlayerInventoryPages page, Predicate<ItemJar> predicate)
        {
            _ = (page & PlayerInventoryPages.Slot1) == PlayerInventoryPages.Slot1 ? source.items[0]?.Clear(predicate) : null;
            _ = (page & PlayerInventoryPages.Slot2) == PlayerInventoryPages.Slot2 ? source.items[1]?.Clear(predicate) : null;
            _ = (page & PlayerInventoryPages.Backpack) == PlayerInventoryPages.Backpack ? source.items[2]?.Clear(predicate) : null;
            _ = (page & PlayerInventoryPages.Vest) == PlayerInventoryPages.Vest ? source.items[3]?.Clear(predicate) : null;
            _ = (page & PlayerInventoryPages.Shirt) == PlayerInventoryPages.Shirt ? source.items[4]?.Clear(predicate) : null;
            _ = (page & PlayerInventoryPages.Pants) == PlayerInventoryPages.Pants ? source.items[5]?.Clear(predicate) : null;
            _ = (page & PlayerInventoryPages.Storage) == PlayerInventoryPages.Storage ? source.items[6]?.Clear(predicate) : null;
            _ = (page & PlayerInventoryPages.Area) == PlayerInventoryPages.Area ? source.items[7]?.Clear(predicate) : null;

            return source;
        }  
    }
}