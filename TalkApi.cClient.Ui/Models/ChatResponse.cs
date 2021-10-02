using System;

namespace TalkApi.cClient.Ui.Models
{
    public class ChatResponse
    {
        public int id { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
        public string Channel { get; set; }
        public DateTime createdAt { get; set; }
    }
}