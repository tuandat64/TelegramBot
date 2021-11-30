using System;

namespace TelegramBot.Entity
{
    [Serializable]
    public class UserPoll
    {
        public long UserId { get; set; }
        public Poll Poll { get; set; }
    }
}
