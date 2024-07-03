using SDG.Unturned;
using System;
using UnityEngine;

namespace UExts.SDG.Unturned.Chat
{
    public class ChatMessage : IChatMessage
    {
        public string Text { get; set; }

        public Color Color { get; set; } = Color.white;

        public SteamPlayer Sender { get; set; }

        public SteamPlayer Receiver { get; set; }

        public EChatMode Mode { get; set; } = EChatMode.GLOBAL;

        public Uri Icon { get; set; }

        public bool Rich { get; set; }
    }
}
