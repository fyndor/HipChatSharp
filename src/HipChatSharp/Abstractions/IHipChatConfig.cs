namespace HipChatSharp.Abstractions
{
    public interface IHipChatConfig
    {
        string ApiKey { get; set; }
        string Host { get; set; }
    }
}