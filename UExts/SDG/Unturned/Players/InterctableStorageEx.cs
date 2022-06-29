using SDG.Unturned;
using System;

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
                                return barricadeRegion.drops[i].interactable as InteractableStorage;
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

    }
}