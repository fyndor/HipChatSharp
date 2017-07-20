using HipChatSharp.Abstractions;

namespace HipChatSharp.Models
{
    public struct HipChatConfig : IHipChatConfig
    {
        public string ApiKey { get; set; }
        public string Host { get; set; }
    }
}
