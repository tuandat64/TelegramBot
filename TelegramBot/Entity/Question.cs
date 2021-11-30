using System;

namespace TelegramBot.Entity
{
    [Serializable]
    public class Question
    {
        public string QuestionText { get; set; }
        public Answer[] AnswerOptions { get; set; }
        public bool TextIsSent { get; set; }
        public bool IsPassed { get; set; }
        public double PointsReceived { get; set; }
    }
}
