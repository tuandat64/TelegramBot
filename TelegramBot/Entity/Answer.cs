using System;

namespace TelegramBot.Entity
{
    [Serializable]
    public class Answer
    {
        public string AnswerOption { get; set; }
        public double AnswerPoints { get; set; }
    }
}
