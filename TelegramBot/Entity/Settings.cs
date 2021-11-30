using System;

namespace TelegramBot.Entity
{
    [Serializable]
    public class Settings
    {
        public long? AdminChatId { get; set; }
        public bool WriteChatId { get; set; }
        public string Token { get; set; }
        public string PathToDocWithResults { get; set; }
        public string PathToXmlWithUserPolls { get; set; }
        public string PathToXmlWithPoll { get; set; }
    }
}
