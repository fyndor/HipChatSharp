namespace HipChatSharp.Abstractions
{
    interface IHipChatClient
    {
        string Host { get; set; }
        string ApiKey { get; set; }
        IHipChatRoomsEndpoint Rooms { get; }
    }
}
