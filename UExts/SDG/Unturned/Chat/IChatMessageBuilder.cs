using SDG.Unturned;
using System;
using UnityEngine;

namespace UExts.SDG.Unturned.Chat
{
    public interface IChatMessageBuilder
    {
        IChatMessageBuilder SetText(string content);

        IChatMessageBuilder SetReceiver(SteamPlayer player);

        IChatMessageBuilder SetSender(SteamPlayer player);

        IChatMessageBuilder SetColor(Color value);

        IChatMessageBuilder SetMode(EChatMode value);

        IChatMessageBuilder SetIcon(Uri uri);

        IChatMessageBuilder SetIcon(string url);

        IChatMessageBuilder UseRich();

        IChatMessage Build();
    }
}
