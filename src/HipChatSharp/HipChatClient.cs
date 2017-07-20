using HipChatSharp.Core;
using HipChatSharp.Models;

namespace HipChatSharp
{
    public class HipChatClient : HipChatClientBase
    {
        public HipChatClient(string apiKey = null, string host = null) : base(
            new HipChatConfig() { ApiKey = apiKey, Host = host }, new HipChatEndpointProvider())
        {
        }
    }
}
