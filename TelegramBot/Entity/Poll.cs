using System;

namespace TelegramBot.Entity
{
    [Serializable]
    public class Poll
    {
        public string Introduction { get; set; }
        public UserData[] UserDatas { get; set; }
        public GroupQuestions[] QuestionGroups { get; set; }
        public string Conclusion { get; set; }
    }
}
