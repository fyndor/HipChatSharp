using System.Collections.Generic;
using HipChatSharp.Abstractions;

namespace HipChatSharp.Core
{
    public class HipChatClientBase : IHipChatClient
    {
        private IHipChatRoomsEndpoint _rooms;
        private IHipChatUsersEndpoint _users;
        private IHipChatCapabilitiesEndpoint _capabilities;
        private IHipChatEmoticonsEndpoint _emoticons;
        private IHipChatExtensionsEndpoint _extensions;
        private IHipChatFlagsEndpoint _flags;
        private IHipChatGroupsEndpoint _groups;
        private IHipChatIntegrationsEndpoint _integrations;
        private IHipChatInvitesEndpoint _invites;
        private IHipChatPrefsEndpoint _prefs;

        public HipChatClientBase(IHipChatConfig config, IHipChatEndpointProvider endpointProvider)
        {
            ApiKey = config.ApiKey ?? string.Empty;
            Host = config.Host ?? HipChatConst.DefaultHost;
            AssignEndpoints(endpointProvider);
        }

        private void AssignEndpoints(IHipChatEndpointProvider provider)
        {
            _rooms = provider.RoomsEndpoint;
            _users = provider.UsersEndpoint;
            _capabilities = provider.CapabilitiesEndpoint;
            _emoticons = provider.EmoticonsEndpoint;
            _extensions = provider.ExtensionsEndpoint;
            _flags = provider.FlagsEndpoint;
            _groups = provider.GroupsEndpoint;
            _integrations = provider.IntegrationsEndpoint;
            _invites = provider.InvitesEndpoint;
            _prefs = provider.PrefsEndpoint;
        }

        public string Host { get; set; }
        public string ApiKey { get; set; }

        public IHipChatRoomsEndpoint Rooms => _rooms;
        public IHipChatUsersEndpoint Users => _users;
        public IHipChatCapabilitiesEndpoint Capabilities => _capabilities;
        public IHipChatEmoticonsEndpoint Emoticons => _emoticons;
        public IHipChatExtensionsEndpoint Extensions => _extensions;
        public IHipChatFlagsEndpoint Flags => _flags;
        public IHipChatGroupsEndpoint Groups => _groups;
        public IHipChatIntegrationsEndpoint Integrations => _integrations;
        public IHipChatInvitesEndpoint Invites => _invites;
        public IHipChatPrefsEndpoint Prefs => _prefs;

        private IHttpClient Client { get; set; }
        
    }
}
