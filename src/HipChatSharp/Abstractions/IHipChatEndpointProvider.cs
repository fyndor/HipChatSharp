namespace HipChatSharp.Abstractions
{
    public interface IHipChatEndpointProvider
    {
        IHipChatRoomsEndpoint RoomsEndpoint { get; set; }
        IHipChatUsersEndpoint UsersEndpoint { get; set; }
        IHipChatCapabilitiesEndpoint CapabilitiesEndpoint { get; set; }
        IHipChatEmoticonsEndpoint EmoticonsEndpoint { get; set; }
        IHipChatExtensionsEndpoint ExtensionsEndpoint { get; set; }
        IHipChatFlagsEndpoint FlagsEndpoint { get; set; }
        IHipChatGroupsEndpoint GroupsEndpoint { get; set; }
        IHipChatIntegrationsEndpoint IntegrationsEndpoint { get; set; }
        IHipChatInvitesEndpoint InvitesEndpoint { get; set; }
        IHipChatPrefsEndpoint PrefsEndpoint { get; set; }
    }
}