using SDG.Unturned;

namespace UExts.SDG.Unturned.Chat
{
    public static class ChatCommunicationEx
    {
        public static void SayToAll(this IChatMessage source)
        {
            ChatManager.say(source.Text, source.Color, source.Rich);
        }

        public static void SendMessage(this IChatMessage source)
        {
            ChatManager.serverSendMessage(source.Text, source.Color, source.Sender, source.Receiver, source.Mode, source.Icon.AbsoluteUri, source.Rich);
        }
    }
}
