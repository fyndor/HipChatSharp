using HipChatSharp.Abstractions;

namespace HipChatSharp.Core
{
    internal class HipChatEndpointProvider : IHipChatEndpointProvider
    {
        public HipChatEndpointProvider()
        {
        }

        public IHipChatRoomsEndpoint RoomsEndpoint { get; set; }
        public IHipChatUsersEndpoint UsersEndpoint { get; set; }
        public IHipChatCapabilitiesEndpoint CapabilitiesEndpoint { get; set; }
        public IHipChatEmoticonsEndpoint EmoticonsEndpoint { get; set; }
        public IHipChatExtensionsEndpoint ExtensionsEndpoint { get; set; }
        public IHipChatFlagsEndpoint FlagsEndpoint { get; set; }
        public IHipChatGroupsEndpoint GroupsEndpoint { get; set; }
        public IHipChatIntegrationsEndpoint IntegrationsEndpoint { get; set; }
        public IHipChatInvitesEndpoint InvitesEndpoint { get; set; }
        public IHipChatPrefsEndpoint PrefsEndpoint { get; set; }
    }
}