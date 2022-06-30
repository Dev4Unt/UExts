using SDG.Unturned;
using System;
using UnityEngine;

namespace UExts.SDG.Unturned.Chat
{
    public class ChatMessageBuilder : IChatMessageBuilder
    {
        private readonly IChatMessage message;



        public ChatMessageBuilder(IChatMessage message)
        {
            this.message = message;
        }

        public ChatMessageBuilder() : this(new ChatMessage())
        {
        }

        

        public IChatMessageBuilder SetColor(Color value)
        {
            message.Color = value;
            return this;
        }

        public IChatMessageBuilder SetIcon(Uri uri)
        {
            message.Icon = uri;
            return this;
        }

        public IChatMessageBuilder SetIcon(string url)
        {
            message.Icon = new Uri(url);
            return this;
        }

        public IChatMessageBuilder SetMode(EChatMode value)
        {
            message.Mode = value;
            return this;
        }

        public IChatMessageBuilder SetReceiver(SteamPlayer player)
        {
            message.Receiver = player;
            return this;
        }

        public IChatMessageBuilder SetSender(SteamPlayer player)
        {
            message.Sender = player;
            return this;
        }

        public IChatMessageBuilder SetText(string content)
        {
            message.Text = content;
            return this;
        }

        public IChatMessageBuilder UseRich()
        {
            message.Rich = true;
            return this;
        }

        public IChatMessage Build()
        {
            return message;
        }
    }
}
