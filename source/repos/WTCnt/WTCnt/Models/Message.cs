using System;

namespace WTCnt.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int User_ID { get; set; }
        public int Project_ID { get; set; }
        public DateTime TimeSend { get; set; }
    }
}