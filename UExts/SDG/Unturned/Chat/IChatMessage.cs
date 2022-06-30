using SDG.Unturned;
using System;
using UnityEngine;

namespace UExts.SDG.Unturned.Chat
{
    public interface IChatMessage
    {
        string Text { get; set; }

        Color Color { get; set; }

        SteamPlayer Sender { get; set; }

        SteamPlayer Receiver { get; set; }

        EChatMode Mode { get; set; }

        Uri Icon { get; set; }

        bool Rich { get; set;  }
    }
}
