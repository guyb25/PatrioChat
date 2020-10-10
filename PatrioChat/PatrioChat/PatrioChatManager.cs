using Common;
using Newtonsoft.Json.Linq;
using PatrioTcpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrioChat
{
    public class PatrioChatManager
    {
        private IPatriotClient _client;
        private PatrioChat _patrioChat;
        private Chat _scopedChat;
        private string _username;

        private ChatsManager _chatsManager;
        private Dictionary<PacketType, Action<Packet>> _packetHandlers;

        public PatrioChatManager(PatrioChat patrioChat, IPatriotClient patriotClient, string username)
        {
            _client = patriotClient;
            _patrioChat = patrioChat;
            _username = username;
            _chatsManager = new ChatsManager();

            InitPacketHandlers();
            Task.Run(() => _client.Listen((packet) => OnPacket(packet)));
            _client.RequestChats(_username);
            _client.RequestUsers();

            _patrioChat.OnChangeChat += (chatIndex) => ChangeChat(chatIndex);
            _patrioChat.OnSendMessage += (message) => SendMessage(message);
            _patrioChat.OnNewChatButton += () => CreateNewChat();
        }

        private void OnPacket(Packet packet)
        {
            if (_packetHandlers.ContainsKey(packet.Type))
            {
                var packetHandler = _packetHandlers[packet.Type];
                _patrioChat.Invoke((MethodInvoker)(() => packetHandler(packet)));
            }
        }

        private void InitPacketHandlers()
        {
            _packetHandlers = new Dictionary<PacketType, Action<Packet>>();
            _packetHandlers.Add(PacketType.NewChat, (packet) => HandleNewChatPacket(packet));
            _packetHandlers.Add(PacketType.NewMessage, (packet) => HandleNewMessagePacket(packet));
            _packetHandlers.Add(PacketType.NewUser, (packet) => HandleNewUserPacket(packet));
        }

        private void HandleNewUserPacket(Packet packet)
        {
            var user = ((JObject)packet.Value).ToObject<User>();
            _chatsManager.AddUser(user);
        }

        private void HandleNewMessagePacket(Packet packet)
        {
            var message = ((JObject)packet.Value).ToObject<Common.Message>();
            _chatsManager.AddMessageToChat(message.TargetRoomId, message);

            if (_scopedChat != null && _scopedChat.ChatId == message.TargetRoomId)
            {
                _patrioChat.DisplayMessage(message);
            }
        }

        private void HandleNewChatPacket(Packet packet)
        {
            var chat = ((JObject)packet.Value).ToObject<Chat>();
            _patrioChat.AddChatRoom(chat.ChatName);
            _chatsManager.AddChat(chat);
        }

        private void ChangeChat(int chatIndex)
        {
            if (chatIndex != -1)
            {
                _scopedChat = _chatsManager.FindChatByIndex(chatIndex);
                _patrioChat.ChangeChat(_scopedChat);
            }
        }

        private void SendMessage(string text)
        {
            if (_scopedChat != null)
            {
                var message = new Common.Message(text, MessageType.Text, _username, _scopedChat.ChatId, DateTime.Now);
                _client.SendMessage(message);
            }
        }

        private void CreateNewChat()
        {
            var newChatForm = new NewChatForm(_chatsManager.Users);

            newChatForm.OnSubmit += (chatName, participants) =>
            {
                _client.CreateNewChat(chatName, participants);
                newChatForm.Close();
            };

            newChatForm.Show();
        }
    }
}